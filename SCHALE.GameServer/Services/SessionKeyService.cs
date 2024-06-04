using SCHALE.Common.Database;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Controllers.Api;

namespace SCHALE.GameServer.Services
{
    public class MemorySessionKeyService : ISessionKeyService
    {
        /// <summary>
        /// A map of <see cref="Account.ServerId"/> to <see cref="SessionKey.MxToken"/>
        /// </summary>
        private readonly Dictionary<long, Guid> sessions = [];
        private readonly SCHALEContext context;

        public MemorySessionKeyService(SCHALEContext _context)
        {
            context = _context;
        }

        public long GetAccountServerId(SessionKey? sessionKey)
        {
            if (sessionKey is null)
                throw new WebAPIException(WebAPIErrorCode.InvalidSession, "SessionKey not received");

            if (sessions.TryGetValue(sessionKey.AccountServerId, out Guid token) && token.ToString() == sessionKey.MxToken)
            {
                return sessionKey.AccountServerId;
            }

            throw new WebAPIException(WebAPIErrorCode.SessionNotFound, "Session key is invalid");
        }

        public AccountDB GetAccount(SessionKey? sessionKey)
        {
            var accountID = GetAccountServerId(sessionKey);
            var account = context.Accounts.SingleOrDefault(x => x.ServerId == accountID);

            if (account is not null)
                return account;

            throw new WebAPIException(WebAPIErrorCode.SessionNotFound, "Failed to get AccountDB from session");
        }

        public SessionKey? Create(long publisherAccountId)
        {
            var account = context.Accounts.SingleOrDefault(x => x.PublisherAccountId == publisherAccountId);
            if (account is null)
                return null;

            if (sessions.ContainsKey(account.ServerId))
            {
                sessions[account.ServerId] = Guid.NewGuid();
            }
            else
            {
                sessions.Add(account.ServerId, Guid.NewGuid());
            }

            return new()
            {
                AccountServerId = account.ServerId,
                MxToken = sessions[account.ServerId].ToString()
            };
        }
    }

    internal static class SessionKeyServiceExtensions
    {
        public static void AddMemorySessionKeyService(this IServiceCollection services)
        {
            services.AddSingleton<ISessionKeyService, MemorySessionKeyService>();
        }
    }

    public interface ISessionKeyService
    {
        public SessionKey? Create(long publisherAccountId);
        public long GetAccountServerId(SessionKey? sessionKey);
        public AccountDB GetAccount(SessionKey? sessionKey);
    }
}
