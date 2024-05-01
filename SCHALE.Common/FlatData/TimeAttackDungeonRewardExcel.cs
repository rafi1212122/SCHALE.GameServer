// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct TimeAttackDungeonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TimeAttackDungeonRewardExcel GetRootAsTimeAttackDungeonRewardExcel(ByteBuffer _bb) { return GetRootAsTimeAttackDungeonRewardExcel(_bb, new TimeAttackDungeonRewardExcel()); }
  public static TimeAttackDungeonRewardExcel GetRootAsTimeAttackDungeonRewardExcel(ByteBuffer _bb, TimeAttackDungeonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TimeAttackDungeonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardMaxPoint { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.TimeAttackDungeonRewardType RewardType(int j) { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.TimeAttackDungeonRewardType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.TimeAttackDungeonRewardType)0; }
  public int RewardTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.TimeAttackDungeonRewardType> GetRewardTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.TimeAttackDungeonRewardType>(8, 4); }
#else
  public ArraySegment<byte>? GetRewardTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public SCHALE.Common.FlatData.TimeAttackDungeonRewardType[] GetRewardTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.TimeAttackDungeonRewardType[] a = new SCHALE.Common.FlatData.TimeAttackDungeonRewardType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.TimeAttackDungeonRewardType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardMinPoint(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardMinPointLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardMinPointBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetRewardMinPointBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetRewardMinPointArray() { return __p.__vector_as_array<long>(10); }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long RewardParcelDefaultAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelDefaultAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelDefaultAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelDefaultAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelDefaultAmountArray() { return __p.__vector_as_array<long>(16); }
  public long RewardParcelMaxAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelMaxAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelMaxAmountBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelMaxAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetRewardParcelMaxAmountArray() { return __p.__vector_as_array<long>(18); }

  public static Offset<SCHALE.Common.FlatData.TimeAttackDungeonRewardExcel> CreateTimeAttackDungeonRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      long RewardMaxPoint = 0,
      VectorOffset RewardTypeOffset = default(VectorOffset),
      VectorOffset RewardMinPointOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelDefaultAmountOffset = default(VectorOffset),
      VectorOffset RewardParcelMaxAmountOffset = default(VectorOffset)) {
    builder.StartTable(8);
    TimeAttackDungeonRewardExcel.AddRewardMaxPoint(builder, RewardMaxPoint);
    TimeAttackDungeonRewardExcel.AddId(builder, Id);
    TimeAttackDungeonRewardExcel.AddRewardParcelMaxAmount(builder, RewardParcelMaxAmountOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelDefaultAmount(builder, RewardParcelDefaultAmountOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    TimeAttackDungeonRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    TimeAttackDungeonRewardExcel.AddRewardMinPoint(builder, RewardMinPointOffset);
    TimeAttackDungeonRewardExcel.AddRewardType(builder, RewardTypeOffset);
    return TimeAttackDungeonRewardExcel.EndTimeAttackDungeonRewardExcel(builder);
  }

  public static void StartTimeAttackDungeonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddRewardMaxPoint(FlatBufferBuilder builder, long rewardMaxPoint) { builder.AddLong(1, rewardMaxPoint, 0); }
  public static void AddRewardType(FlatBufferBuilder builder, VectorOffset rewardTypeOffset) { builder.AddOffset(2, rewardTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.TimeAttackDungeonRewardType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.TimeAttackDungeonRewardType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.TimeAttackDungeonRewardType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.TimeAttackDungeonRewardType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardMinPoint(FlatBufferBuilder builder, VectorOffset rewardMinPointOffset) { builder.AddOffset(3, rewardMinPointOffset.Value, 0); }
  public static VectorOffset CreateRewardMinPointVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardMinPointVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardMinPointVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(4, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(5, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelDefaultAmount(FlatBufferBuilder builder, VectorOffset rewardParcelDefaultAmountOffset) { builder.AddOffset(6, rewardParcelDefaultAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelDefaultAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelDefaultAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelDefaultAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelMaxAmount(FlatBufferBuilder builder, VectorOffset rewardParcelMaxAmountOffset) { builder.AddOffset(7, rewardParcelMaxAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelMaxAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelMaxAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelMaxAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.TimeAttackDungeonRewardExcel> EndTimeAttackDungeonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.TimeAttackDungeonRewardExcel>(o);
  }
  public TimeAttackDungeonRewardExcelT UnPack() {
    var _o = new TimeAttackDungeonRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TimeAttackDungeonRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("TimeAttackDungeonReward");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.RewardMaxPoint = TableEncryptionService.Convert(this.RewardMaxPoint, key);
    _o.RewardType = new List<SCHALE.Common.FlatData.TimeAttackDungeonRewardType>();
    for (var _j = 0; _j < this.RewardTypeLength; ++_j) {_o.RewardType.Add(TableEncryptionService.Convert(this.RewardType(_j), key));}
    _o.RewardMinPoint = new List<long>();
    for (var _j = 0; _j < this.RewardMinPointLength; ++_j) {_o.RewardMinPoint.Add(TableEncryptionService.Convert(this.RewardMinPoint(_j), key));}
    _o.RewardParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardParcelDefaultAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelDefaultAmountLength; ++_j) {_o.RewardParcelDefaultAmount.Add(TableEncryptionService.Convert(this.RewardParcelDefaultAmount(_j), key));}
    _o.RewardParcelMaxAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelMaxAmountLength; ++_j) {_o.RewardParcelMaxAmount.Add(TableEncryptionService.Convert(this.RewardParcelMaxAmount(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.TimeAttackDungeonRewardExcel> Pack(FlatBufferBuilder builder, TimeAttackDungeonRewardExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.TimeAttackDungeonRewardExcel>);
    var _RewardType = default(VectorOffset);
    if (_o.RewardType != null) {
      var __RewardType = _o.RewardType.ToArray();
      _RewardType = CreateRewardTypeVector(builder, __RewardType);
    }
    var _RewardMinPoint = default(VectorOffset);
    if (_o.RewardMinPoint != null) {
      var __RewardMinPoint = _o.RewardMinPoint.ToArray();
      _RewardMinPoint = CreateRewardMinPointVector(builder, __RewardMinPoint);
    }
    var _RewardParcelType = default(VectorOffset);
    if (_o.RewardParcelType != null) {
      var __RewardParcelType = _o.RewardParcelType.ToArray();
      _RewardParcelType = CreateRewardParcelTypeVector(builder, __RewardParcelType);
    }
    var _RewardParcelId = default(VectorOffset);
    if (_o.RewardParcelId != null) {
      var __RewardParcelId = _o.RewardParcelId.ToArray();
      _RewardParcelId = CreateRewardParcelIdVector(builder, __RewardParcelId);
    }
    var _RewardParcelDefaultAmount = default(VectorOffset);
    if (_o.RewardParcelDefaultAmount != null) {
      var __RewardParcelDefaultAmount = _o.RewardParcelDefaultAmount.ToArray();
      _RewardParcelDefaultAmount = CreateRewardParcelDefaultAmountVector(builder, __RewardParcelDefaultAmount);
    }
    var _RewardParcelMaxAmount = default(VectorOffset);
    if (_o.RewardParcelMaxAmount != null) {
      var __RewardParcelMaxAmount = _o.RewardParcelMaxAmount.ToArray();
      _RewardParcelMaxAmount = CreateRewardParcelMaxAmountVector(builder, __RewardParcelMaxAmount);
    }
    return CreateTimeAttackDungeonRewardExcel(
      builder,
      _o.Id,
      _o.RewardMaxPoint,
      _RewardType,
      _RewardMinPoint,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelDefaultAmount,
      _RewardParcelMaxAmount);
  }
}

public class TimeAttackDungeonRewardExcelT
{
  public long Id { get; set; }
  public long RewardMaxPoint { get; set; }
  public List<SCHALE.Common.FlatData.TimeAttackDungeonRewardType> RewardType { get; set; }
  public List<long> RewardMinPoint { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardParcelDefaultAmount { get; set; }
  public List<long> RewardParcelMaxAmount { get; set; }

  public TimeAttackDungeonRewardExcelT() {
    this.Id = 0;
    this.RewardMaxPoint = 0;
    this.RewardType = null;
    this.RewardMinPoint = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelDefaultAmount = null;
    this.RewardParcelMaxAmount = null;
  }
}


static public class TimeAttackDungeonRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RewardMaxPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*RewardType*/, 4 /*SCHALE.Common.FlatData.TimeAttackDungeonRewardType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RewardMinPoint*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardParcelDefaultAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*RewardParcelMaxAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}