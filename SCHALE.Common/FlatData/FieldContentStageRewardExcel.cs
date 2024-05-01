// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct FieldContentStageRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldContentStageRewardExcel GetRootAsFieldContentStageRewardExcel(ByteBuffer _bb) { return GetRootAsFieldContentStageRewardExcel(_bb, new FieldContentStageRewardExcel()); }
  public static FieldContentStageRewardExcel GetRootAsFieldContentStageRewardExcel(ByteBuffer _bb, FieldContentStageRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldContentStageRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.RewardTag RewardTag { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.RewardTag.Default; } }
  public int RewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long RewardId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RewardAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.FieldContentStageRewardExcel> CreateFieldContentStageRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      SCHALE.Common.FlatData.RewardTag RewardTag = SCHALE.Common.FlatData.RewardTag.Default,
      int RewardProb = 0,
      SCHALE.Common.FlatData.ParcelType RewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long RewardId = 0,
      int RewardAmount = 0,
      bool IsDisplayed = false) {
    builder.StartTable(7);
    FieldContentStageRewardExcel.AddRewardId(builder, RewardId);
    FieldContentStageRewardExcel.AddGroupId(builder, GroupId);
    FieldContentStageRewardExcel.AddRewardAmount(builder, RewardAmount);
    FieldContentStageRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    FieldContentStageRewardExcel.AddRewardProb(builder, RewardProb);
    FieldContentStageRewardExcel.AddRewardTag(builder, RewardTag);
    FieldContentStageRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return FieldContentStageRewardExcel.EndFieldContentStageRewardExcel(builder);
  }

  public static void StartFieldContentStageRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(0, groupId, 0); }
  public static void AddRewardTag(FlatBufferBuilder builder, SCHALE.Common.FlatData.RewardTag rewardTag) { builder.AddInt(1, (int)rewardTag, 0); }
  public static void AddRewardProb(FlatBufferBuilder builder, int rewardProb) { builder.AddInt(2, rewardProb, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType rewardParcelType) { builder.AddInt(3, (int)rewardParcelType, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, long rewardId) { builder.AddLong(4, rewardId, 0); }
  public static void AddRewardAmount(FlatBufferBuilder builder, int rewardAmount) { builder.AddInt(5, rewardAmount, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool isDisplayed) { builder.AddBool(6, isDisplayed, false); }
  public static Offset<SCHALE.Common.FlatData.FieldContentStageRewardExcel> EndFieldContentStageRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FieldContentStageRewardExcel>(o);
  }
  public FieldContentStageRewardExcelT UnPack() {
    var _o = new FieldContentStageRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldContentStageRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FieldContentStageReward");
    _o.GroupId = TableEncryptionService.Convert(this.GroupId, key);
    _o.RewardTag = TableEncryptionService.Convert(this.RewardTag, key);
    _o.RewardProb = TableEncryptionService.Convert(this.RewardProb, key);
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardId = TableEncryptionService.Convert(this.RewardId, key);
    _o.RewardAmount = TableEncryptionService.Convert(this.RewardAmount, key);
    _o.IsDisplayed = TableEncryptionService.Convert(this.IsDisplayed, key);
  }
  public static Offset<SCHALE.Common.FlatData.FieldContentStageRewardExcel> Pack(FlatBufferBuilder builder, FieldContentStageRewardExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.FieldContentStageRewardExcel>);
    return CreateFieldContentStageRewardExcel(
      builder,
      _o.GroupId,
      _o.RewardTag,
      _o.RewardProb,
      _o.RewardParcelType,
      _o.RewardId,
      _o.RewardAmount,
      _o.IsDisplayed);
  }
}

public class FieldContentStageRewardExcelT
{
  public long GroupId { get; set; }
  public SCHALE.Common.FlatData.RewardTag RewardTag { get; set; }
  public int RewardProb { get; set; }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardId { get; set; }
  public int RewardAmount { get; set; }
  public bool IsDisplayed { get; set; }

  public FieldContentStageRewardExcelT() {
    this.GroupId = 0;
    this.RewardTag = SCHALE.Common.FlatData.RewardTag.Default;
    this.RewardProb = 0;
    this.RewardParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.RewardId = 0;
    this.RewardAmount = 0;
    this.IsDisplayed = false;
  }
}


static public class FieldContentStageRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RewardTag*/, 4 /*SCHALE.Common.FlatData.RewardTag*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RewardProb*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*RewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*RewardAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*IsDisplayed*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}