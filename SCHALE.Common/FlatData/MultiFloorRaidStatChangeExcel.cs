// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct MultiFloorRaidStatChangeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MultiFloorRaidStatChangeExcel GetRootAsMultiFloorRaidStatChangeExcel(ByteBuffer _bb) { return GetRootAsMultiFloorRaidStatChangeExcel(_bb, new MultiFloorRaidStatChangeExcel()); }
  public static MultiFloorRaidStatChangeExcel GetRootAsMultiFloorRaidStatChangeExcel(ByteBuffer _bb, MultiFloorRaidStatChangeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MultiFloorRaidStatChangeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StatChangeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StatType StatType_(int j) { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.StatType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.StatType)0; }
  public int StatType_Length { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.StatType> GetStatType_Bytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.StatType>(6, 4); }
#else
  public ArraySegment<byte>? GetStatType_Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public SCHALE.Common.FlatData.StatType[] GetStatType_Array() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.StatType[] a = new SCHALE.Common.FlatData.StatType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.StatType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StatAdd(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatAddLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatAddBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetStatAddBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetStatAddArray() { return __p.__vector_as_array<long>(8); }
  public long StatMultiply(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatMultiplyLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatMultiplyBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetStatMultiplyBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetStatMultiplyArray() { return __p.__vector_as_array<long>(10); }
  public long ApplyCharacterId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ApplyCharacterIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetApplyCharacterIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetApplyCharacterIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetApplyCharacterIdArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<SCHALE.Common.FlatData.MultiFloorRaidStatChangeExcel> CreateMultiFloorRaidStatChangeExcel(FlatBufferBuilder builder,
      long StatChangeId = 0,
      VectorOffset StatType_Offset = default(VectorOffset),
      VectorOffset StatAddOffset = default(VectorOffset),
      VectorOffset StatMultiplyOffset = default(VectorOffset),
      VectorOffset ApplyCharacterIdOffset = default(VectorOffset)) {
    builder.StartTable(5);
    MultiFloorRaidStatChangeExcel.AddStatChangeId(builder, StatChangeId);
    MultiFloorRaidStatChangeExcel.AddApplyCharacterId(builder, ApplyCharacterIdOffset);
    MultiFloorRaidStatChangeExcel.AddStatMultiply(builder, StatMultiplyOffset);
    MultiFloorRaidStatChangeExcel.AddStatAdd(builder, StatAddOffset);
    MultiFloorRaidStatChangeExcel.AddStatType_(builder, StatType_Offset);
    return MultiFloorRaidStatChangeExcel.EndMultiFloorRaidStatChangeExcel(builder);
  }

  public static void StartMultiFloorRaidStatChangeExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddStatChangeId(FlatBufferBuilder builder, long statChangeId) { builder.AddLong(0, statChangeId, 0); }
  public static void AddStatType_(FlatBufferBuilder builder, VectorOffset statType_Offset) { builder.AddOffset(1, statType_Offset.Value, 0); }
  public static VectorOffset CreateStatType_Vector(FlatBufferBuilder builder, SCHALE.Common.FlatData.StatType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatType_VectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.StatType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatType_VectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.StatType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatType_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.StatType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatType_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatAdd(FlatBufferBuilder builder, VectorOffset statAddOffset) { builder.AddOffset(2, statAddOffset.Value, 0); }
  public static VectorOffset CreateStatAddVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatAddVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatAddVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatAddVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatAddVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStatMultiply(FlatBufferBuilder builder, VectorOffset statMultiplyOffset) { builder.AddOffset(3, statMultiplyOffset.Value, 0); }
  public static VectorOffset CreateStatMultiplyVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatMultiplyVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatMultiplyVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatMultiplyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatMultiplyVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddApplyCharacterId(FlatBufferBuilder builder, VectorOffset applyCharacterIdOffset) { builder.AddOffset(4, applyCharacterIdOffset.Value, 0); }
  public static VectorOffset CreateApplyCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateApplyCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateApplyCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateApplyCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartApplyCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.MultiFloorRaidStatChangeExcel> EndMultiFloorRaidStatChangeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MultiFloorRaidStatChangeExcel>(o);
  }
  public MultiFloorRaidStatChangeExcelT UnPack() {
    var _o = new MultiFloorRaidStatChangeExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MultiFloorRaidStatChangeExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("MultiFloorRaidStatChange");
    _o.StatChangeId = TableEncryptionService.Convert(this.StatChangeId, key);
    _o.StatType_ = new List<SCHALE.Common.FlatData.StatType>();
    for (var _j = 0; _j < this.StatType_Length; ++_j) {_o.StatType_.Add(TableEncryptionService.Convert(this.StatType_(_j), key));}
    _o.StatAdd = new List<long>();
    for (var _j = 0; _j < this.StatAddLength; ++_j) {_o.StatAdd.Add(TableEncryptionService.Convert(this.StatAdd(_j), key));}
    _o.StatMultiply = new List<long>();
    for (var _j = 0; _j < this.StatMultiplyLength; ++_j) {_o.StatMultiply.Add(TableEncryptionService.Convert(this.StatMultiply(_j), key));}
    _o.ApplyCharacterId = new List<long>();
    for (var _j = 0; _j < this.ApplyCharacterIdLength; ++_j) {_o.ApplyCharacterId.Add(TableEncryptionService.Convert(this.ApplyCharacterId(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.MultiFloorRaidStatChangeExcel> Pack(FlatBufferBuilder builder, MultiFloorRaidStatChangeExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.MultiFloorRaidStatChangeExcel>);
    var _StatType_ = default(VectorOffset);
    if (_o.StatType_ != null) {
      var __StatType_ = _o.StatType_.ToArray();
      _StatType_ = CreateStatType_Vector(builder, __StatType_);
    }
    var _StatAdd = default(VectorOffset);
    if (_o.StatAdd != null) {
      var __StatAdd = _o.StatAdd.ToArray();
      _StatAdd = CreateStatAddVector(builder, __StatAdd);
    }
    var _StatMultiply = default(VectorOffset);
    if (_o.StatMultiply != null) {
      var __StatMultiply = _o.StatMultiply.ToArray();
      _StatMultiply = CreateStatMultiplyVector(builder, __StatMultiply);
    }
    var _ApplyCharacterId = default(VectorOffset);
    if (_o.ApplyCharacterId != null) {
      var __ApplyCharacterId = _o.ApplyCharacterId.ToArray();
      _ApplyCharacterId = CreateApplyCharacterIdVector(builder, __ApplyCharacterId);
    }
    return CreateMultiFloorRaidStatChangeExcel(
      builder,
      _o.StatChangeId,
      _StatType_,
      _StatAdd,
      _StatMultiply,
      _ApplyCharacterId);
  }
}

public class MultiFloorRaidStatChangeExcelT
{
  public long StatChangeId { get; set; }
  public List<SCHALE.Common.FlatData.StatType> StatType_ { get; set; }
  public List<long> StatAdd { get; set; }
  public List<long> StatMultiply { get; set; }
  public List<long> ApplyCharacterId { get; set; }

  public MultiFloorRaidStatChangeExcelT() {
    this.StatChangeId = 0;
    this.StatType_ = null;
    this.StatAdd = null;
    this.StatMultiply = null;
    this.ApplyCharacterId = null;
  }
}


static public class MultiFloorRaidStatChangeExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StatChangeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*StatType_*/, 4 /*SCHALE.Common.FlatData.StatType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*StatAdd*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*StatMultiply*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ApplyCharacterId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}