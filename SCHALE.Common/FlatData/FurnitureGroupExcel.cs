// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct FurnitureGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FurnitureGroupExcel GetRootAsFurnitureGroupExcel(ByteBuffer _bb) { return GetRootAsFurnitureGroupExcel(_bb, new FurnitureGroupExcel()); }
  public static FurnitureGroupExcel GetRootAsFurnitureGroupExcel(ByteBuffer _bb, FurnitureGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FurnitureGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint GroupNameLocalize { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public int RequiredFurnitureCount(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RequiredFurnitureCountLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRequiredFurnitureCountBytes() { return __p.__vector_as_span<int>(10, 4); }
#else
  public ArraySegment<byte>? GetRequiredFurnitureCountBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public int[] GetRequiredFurnitureCountArray() { return __p.__vector_as_array<int>(10); }
  public long ComfortBonus(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ComfortBonusLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetComfortBonusBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetComfortBonusBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetComfortBonusArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<SCHALE.Common.FlatData.FurnitureGroupExcel> CreateFurnitureGroupExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint GroupNameLocalize = 0,
      uint LocalizeEtcId = 0,
      VectorOffset RequiredFurnitureCountOffset = default(VectorOffset),
      VectorOffset ComfortBonusOffset = default(VectorOffset)) {
    builder.StartTable(5);
    FurnitureGroupExcel.AddId(builder, Id);
    FurnitureGroupExcel.AddComfortBonus(builder, ComfortBonusOffset);
    FurnitureGroupExcel.AddRequiredFurnitureCount(builder, RequiredFurnitureCountOffset);
    FurnitureGroupExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    FurnitureGroupExcel.AddGroupNameLocalize(builder, GroupNameLocalize);
    return FurnitureGroupExcel.EndFurnitureGroupExcel(builder);
  }

  public static void StartFurnitureGroupExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddGroupNameLocalize(FlatBufferBuilder builder, uint groupNameLocalize) { builder.AddUint(1, groupNameLocalize, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddRequiredFurnitureCount(FlatBufferBuilder builder, VectorOffset requiredFurnitureCountOffset) { builder.AddOffset(3, requiredFurnitureCountOffset.Value, 0); }
  public static VectorOffset CreateRequiredFurnitureCountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRequiredFurnitureCountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequiredFurnitureCountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRequiredFurnitureCountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRequiredFurnitureCountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddComfortBonus(FlatBufferBuilder builder, VectorOffset comfortBonusOffset) { builder.AddOffset(4, comfortBonusOffset.Value, 0); }
  public static VectorOffset CreateComfortBonusVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateComfortBonusVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateComfortBonusVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateComfortBonusVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartComfortBonusVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.FurnitureGroupExcel> EndFurnitureGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FurnitureGroupExcel>(o);
  }
  public FurnitureGroupExcelT UnPack() {
    var _o = new FurnitureGroupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FurnitureGroupExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FurnitureGroup");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.GroupNameLocalize = TableEncryptionService.Convert(this.GroupNameLocalize, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.RequiredFurnitureCount = new List<int>();
    for (var _j = 0; _j < this.RequiredFurnitureCountLength; ++_j) {_o.RequiredFurnitureCount.Add(TableEncryptionService.Convert(this.RequiredFurnitureCount(_j), key));}
    _o.ComfortBonus = new List<long>();
    for (var _j = 0; _j < this.ComfortBonusLength; ++_j) {_o.ComfortBonus.Add(TableEncryptionService.Convert(this.ComfortBonus(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.FurnitureGroupExcel> Pack(FlatBufferBuilder builder, FurnitureGroupExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.FurnitureGroupExcel>);
    var _RequiredFurnitureCount = default(VectorOffset);
    if (_o.RequiredFurnitureCount != null) {
      var __RequiredFurnitureCount = _o.RequiredFurnitureCount.ToArray();
      _RequiredFurnitureCount = CreateRequiredFurnitureCountVector(builder, __RequiredFurnitureCount);
    }
    var _ComfortBonus = default(VectorOffset);
    if (_o.ComfortBonus != null) {
      var __ComfortBonus = _o.ComfortBonus.ToArray();
      _ComfortBonus = CreateComfortBonusVector(builder, __ComfortBonus);
    }
    return CreateFurnitureGroupExcel(
      builder,
      _o.Id,
      _o.GroupNameLocalize,
      _o.LocalizeEtcId,
      _RequiredFurnitureCount,
      _ComfortBonus);
  }
}

public class FurnitureGroupExcelT
{
  public long Id { get; set; }
  public uint GroupNameLocalize { get; set; }
  public uint LocalizeEtcId { get; set; }
  public List<int> RequiredFurnitureCount { get; set; }
  public List<long> ComfortBonus { get; set; }

  public FurnitureGroupExcelT() {
    this.Id = 0;
    this.GroupNameLocalize = 0;
    this.LocalizeEtcId = 0;
    this.RequiredFurnitureCount = null;
    this.ComfortBonus = null;
  }
}


static public class FurnitureGroupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GroupNameLocalize*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RequiredFurnitureCount*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ComfortBonus*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}