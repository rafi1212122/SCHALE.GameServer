// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct LimitedStageSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LimitedStageSeasonExcel GetRootAsLimitedStageSeasonExcel(ByteBuffer _bb) { return GetRootAsLimitedStageSeasonExcel(_bb, new LimitedStageSeasonExcel()); }
  public static LimitedStageSeasonExcel GetRootAsLimitedStageSeasonExcel(ByteBuffer _bb, LimitedStageSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LimitedStageSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StartDate { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(6); }
  public string EndDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(8); }
  public long TypeACount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TypeBCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TypeCCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.LimitedStageSeasonExcel> CreateLimitedStageSeasonExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long TypeACount = 0,
      long TypeBCount = 0,
      long TypeCCount = 0) {
    builder.StartTable(6);
    LimitedStageSeasonExcel.AddTypeCCount(builder, TypeCCount);
    LimitedStageSeasonExcel.AddTypeBCount(builder, TypeBCount);
    LimitedStageSeasonExcel.AddTypeACount(builder, TypeACount);
    LimitedStageSeasonExcel.AddId(builder, Id);
    LimitedStageSeasonExcel.AddEndDate(builder, EndDateOffset);
    LimitedStageSeasonExcel.AddStartDate(builder, StartDateOffset);
    return LimitedStageSeasonExcel.EndLimitedStageSeasonExcel(builder);
  }

  public static void StartLimitedStageSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset startDateOffset) { builder.AddOffset(1, startDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset endDateOffset) { builder.AddOffset(2, endDateOffset.Value, 0); }
  public static void AddTypeACount(FlatBufferBuilder builder, long typeACount) { builder.AddLong(3, typeACount, 0); }
  public static void AddTypeBCount(FlatBufferBuilder builder, long typeBCount) { builder.AddLong(4, typeBCount, 0); }
  public static void AddTypeCCount(FlatBufferBuilder builder, long typeCCount) { builder.AddLong(5, typeCCount, 0); }
  public static Offset<SCHALE.Common.FlatData.LimitedStageSeasonExcel> EndLimitedStageSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.LimitedStageSeasonExcel>(o);
  }
  public LimitedStageSeasonExcelT UnPack() {
    var _o = new LimitedStageSeasonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LimitedStageSeasonExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("LimitedStageSeason");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.StartDate = TableEncryptionService.Convert(this.StartDate, key);
    _o.EndDate = TableEncryptionService.Convert(this.EndDate, key);
    _o.TypeACount = TableEncryptionService.Convert(this.TypeACount, key);
    _o.TypeBCount = TableEncryptionService.Convert(this.TypeBCount, key);
    _o.TypeCCount = TableEncryptionService.Convert(this.TypeCCount, key);
  }
  public static Offset<SCHALE.Common.FlatData.LimitedStageSeasonExcel> Pack(FlatBufferBuilder builder, LimitedStageSeasonExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.LimitedStageSeasonExcel>);
    var _StartDate = _o.StartDate == null ? default(StringOffset) : builder.CreateString(_o.StartDate);
    var _EndDate = _o.EndDate == null ? default(StringOffset) : builder.CreateString(_o.EndDate);
    return CreateLimitedStageSeasonExcel(
      builder,
      _o.Id,
      _StartDate,
      _EndDate,
      _o.TypeACount,
      _o.TypeBCount,
      _o.TypeCCount);
  }
}

public class LimitedStageSeasonExcelT
{
  public long Id { get; set; }
  public string StartDate { get; set; }
  public string EndDate { get; set; }
  public long TypeACount { get; set; }
  public long TypeBCount { get; set; }
  public long TypeCCount { get; set; }

  public LimitedStageSeasonExcelT() {
    this.Id = 0;
    this.StartDate = null;
    this.EndDate = null;
    this.TypeACount = 0;
    this.TypeBCount = 0;
    this.TypeCCount = 0;
  }
}


static public class LimitedStageSeasonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*StartDate*/, false)
      && verifier.VerifyString(tablePos, 8 /*EndDate*/, false)
      && verifier.VerifyField(tablePos, 10 /*TypeACount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*TypeBCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*TypeCCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}