// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct DuplicateBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static DuplicateBonusExcel GetRootAsDuplicateBonusExcel(ByteBuffer _bb) { return GetRootAsDuplicateBonusExcel(_bb, new DuplicateBonusExcel()); }
  public static DuplicateBonusExcel GetRootAsDuplicateBonusExcel(ByteBuffer _bb, DuplicateBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DuplicateBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ItemCategory ItemCategory { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ItemCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ItemCategory.Coin; } }
  public long ItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.DuplicateBonusExcel> CreateDuplicateBonusExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.ItemCategory ItemCategory = SCHALE.Common.FlatData.ItemCategory.Coin,
      long ItemId = 0,
      long CharacterId = 0,
      SCHALE.Common.FlatData.ParcelType RewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0) {
    builder.StartTable(7);
    DuplicateBonusExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    DuplicateBonusExcel.AddRewardParcelId(builder, RewardParcelId);
    DuplicateBonusExcel.AddCharacterId(builder, CharacterId);
    DuplicateBonusExcel.AddItemId(builder, ItemId);
    DuplicateBonusExcel.AddId(builder, Id);
    DuplicateBonusExcel.AddRewardParcelType(builder, RewardParcelType);
    DuplicateBonusExcel.AddItemCategory(builder, ItemCategory);
    return DuplicateBonusExcel.EndDuplicateBonusExcel(builder);
  }

  public static void StartDuplicateBonusExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddItemCategory(FlatBufferBuilder builder, SCHALE.Common.FlatData.ItemCategory itemCategory) { builder.AddInt(1, (int)itemCategory, 0); }
  public static void AddItemId(FlatBufferBuilder builder, long itemId) { builder.AddLong(2, itemId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(3, characterId, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType rewardParcelType) { builder.AddInt(4, (int)rewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long rewardParcelId) { builder.AddLong(5, rewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long rewardParcelAmount) { builder.AddLong(6, rewardParcelAmount, 0); }
  public static Offset<SCHALE.Common.FlatData.DuplicateBonusExcel> EndDuplicateBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.DuplicateBonusExcel>(o);
  }
  public DuplicateBonusExcelT UnPack() {
    var _o = new DuplicateBonusExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DuplicateBonusExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("DuplicateBonus");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.ItemCategory = TableEncryptionService.Convert(this.ItemCategory, key);
    _o.ItemId = TableEncryptionService.Convert(this.ItemId, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardParcelId = TableEncryptionService.Convert(this.RewardParcelId, key);
    _o.RewardParcelAmount = TableEncryptionService.Convert(this.RewardParcelAmount, key);
  }
  public static Offset<SCHALE.Common.FlatData.DuplicateBonusExcel> Pack(FlatBufferBuilder builder, DuplicateBonusExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.DuplicateBonusExcel>);
    return CreateDuplicateBonusExcel(
      builder,
      _o.Id,
      _o.ItemCategory,
      _o.ItemId,
      _o.CharacterId,
      _o.RewardParcelType,
      _o.RewardParcelId,
      _o.RewardParcelAmount);
  }
}

public class DuplicateBonusExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.ItemCategory ItemCategory { get; set; }
  public long ItemId { get; set; }
  public long CharacterId { get; set; }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardParcelId { get; set; }
  public long RewardParcelAmount { get; set; }

  public DuplicateBonusExcelT() {
    this.Id = 0;
    this.ItemCategory = SCHALE.Common.FlatData.ItemCategory.Coin;
    this.ItemId = 0;
    this.CharacterId = 0;
    this.RewardParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.RewardParcelId = 0;
    this.RewardParcelAmount = 0;
  }
}


static public class DuplicateBonusExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ItemCategory*/, 4 /*SCHALE.Common.FlatData.ItemCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ItemId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*RewardParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*RewardParcelAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}