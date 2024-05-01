// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct SchoolDungeonStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static SchoolDungeonStageExcel GetRootAsSchoolDungeonStageExcel(ByteBuffer _bb) { return GetRootAsSchoolDungeonStageExcel(_bb, new SchoolDungeonStageExcel()); }
  public static SchoolDungeonStageExcel GetRootAsSchoolDungeonStageExcel(ByteBuffer _bb, SchoolDungeonStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SchoolDungeonStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.SchoolDungeonType DungeonType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.SchoolDungeonType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.SchoolDungeonType.SchoolA; } }
  public int Difficulty { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long BattleDuration { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PrevStageId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType StageEnterCostType(int j) { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int StageEnterCostTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetStageEnterCostTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetStageEnterCostTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetStageEnterCostTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StageEnterCostId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StageEnterCostIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStageEnterCostIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetStageEnterCostIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetStageEnterCostIdArray() { return __p.__vector_as_array<long>(16); }
  public long StageEnterCostAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StageEnterCostAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStageEnterCostAmountBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetStageEnterCostAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetStageEnterCostAmountArray() { return __p.__vector_as_array<long>(18); }
  public long StageEnterCostMinimumAmount(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StageEnterCostMinimumAmountLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStageEnterCostMinimumAmountBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetStageEnterCostMinimumAmountBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetStageEnterCostMinimumAmountArray() { return __p.__vector_as_array<long>(20); }
  public int GroundId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public SCHALE.Common.FlatData.StarGoalType StarGoal(int j) { int o = __p.__offset(24); return o != 0 ? (SCHALE.Common.FlatData.StarGoalType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.StarGoalType)0; }
  public int StarGoalLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.StarGoalType> GetStarGoalBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.StarGoalType>(24, 4); }
#else
  public ArraySegment<byte>? GetStarGoalBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public SCHALE.Common.FlatData.StarGoalType[] GetStarGoalArray() { int o = __p.__offset(24); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.StarGoalType[] a = new SCHALE.Common.FlatData.StarGoalType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.StarGoalType)__p.bb.GetInt(p + i * 4); } return a; }
  public int StarGoalAmount(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int StarGoalAmountLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetStarGoalAmountBytes() { return __p.__vector_as_span<int>(26, 4); }
#else
  public ArraySegment<byte>? GetStarGoalAmountBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public int[] GetStarGoalAmountArray() { return __p.__vector_as_array<int>(26); }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get { int o = __p.__offset(28); return o != 0 ? (SCHALE.Common.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StageTopography.Street; } }
  public long RecommandLevel { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageRewardId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PlayTimeLimitInSeconds { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(36); return o != 0 ? (SCHALE.Common.FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EchelonExtensionType.Base; } }

  public static Offset<SCHALE.Common.FlatData.SchoolDungeonStageExcel> CreateSchoolDungeonStageExcel(FlatBufferBuilder builder,
      long StageId = 0,
      SCHALE.Common.FlatData.SchoolDungeonType DungeonType = SCHALE.Common.FlatData.SchoolDungeonType.SchoolA,
      int Difficulty = 0,
      long BattleDuration = 0,
      long PrevStageId = 0,
      VectorOffset StageEnterCostTypeOffset = default(VectorOffset),
      VectorOffset StageEnterCostIdOffset = default(VectorOffset),
      VectorOffset StageEnterCostAmountOffset = default(VectorOffset),
      VectorOffset StageEnterCostMinimumAmountOffset = default(VectorOffset),
      int GroundId = 0,
      VectorOffset StarGoalOffset = default(VectorOffset),
      VectorOffset StarGoalAmountOffset = default(VectorOffset),
      SCHALE.Common.FlatData.StageTopography StageTopography = SCHALE.Common.FlatData.StageTopography.Street,
      long RecommandLevel = 0,
      long StageRewardId = 0,
      long PlayTimeLimitInSeconds = 0,
      SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base) {
    builder.StartTable(17);
    SchoolDungeonStageExcel.AddPlayTimeLimitInSeconds(builder, PlayTimeLimitInSeconds);
    SchoolDungeonStageExcel.AddStageRewardId(builder, StageRewardId);
    SchoolDungeonStageExcel.AddRecommandLevel(builder, RecommandLevel);
    SchoolDungeonStageExcel.AddPrevStageId(builder, PrevStageId);
    SchoolDungeonStageExcel.AddBattleDuration(builder, BattleDuration);
    SchoolDungeonStageExcel.AddStageId(builder, StageId);
    SchoolDungeonStageExcel.AddEchelonExtensionType(builder, EchelonExtensionType);
    SchoolDungeonStageExcel.AddStageTopography(builder, StageTopography);
    SchoolDungeonStageExcel.AddStarGoalAmount(builder, StarGoalAmountOffset);
    SchoolDungeonStageExcel.AddStarGoal(builder, StarGoalOffset);
    SchoolDungeonStageExcel.AddGroundId(builder, GroundId);
    SchoolDungeonStageExcel.AddStageEnterCostMinimumAmount(builder, StageEnterCostMinimumAmountOffset);
    SchoolDungeonStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmountOffset);
    SchoolDungeonStageExcel.AddStageEnterCostId(builder, StageEnterCostIdOffset);
    SchoolDungeonStageExcel.AddStageEnterCostType(builder, StageEnterCostTypeOffset);
    SchoolDungeonStageExcel.AddDifficulty(builder, Difficulty);
    SchoolDungeonStageExcel.AddDungeonType(builder, DungeonType);
    return SchoolDungeonStageExcel.EndSchoolDungeonStageExcel(builder);
  }

  public static void StartSchoolDungeonStageExcel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddStageId(FlatBufferBuilder builder, long stageId) { builder.AddLong(0, stageId, 0); }
  public static void AddDungeonType(FlatBufferBuilder builder, SCHALE.Common.FlatData.SchoolDungeonType dungeonType) { builder.AddInt(1, (int)dungeonType, 0); }
  public static void AddDifficulty(FlatBufferBuilder builder, int difficulty) { builder.AddInt(2, difficulty, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(3, battleDuration, 0); }
  public static void AddPrevStageId(FlatBufferBuilder builder, long prevStageId) { builder.AddLong(4, prevStageId, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, VectorOffset stageEnterCostTypeOffset) { builder.AddOffset(5, stageEnterCostTypeOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, VectorOffset stageEnterCostIdOffset) { builder.AddOffset(6, stageEnterCostIdOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, VectorOffset stageEnterCostAmountOffset) { builder.AddOffset(7, stageEnterCostAmountOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStageEnterCostMinimumAmount(FlatBufferBuilder builder, VectorOffset stageEnterCostMinimumAmountOffset) { builder.AddOffset(8, stageEnterCostMinimumAmountOffset.Value, 0); }
  public static VectorOffset CreateStageEnterCostMinimumAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostMinimumAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostMinimumAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStageEnterCostMinimumAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStageEnterCostMinimumAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddGroundId(FlatBufferBuilder builder, int groundId) { builder.AddInt(9, groundId, 0); }
  public static void AddStarGoal(FlatBufferBuilder builder, VectorOffset starGoalOffset) { builder.AddOffset(10, starGoalOffset.Value, 0); }
  public static VectorOffset CreateStarGoalVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.StarGoalType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.StarGoalType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.StarGoalType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarGoalAmount(FlatBufferBuilder builder, VectorOffset starGoalAmountOffset) { builder.AddOffset(11, starGoalAmountOffset.Value, 0); }
  public static VectorOffset CreateStarGoalAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStarGoalAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStarGoalAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStageTopography(FlatBufferBuilder builder, SCHALE.Common.FlatData.StageTopography stageTopography) { builder.AddInt(12, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, long recommandLevel) { builder.AddLong(13, recommandLevel, 0); }
  public static void AddStageRewardId(FlatBufferBuilder builder, long stageRewardId) { builder.AddLong(14, stageRewardId, 0); }
  public static void AddPlayTimeLimitInSeconds(FlatBufferBuilder builder, long playTimeLimitInSeconds) { builder.AddLong(15, playTimeLimitInSeconds, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EchelonExtensionType echelonExtensionType) { builder.AddInt(16, (int)echelonExtensionType, 0); }
  public static Offset<SCHALE.Common.FlatData.SchoolDungeonStageExcel> EndSchoolDungeonStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.SchoolDungeonStageExcel>(o);
  }
  public SchoolDungeonStageExcelT UnPack() {
    var _o = new SchoolDungeonStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SchoolDungeonStageExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("SchoolDungeonStage");
    _o.StageId = TableEncryptionService.Convert(this.StageId, key);
    _o.DungeonType = TableEncryptionService.Convert(this.DungeonType, key);
    _o.Difficulty = TableEncryptionService.Convert(this.Difficulty, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.PrevStageId = TableEncryptionService.Convert(this.PrevStageId, key);
    _o.StageEnterCostType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.StageEnterCostTypeLength; ++_j) {_o.StageEnterCostType.Add(TableEncryptionService.Convert(this.StageEnterCostType(_j), key));}
    _o.StageEnterCostId = new List<long>();
    for (var _j = 0; _j < this.StageEnterCostIdLength; ++_j) {_o.StageEnterCostId.Add(TableEncryptionService.Convert(this.StageEnterCostId(_j), key));}
    _o.StageEnterCostAmount = new List<long>();
    for (var _j = 0; _j < this.StageEnterCostAmountLength; ++_j) {_o.StageEnterCostAmount.Add(TableEncryptionService.Convert(this.StageEnterCostAmount(_j), key));}
    _o.StageEnterCostMinimumAmount = new List<long>();
    for (var _j = 0; _j < this.StageEnterCostMinimumAmountLength; ++_j) {_o.StageEnterCostMinimumAmount.Add(TableEncryptionService.Convert(this.StageEnterCostMinimumAmount(_j), key));}
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.StarGoal = new List<SCHALE.Common.FlatData.StarGoalType>();
    for (var _j = 0; _j < this.StarGoalLength; ++_j) {_o.StarGoal.Add(TableEncryptionService.Convert(this.StarGoal(_j), key));}
    _o.StarGoalAmount = new List<int>();
    for (var _j = 0; _j < this.StarGoalAmountLength; ++_j) {_o.StarGoalAmount.Add(TableEncryptionService.Convert(this.StarGoalAmount(_j), key));}
    _o.StageTopography = TableEncryptionService.Convert(this.StageTopography, key);
    _o.RecommandLevel = TableEncryptionService.Convert(this.RecommandLevel, key);
    _o.StageRewardId = TableEncryptionService.Convert(this.StageRewardId, key);
    _o.PlayTimeLimitInSeconds = TableEncryptionService.Convert(this.PlayTimeLimitInSeconds, key);
    _o.EchelonExtensionType = TableEncryptionService.Convert(this.EchelonExtensionType, key);
  }
  public static Offset<SCHALE.Common.FlatData.SchoolDungeonStageExcel> Pack(FlatBufferBuilder builder, SchoolDungeonStageExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.SchoolDungeonStageExcel>);
    var _StageEnterCostType = default(VectorOffset);
    if (_o.StageEnterCostType != null) {
      var __StageEnterCostType = _o.StageEnterCostType.ToArray();
      _StageEnterCostType = CreateStageEnterCostTypeVector(builder, __StageEnterCostType);
    }
    var _StageEnterCostId = default(VectorOffset);
    if (_o.StageEnterCostId != null) {
      var __StageEnterCostId = _o.StageEnterCostId.ToArray();
      _StageEnterCostId = CreateStageEnterCostIdVector(builder, __StageEnterCostId);
    }
    var _StageEnterCostAmount = default(VectorOffset);
    if (_o.StageEnterCostAmount != null) {
      var __StageEnterCostAmount = _o.StageEnterCostAmount.ToArray();
      _StageEnterCostAmount = CreateStageEnterCostAmountVector(builder, __StageEnterCostAmount);
    }
    var _StageEnterCostMinimumAmount = default(VectorOffset);
    if (_o.StageEnterCostMinimumAmount != null) {
      var __StageEnterCostMinimumAmount = _o.StageEnterCostMinimumAmount.ToArray();
      _StageEnterCostMinimumAmount = CreateStageEnterCostMinimumAmountVector(builder, __StageEnterCostMinimumAmount);
    }
    var _StarGoal = default(VectorOffset);
    if (_o.StarGoal != null) {
      var __StarGoal = _o.StarGoal.ToArray();
      _StarGoal = CreateStarGoalVector(builder, __StarGoal);
    }
    var _StarGoalAmount = default(VectorOffset);
    if (_o.StarGoalAmount != null) {
      var __StarGoalAmount = _o.StarGoalAmount.ToArray();
      _StarGoalAmount = CreateStarGoalAmountVector(builder, __StarGoalAmount);
    }
    return CreateSchoolDungeonStageExcel(
      builder,
      _o.StageId,
      _o.DungeonType,
      _o.Difficulty,
      _o.BattleDuration,
      _o.PrevStageId,
      _StageEnterCostType,
      _StageEnterCostId,
      _StageEnterCostAmount,
      _StageEnterCostMinimumAmount,
      _o.GroundId,
      _StarGoal,
      _StarGoalAmount,
      _o.StageTopography,
      _o.RecommandLevel,
      _o.StageRewardId,
      _o.PlayTimeLimitInSeconds,
      _o.EchelonExtensionType);
  }
}

public class SchoolDungeonStageExcelT
{
  public long StageId { get; set; }
  public SCHALE.Common.FlatData.SchoolDungeonType DungeonType { get; set; }
  public int Difficulty { get; set; }
  public long BattleDuration { get; set; }
  public long PrevStageId { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> StageEnterCostType { get; set; }
  public List<long> StageEnterCostId { get; set; }
  public List<long> StageEnterCostAmount { get; set; }
  public List<long> StageEnterCostMinimumAmount { get; set; }
  public int GroundId { get; set; }
  public List<SCHALE.Common.FlatData.StarGoalType> StarGoal { get; set; }
  public List<int> StarGoalAmount { get; set; }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get; set; }
  public long RecommandLevel { get; set; }
  public long StageRewardId { get; set; }
  public long PlayTimeLimitInSeconds { get; set; }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get; set; }

  public SchoolDungeonStageExcelT() {
    this.StageId = 0;
    this.DungeonType = SCHALE.Common.FlatData.SchoolDungeonType.SchoolA;
    this.Difficulty = 0;
    this.BattleDuration = 0;
    this.PrevStageId = 0;
    this.StageEnterCostType = null;
    this.StageEnterCostId = null;
    this.StageEnterCostAmount = null;
    this.StageEnterCostMinimumAmount = null;
    this.GroundId = 0;
    this.StarGoal = null;
    this.StarGoalAmount = null;
    this.StageTopography = SCHALE.Common.FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.StageRewardId = 0;
    this.PlayTimeLimitInSeconds = 0;
    this.EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base;
  }
}


static public class SchoolDungeonStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*DungeonType*/, 4 /*SCHALE.Common.FlatData.SchoolDungeonType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Difficulty*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*PrevStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*StageEnterCostType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*StageEnterCostId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*StageEnterCostAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*StageEnterCostMinimumAmount*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 22 /*GroundId*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*StarGoal*/, 4 /*SCHALE.Common.FlatData.StarGoalType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*StarGoalAmount*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 28 /*StageTopography*/, 4 /*SCHALE.Common.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*RecommandLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*StageRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*PlayTimeLimitInSeconds*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*EchelonExtensionType*/, 4 /*SCHALE.Common.FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}