// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct BulletArmorDamageFactorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static BulletArmorDamageFactorExcel GetRootAsBulletArmorDamageFactorExcel(ByteBuffer _bb) { return GetRootAsBulletArmorDamageFactorExcel(_bb, new BulletArmorDamageFactorExcel()); }
  public static BulletArmorDamageFactorExcel GetRootAsBulletArmorDamageFactorExcel(ByteBuffer _bb, BulletArmorDamageFactorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BulletArmorDamageFactorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DamageFactorGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDamageFactorGroupIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDamageFactorGroupIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDamageFactorGroupIdArray() { return __p.__vector_as_array<byte>(4); }
  public SCHALE.Common.FlatData.BulletType BulletType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.BulletType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.BulletType.Normal; } }
  public SCHALE.Common.FlatData.ArmorType ArmorType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ArmorType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ArmorType.LightArmor; } }
  public long DamageRate { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.DamageAttribute DamageAttribute { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.DamageAttribute)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.DamageAttribute.Resist; } }
  public long MinDamageRate { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxDamageRate { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ShowHighlightFloater { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.BulletArmorDamageFactorExcel> CreateBulletArmorDamageFactorExcel(FlatBufferBuilder builder,
      StringOffset DamageFactorGroupIdOffset = default(StringOffset),
      SCHALE.Common.FlatData.BulletType BulletType = SCHALE.Common.FlatData.BulletType.Normal,
      SCHALE.Common.FlatData.ArmorType ArmorType = SCHALE.Common.FlatData.ArmorType.LightArmor,
      long DamageRate = 0,
      SCHALE.Common.FlatData.DamageAttribute DamageAttribute = SCHALE.Common.FlatData.DamageAttribute.Resist,
      long MinDamageRate = 0,
      long MaxDamageRate = 0,
      bool ShowHighlightFloater = false) {
    builder.StartTable(8);
    BulletArmorDamageFactorExcel.AddMaxDamageRate(builder, MaxDamageRate);
    BulletArmorDamageFactorExcel.AddMinDamageRate(builder, MinDamageRate);
    BulletArmorDamageFactorExcel.AddDamageRate(builder, DamageRate);
    BulletArmorDamageFactorExcel.AddDamageAttribute(builder, DamageAttribute);
    BulletArmorDamageFactorExcel.AddArmorType(builder, ArmorType);
    BulletArmorDamageFactorExcel.AddBulletType(builder, BulletType);
    BulletArmorDamageFactorExcel.AddDamageFactorGroupId(builder, DamageFactorGroupIdOffset);
    BulletArmorDamageFactorExcel.AddShowHighlightFloater(builder, ShowHighlightFloater);
    return BulletArmorDamageFactorExcel.EndBulletArmorDamageFactorExcel(builder);
  }

  public static void StartBulletArmorDamageFactorExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddDamageFactorGroupId(FlatBufferBuilder builder, StringOffset damageFactorGroupIdOffset) { builder.AddOffset(0, damageFactorGroupIdOffset.Value, 0); }
  public static void AddBulletType(FlatBufferBuilder builder, SCHALE.Common.FlatData.BulletType bulletType) { builder.AddInt(1, (int)bulletType, 0); }
  public static void AddArmorType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ArmorType armorType) { builder.AddInt(2, (int)armorType, 0); }
  public static void AddDamageRate(FlatBufferBuilder builder, long damageRate) { builder.AddLong(3, damageRate, 0); }
  public static void AddDamageAttribute(FlatBufferBuilder builder, SCHALE.Common.FlatData.DamageAttribute damageAttribute) { builder.AddInt(4, (int)damageAttribute, 0); }
  public static void AddMinDamageRate(FlatBufferBuilder builder, long minDamageRate) { builder.AddLong(5, minDamageRate, 0); }
  public static void AddMaxDamageRate(FlatBufferBuilder builder, long maxDamageRate) { builder.AddLong(6, maxDamageRate, 0); }
  public static void AddShowHighlightFloater(FlatBufferBuilder builder, bool showHighlightFloater) { builder.AddBool(7, showHighlightFloater, false); }
  public static Offset<SCHALE.Common.FlatData.BulletArmorDamageFactorExcel> EndBulletArmorDamageFactorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.BulletArmorDamageFactorExcel>(o);
  }
  public BulletArmorDamageFactorExcelT UnPack() {
    var _o = new BulletArmorDamageFactorExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BulletArmorDamageFactorExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("BulletArmorDamageFactor");
    _o.DamageFactorGroupId = TableEncryptionService.Convert(this.DamageFactorGroupId, key);
    _o.BulletType = TableEncryptionService.Convert(this.BulletType, key);
    _o.ArmorType = TableEncryptionService.Convert(this.ArmorType, key);
    _o.DamageRate = TableEncryptionService.Convert(this.DamageRate, key);
    _o.DamageAttribute = TableEncryptionService.Convert(this.DamageAttribute, key);
    _o.MinDamageRate = TableEncryptionService.Convert(this.MinDamageRate, key);
    _o.MaxDamageRate = TableEncryptionService.Convert(this.MaxDamageRate, key);
    _o.ShowHighlightFloater = TableEncryptionService.Convert(this.ShowHighlightFloater, key);
  }
  public static Offset<SCHALE.Common.FlatData.BulletArmorDamageFactorExcel> Pack(FlatBufferBuilder builder, BulletArmorDamageFactorExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.BulletArmorDamageFactorExcel>);
    var _DamageFactorGroupId = _o.DamageFactorGroupId == null ? default(StringOffset) : builder.CreateString(_o.DamageFactorGroupId);
    return CreateBulletArmorDamageFactorExcel(
      builder,
      _DamageFactorGroupId,
      _o.BulletType,
      _o.ArmorType,
      _o.DamageRate,
      _o.DamageAttribute,
      _o.MinDamageRate,
      _o.MaxDamageRate,
      _o.ShowHighlightFloater);
  }
}

public class BulletArmorDamageFactorExcelT
{
  public string DamageFactorGroupId { get; set; }
  public SCHALE.Common.FlatData.BulletType BulletType { get; set; }
  public SCHALE.Common.FlatData.ArmorType ArmorType { get; set; }
  public long DamageRate { get; set; }
  public SCHALE.Common.FlatData.DamageAttribute DamageAttribute { get; set; }
  public long MinDamageRate { get; set; }
  public long MaxDamageRate { get; set; }
  public bool ShowHighlightFloater { get; set; }

  public BulletArmorDamageFactorExcelT() {
    this.DamageFactorGroupId = null;
    this.BulletType = SCHALE.Common.FlatData.BulletType.Normal;
    this.ArmorType = SCHALE.Common.FlatData.ArmorType.LightArmor;
    this.DamageRate = 0;
    this.DamageAttribute = SCHALE.Common.FlatData.DamageAttribute.Resist;
    this.MinDamageRate = 0;
    this.MaxDamageRate = 0;
    this.ShowHighlightFloater = false;
  }
}


static public class BulletArmorDamageFactorExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*DamageFactorGroupId*/, false)
      && verifier.VerifyField(tablePos, 6 /*BulletType*/, 4 /*SCHALE.Common.FlatData.BulletType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ArmorType*/, 4 /*SCHALE.Common.FlatData.ArmorType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DamageRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*DamageAttribute*/, 4 /*SCHALE.Common.FlatData.DamageAttribute*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*MinDamageRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*MaxDamageRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*ShowHighlightFloater*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}