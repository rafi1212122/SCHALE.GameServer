// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct EmblemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EmblemExcel GetRootAsEmblemExcel(ByteBuffer _bb) { return GetRootAsEmblemExcel(_bb, new EmblemExcel()); }
  public static EmblemExcel GetRootAsEmblemExcel(ByteBuffer _bb, EmblemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EmblemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EmblemCategory Category { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.EmblemCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EmblemCategory.None; } }
  public SCHALE.Common.FlatData.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.Rarity.N; } }
  public long DisplayOrder { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeCodeId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long UseAtLocalizeId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool EmblemTextVisible { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string IconPath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(20); }
  public string EmblemIconPath { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmblemIconPathBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetEmblemIconPathBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetEmblemIconPathArray() { return __p.__vector_as_array<byte>(22); }
  public int EmblemIconNumControl { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string EmblemIconBGPath { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmblemIconBGPathBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetEmblemIconBGPathBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetEmblemIconBGPathArray() { return __p.__vector_as_array<byte>(26); }
  public string EmblemBGPathJp { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmblemBGPathJpBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetEmblemBGPathJpBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetEmblemBGPathJpArray() { return __p.__vector_as_array<byte>(28); }
  public string EmblemBGPathKr { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmblemBGPathKrBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetEmblemBGPathKrBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetEmblemBGPathKrArray() { return __p.__vector_as_array<byte>(30); }
  public SCHALE.Common.FlatData.EmblemDisplayType DisplayType { get { int o = __p.__offset(32); return o != 0 ? (SCHALE.Common.FlatData.EmblemDisplayType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EmblemDisplayType.Always; } }
  public string DisplayStartDate { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDisplayStartDateBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetDisplayStartDateBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetDisplayStartDateArray() { return __p.__vector_as_array<byte>(34); }
  public string DisplayEndDate { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDisplayEndDateBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetDisplayEndDateBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetDisplayEndDateArray() { return __p.__vector_as_array<byte>(36); }
  public int DislpayFavorLevel { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public SCHALE.Common.FlatData.EmblemCheckPassType CheckPassType { get { int o = __p.__offset(40); return o != 0 ? (SCHALE.Common.FlatData.EmblemCheckPassType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EmblemCheckPassType.None; } }
  public long EmblemParameter { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CheckPassCount { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.EmblemExcel> CreateEmblemExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.EmblemCategory Category = SCHALE.Common.FlatData.EmblemCategory.None,
      SCHALE.Common.FlatData.Rarity Rarity = SCHALE.Common.FlatData.Rarity.N,
      long DisplayOrder = 0,
      uint LocalizeEtcId = 0,
      uint LocalizeCodeId = 0,
      long UseAtLocalizeId = 0,
      bool EmblemTextVisible = false,
      StringOffset IconPathOffset = default(StringOffset),
      StringOffset EmblemIconPathOffset = default(StringOffset),
      int EmblemIconNumControl = 0,
      StringOffset EmblemIconBGPathOffset = default(StringOffset),
      StringOffset EmblemBGPathJpOffset = default(StringOffset),
      StringOffset EmblemBGPathKrOffset = default(StringOffset),
      SCHALE.Common.FlatData.EmblemDisplayType DisplayType = SCHALE.Common.FlatData.EmblemDisplayType.Always,
      StringOffset DisplayStartDateOffset = default(StringOffset),
      StringOffset DisplayEndDateOffset = default(StringOffset),
      int DislpayFavorLevel = 0,
      SCHALE.Common.FlatData.EmblemCheckPassType CheckPassType = SCHALE.Common.FlatData.EmblemCheckPassType.None,
      long EmblemParameter = 0,
      long CheckPassCount = 0) {
    builder.StartTable(21);
    EmblemExcel.AddCheckPassCount(builder, CheckPassCount);
    EmblemExcel.AddEmblemParameter(builder, EmblemParameter);
    EmblemExcel.AddUseAtLocalizeId(builder, UseAtLocalizeId);
    EmblemExcel.AddDisplayOrder(builder, DisplayOrder);
    EmblemExcel.AddId(builder, Id);
    EmblemExcel.AddCheckPassType(builder, CheckPassType);
    EmblemExcel.AddDislpayFavorLevel(builder, DislpayFavorLevel);
    EmblemExcel.AddDisplayEndDate(builder, DisplayEndDateOffset);
    EmblemExcel.AddDisplayStartDate(builder, DisplayStartDateOffset);
    EmblemExcel.AddDisplayType(builder, DisplayType);
    EmblemExcel.AddEmblemBGPathKr(builder, EmblemBGPathKrOffset);
    EmblemExcel.AddEmblemBGPathJp(builder, EmblemBGPathJpOffset);
    EmblemExcel.AddEmblemIconBGPath(builder, EmblemIconBGPathOffset);
    EmblemExcel.AddEmblemIconNumControl(builder, EmblemIconNumControl);
    EmblemExcel.AddEmblemIconPath(builder, EmblemIconPathOffset);
    EmblemExcel.AddIconPath(builder, IconPathOffset);
    EmblemExcel.AddLocalizeCodeId(builder, LocalizeCodeId);
    EmblemExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EmblemExcel.AddRarity(builder, Rarity);
    EmblemExcel.AddCategory(builder, Category);
    EmblemExcel.AddEmblemTextVisible(builder, EmblemTextVisible);
    return EmblemExcel.EndEmblemExcel(builder);
  }

  public static void StartEmblemExcel(FlatBufferBuilder builder) { builder.StartTable(21); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCategory(FlatBufferBuilder builder, SCHALE.Common.FlatData.EmblemCategory category) { builder.AddInt(1, (int)category, 0); }
  public static void AddRarity(FlatBufferBuilder builder, SCHALE.Common.FlatData.Rarity rarity) { builder.AddInt(2, (int)rarity, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long displayOrder) { builder.AddLong(3, displayOrder, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(4, localizeEtcId, 0); }
  public static void AddLocalizeCodeId(FlatBufferBuilder builder, uint localizeCodeId) { builder.AddUint(5, localizeCodeId, 0); }
  public static void AddUseAtLocalizeId(FlatBufferBuilder builder, long useAtLocalizeId) { builder.AddLong(6, useAtLocalizeId, 0); }
  public static void AddEmblemTextVisible(FlatBufferBuilder builder, bool emblemTextVisible) { builder.AddBool(7, emblemTextVisible, false); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(8, iconPathOffset.Value, 0); }
  public static void AddEmblemIconPath(FlatBufferBuilder builder, StringOffset emblemIconPathOffset) { builder.AddOffset(9, emblemIconPathOffset.Value, 0); }
  public static void AddEmblemIconNumControl(FlatBufferBuilder builder, int emblemIconNumControl) { builder.AddInt(10, emblemIconNumControl, 0); }
  public static void AddEmblemIconBGPath(FlatBufferBuilder builder, StringOffset emblemIconBGPathOffset) { builder.AddOffset(11, emblemIconBGPathOffset.Value, 0); }
  public static void AddEmblemBGPathJp(FlatBufferBuilder builder, StringOffset emblemBGPathJpOffset) { builder.AddOffset(12, emblemBGPathJpOffset.Value, 0); }
  public static void AddEmblemBGPathKr(FlatBufferBuilder builder, StringOffset emblemBGPathKrOffset) { builder.AddOffset(13, emblemBGPathKrOffset.Value, 0); }
  public static void AddDisplayType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EmblemDisplayType displayType) { builder.AddInt(14, (int)displayType, 0); }
  public static void AddDisplayStartDate(FlatBufferBuilder builder, StringOffset displayStartDateOffset) { builder.AddOffset(15, displayStartDateOffset.Value, 0); }
  public static void AddDisplayEndDate(FlatBufferBuilder builder, StringOffset displayEndDateOffset) { builder.AddOffset(16, displayEndDateOffset.Value, 0); }
  public static void AddDislpayFavorLevel(FlatBufferBuilder builder, int dislpayFavorLevel) { builder.AddInt(17, dislpayFavorLevel, 0); }
  public static void AddCheckPassType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EmblemCheckPassType checkPassType) { builder.AddInt(18, (int)checkPassType, 0); }
  public static void AddEmblemParameter(FlatBufferBuilder builder, long emblemParameter) { builder.AddLong(19, emblemParameter, 0); }
  public static void AddCheckPassCount(FlatBufferBuilder builder, long checkPassCount) { builder.AddLong(20, checkPassCount, 0); }
  public static Offset<SCHALE.Common.FlatData.EmblemExcel> EndEmblemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EmblemExcel>(o);
  }
  public EmblemExcelT UnPack() {
    var _o = new EmblemExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EmblemExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("Emblem");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Category = TableEncryptionService.Convert(this.Category, key);
    _o.Rarity = TableEncryptionService.Convert(this.Rarity, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.LocalizeCodeId = TableEncryptionService.Convert(this.LocalizeCodeId, key);
    _o.UseAtLocalizeId = TableEncryptionService.Convert(this.UseAtLocalizeId, key);
    _o.EmblemTextVisible = TableEncryptionService.Convert(this.EmblemTextVisible, key);
    _o.IconPath = TableEncryptionService.Convert(this.IconPath, key);
    _o.EmblemIconPath = TableEncryptionService.Convert(this.EmblemIconPath, key);
    _o.EmblemIconNumControl = TableEncryptionService.Convert(this.EmblemIconNumControl, key);
    _o.EmblemIconBGPath = TableEncryptionService.Convert(this.EmblemIconBGPath, key);
    _o.EmblemBGPathJp = TableEncryptionService.Convert(this.EmblemBGPathJp, key);
    _o.EmblemBGPathKr = TableEncryptionService.Convert(this.EmblemBGPathKr, key);
    _o.DisplayType = TableEncryptionService.Convert(this.DisplayType, key);
    _o.DisplayStartDate = TableEncryptionService.Convert(this.DisplayStartDate, key);
    _o.DisplayEndDate = TableEncryptionService.Convert(this.DisplayEndDate, key);
    _o.DislpayFavorLevel = TableEncryptionService.Convert(this.DislpayFavorLevel, key);
    _o.CheckPassType = TableEncryptionService.Convert(this.CheckPassType, key);
    _o.EmblemParameter = TableEncryptionService.Convert(this.EmblemParameter, key);
    _o.CheckPassCount = TableEncryptionService.Convert(this.CheckPassCount, key);
  }
  public static Offset<SCHALE.Common.FlatData.EmblemExcel> Pack(FlatBufferBuilder builder, EmblemExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.EmblemExcel>);
    var _IconPath = _o.IconPath == null ? default(StringOffset) : builder.CreateString(_o.IconPath);
    var _EmblemIconPath = _o.EmblemIconPath == null ? default(StringOffset) : builder.CreateString(_o.EmblemIconPath);
    var _EmblemIconBGPath = _o.EmblemIconBGPath == null ? default(StringOffset) : builder.CreateString(_o.EmblemIconBGPath);
    var _EmblemBGPathJp = _o.EmblemBGPathJp == null ? default(StringOffset) : builder.CreateString(_o.EmblemBGPathJp);
    var _EmblemBGPathKr = _o.EmblemBGPathKr == null ? default(StringOffset) : builder.CreateString(_o.EmblemBGPathKr);
    var _DisplayStartDate = _o.DisplayStartDate == null ? default(StringOffset) : builder.CreateString(_o.DisplayStartDate);
    var _DisplayEndDate = _o.DisplayEndDate == null ? default(StringOffset) : builder.CreateString(_o.DisplayEndDate);
    return CreateEmblemExcel(
      builder,
      _o.Id,
      _o.Category,
      _o.Rarity,
      _o.DisplayOrder,
      _o.LocalizeEtcId,
      _o.LocalizeCodeId,
      _o.UseAtLocalizeId,
      _o.EmblemTextVisible,
      _IconPath,
      _EmblemIconPath,
      _o.EmblemIconNumControl,
      _EmblemIconBGPath,
      _EmblemBGPathJp,
      _EmblemBGPathKr,
      _o.DisplayType,
      _DisplayStartDate,
      _DisplayEndDate,
      _o.DislpayFavorLevel,
      _o.CheckPassType,
      _o.EmblemParameter,
      _o.CheckPassCount);
  }
}

public class EmblemExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.EmblemCategory Category { get; set; }
  public SCHALE.Common.FlatData.Rarity Rarity { get; set; }
  public long DisplayOrder { get; set; }
  public uint LocalizeEtcId { get; set; }
  public uint LocalizeCodeId { get; set; }
  public long UseAtLocalizeId { get; set; }
  public bool EmblemTextVisible { get; set; }
  public string IconPath { get; set; }
  public string EmblemIconPath { get; set; }
  public int EmblemIconNumControl { get; set; }
  public string EmblemIconBGPath { get; set; }
  public string EmblemBGPathJp { get; set; }
  public string EmblemBGPathKr { get; set; }
  public SCHALE.Common.FlatData.EmblemDisplayType DisplayType { get; set; }
  public string DisplayStartDate { get; set; }
  public string DisplayEndDate { get; set; }
  public int DislpayFavorLevel { get; set; }
  public SCHALE.Common.FlatData.EmblemCheckPassType CheckPassType { get; set; }
  public long EmblemParameter { get; set; }
  public long CheckPassCount { get; set; }

  public EmblemExcelT() {
    this.Id = 0;
    this.Category = SCHALE.Common.FlatData.EmblemCategory.None;
    this.Rarity = SCHALE.Common.FlatData.Rarity.N;
    this.DisplayOrder = 0;
    this.LocalizeEtcId = 0;
    this.LocalizeCodeId = 0;
    this.UseAtLocalizeId = 0;
    this.EmblemTextVisible = false;
    this.IconPath = null;
    this.EmblemIconPath = null;
    this.EmblemIconNumControl = 0;
    this.EmblemIconBGPath = null;
    this.EmblemBGPathJp = null;
    this.EmblemBGPathKr = null;
    this.DisplayType = SCHALE.Common.FlatData.EmblemDisplayType.Always;
    this.DisplayStartDate = null;
    this.DisplayEndDate = null;
    this.DislpayFavorLevel = 0;
    this.CheckPassType = SCHALE.Common.FlatData.EmblemCheckPassType.None;
    this.EmblemParameter = 0;
    this.CheckPassCount = 0;
  }
}


static public class EmblemExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Category*/, 4 /*SCHALE.Common.FlatData.EmblemCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Rarity*/, 4 /*SCHALE.Common.FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*LocalizeCodeId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*UseAtLocalizeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*EmblemTextVisible*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 20 /*IconPath*/, false)
      && verifier.VerifyString(tablePos, 22 /*EmblemIconPath*/, false)
      && verifier.VerifyField(tablePos, 24 /*EmblemIconNumControl*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 26 /*EmblemIconBGPath*/, false)
      && verifier.VerifyString(tablePos, 28 /*EmblemBGPathJp*/, false)
      && verifier.VerifyString(tablePos, 30 /*EmblemBGPathKr*/, false)
      && verifier.VerifyField(tablePos, 32 /*DisplayType*/, 4 /*SCHALE.Common.FlatData.EmblemDisplayType*/, 4, false)
      && verifier.VerifyString(tablePos, 34 /*DisplayStartDate*/, false)
      && verifier.VerifyString(tablePos, 36 /*DisplayEndDate*/, false)
      && verifier.VerifyField(tablePos, 38 /*DislpayFavorLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*CheckPassType*/, 4 /*SCHALE.Common.FlatData.EmblemCheckPassType*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*EmblemParameter*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*CheckPassCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}