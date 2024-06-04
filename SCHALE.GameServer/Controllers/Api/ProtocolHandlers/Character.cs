using SCHALE.Common.Database;
using SCHALE.Common.Database.ModelExtensions;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Character : ProtocolHandlerBase
    {
        private readonly ISessionKeyService sessionKeyService;
        private readonly SCHALEContext context;
        private readonly ExcelTableService excelTableService;

        public Character(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context, ExcelTableService _excelTableService) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
            excelTableService = _excelTableService;
        }

        [ProtocolHandler(Protocol.Character_SetFavorites)]
        public ResponsePacket SetFavoritesHandler(CharacterSetFavoritesRequest req)
        {
            return new CharacterSetFavoritesResponse();
        }

        [ProtocolHandler(Protocol.Character_UnlockWeapon)]
        public ResponsePacket UnlockWeaponHandler(CharacterUnlockWeaponRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);
            var newWeapon = new WeaponDB()
            {
                UniqueId = account.Characters.FirstOrDefault(x => x.ServerId == req.TargetCharacterServerId).UniqueId,
                BoundCharacterServerId = req.TargetCharacterServerId,
                IsLocked = false,
                StarGrade = 1,
                Level = 1
            };

            account.AddWeapons(context, [newWeapon]);
            context.SaveChanges();

            return new CharacterUnlockWeaponResponse()
            {
                WeaponDB = newWeapon,
            };
        }

        [ProtocolHandler(Protocol.Character_PotentialGrowth)]
        public ResponsePacket PotentialGrowthHandler(CharacterPotentialGrowthRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);
            var targetCharacter = account.Characters.FirstOrDefault(x => x.ServerId == req.TargetCharacterDBId)!;

            foreach (var growthReq in req.PotentialGrowthRequestDBs)
            {
                targetCharacter.PotentialStats[(int)growthReq.Type] = growthReq.Level;
            }

            context.SaveChanges();

            return new CharacterPotentialGrowthResponse()
            {
                CharacterDB = targetCharacter
            };
        }

        [ProtocolHandler(Protocol.Character_Transcendence)]
        public ResponsePacket TranscendenceHandler(CharacterTranscendenceRequest req)
        {
            // TODO: implement right reponse
            // e.g. return new item count
            var accountID = sessionKeyService.GetAccountServerId(req.SessionKey);
            var ch = context.GetCharacter(req.TargetCharacterServerId)!;
            var itemNeeded = ch!.StarGrade switch
            {
                1 => 30,
                2 => 80,
                3 => 100,
                4 => 120,
                _ => throw new ArgumentOutOfRangeException(),
            };

            var item = context.GetItem(accountID, ch.UniqueId);
            if (item == null || item.StackCount < itemNeeded) throw new InvalidOperationException("stone not enough");

            using var trn = context.Database.BeginTransaction();

            try {
                ch.StarGrade++;
                item.StackCount -= itemNeeded;

                context.SaveChanges();
                trn.Commit();
            } catch (Exception) {
                throw;
            }

            return new CharacterTranscendenceResponse()
            {
                CharacterDB = ch,
                ParcelResultDB = new()
                {
                    ItemDBs = new Dictionary<long, ItemDB> { { item.UniqueId, item } }
                }
            };
        }

        [ProtocolHandler(Protocol.Character_WeaponTranscendence)]
        public ResponsePacket WeaponTranscendenceHandler(CharacterWeaponTranscendenceRequest req)
        {
            // TODO: implement right reponse
            var accountID = sessionKeyService.GetAccountServerId(req.SessionKey);
            var ch = context.GetCharacter(req.TargetCharacterServerId, false)!;
            var weapon = context.GetWeapon(accountID, ch.UniqueId);
            if (weapon == null) throw new InvalidOperationException("character has no weapon");

            var itemNeeded = weapon.StarGrade switch
            {
                1 => 120,
                2 => 180,
                _ => throw new ArgumentOutOfRangeException(),
            };

            var item = context.GetItem(accountID, ch.UniqueId);
            if (item == null || item.StackCount < itemNeeded) throw new InvalidOperationException("stone not enough");

            using var trn = context.Database.BeginTransaction();

            try
            {
                weapon.StarGrade++;
                item.StackCount -= itemNeeded;

                context.SaveChanges();
                trn.Commit();
            } catch (Exception)
            {
                throw;
            }

            return new CharacterWeaponTranscendenceResponse()
            {
                ParcelResultDB = new()
                {
                    ItemDBs = new Dictionary<long, ItemDB> { { item.UniqueId, item } },
                    WeaponDBs = new List<WeaponDB> { weapon },
                }
            };
        }
    }
}
