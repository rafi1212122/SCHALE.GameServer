// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct CharacterVictoryInteractionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterVictoryInteractionExcel GetRootAsCharacterVictoryInteractionExcel(ByteBuffer _bb) { return GetRootAsCharacterVictoryInteractionExcel(_bb, new CharacterVictoryInteractionExcel()); }
  public static CharacterVictoryInteractionExcel GetRootAsCharacterVictoryInteractionExcel(ByteBuffer _bb, CharacterVictoryInteractionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterVictoryInteractionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long InteractionId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CostumeId01 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex01 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath01 { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath01Bytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath01Bytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetVictoryStartAnimationPath01Array() { return __p.__vector_as_array<byte>(10); }
  public string VictoryEndAnimationPath01 { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath01Bytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath01Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetVictoryEndAnimationPath01Array() { return __p.__vector_as_array<byte>(12); }
  public long CostumeId02 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex02 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath02 { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath02Bytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath02Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetVictoryStartAnimationPath02Array() { return __p.__vector_as_array<byte>(18); }
  public string VictoryEndAnimationPath02 { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath02Bytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath02Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetVictoryEndAnimationPath02Array() { return __p.__vector_as_array<byte>(20); }
  public long CostumeId03 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex03 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath03 { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath03Bytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath03Bytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetVictoryStartAnimationPath03Array() { return __p.__vector_as_array<byte>(26); }
  public string VictoryEndAnimationPath03 { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath03Bytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath03Bytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetVictoryEndAnimationPath03Array() { return __p.__vector_as_array<byte>(28); }
  public long CostumeId04 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex04 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath04 { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath04Bytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath04Bytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetVictoryStartAnimationPath04Array() { return __p.__vector_as_array<byte>(34); }
  public string VictoryEndAnimationPath04 { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath04Bytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath04Bytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetVictoryEndAnimationPath04Array() { return __p.__vector_as_array<byte>(36); }
  public long CostumeId05 { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex05 { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath05 { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath05Bytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath05Bytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetVictoryStartAnimationPath05Array() { return __p.__vector_as_array<byte>(42); }
  public string VictoryEndAnimationPath05 { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath05Bytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath05Bytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetVictoryEndAnimationPath05Array() { return __p.__vector_as_array<byte>(44); }
  public long CostumeId06 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex06 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath06 { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath06Bytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath06Bytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetVictoryStartAnimationPath06Array() { return __p.__vector_as_array<byte>(50); }
  public string VictoryEndAnimationPath06 { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath06Bytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath06Bytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetVictoryEndAnimationPath06Array() { return __p.__vector_as_array<byte>(52); }

  public static Offset<SCHALE.Common.FlatData.CharacterVictoryInteractionExcel> CreateCharacterVictoryInteractionExcel(FlatBufferBuilder builder,
      long InteractionId = 0,
      long CostumeId01 = 0,
      int PositionIndex01 = 0,
      StringOffset VictoryStartAnimationPath01Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath01Offset = default(StringOffset),
      long CostumeId02 = 0,
      int PositionIndex02 = 0,
      StringOffset VictoryStartAnimationPath02Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath02Offset = default(StringOffset),
      long CostumeId03 = 0,
      int PositionIndex03 = 0,
      StringOffset VictoryStartAnimationPath03Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath03Offset = default(StringOffset),
      long CostumeId04 = 0,
      int PositionIndex04 = 0,
      StringOffset VictoryStartAnimationPath04Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath04Offset = default(StringOffset),
      long CostumeId05 = 0,
      int PositionIndex05 = 0,
      StringOffset VictoryStartAnimationPath05Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath05Offset = default(StringOffset),
      long CostumeId06 = 0,
      int PositionIndex06 = 0,
      StringOffset VictoryStartAnimationPath06Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath06Offset = default(StringOffset)) {
    builder.StartTable(25);
    CharacterVictoryInteractionExcel.AddCostumeId06(builder, CostumeId06);
    CharacterVictoryInteractionExcel.AddCostumeId05(builder, CostumeId05);
    CharacterVictoryInteractionExcel.AddCostumeId04(builder, CostumeId04);
    CharacterVictoryInteractionExcel.AddCostumeId03(builder, CostumeId03);
    CharacterVictoryInteractionExcel.AddCostumeId02(builder, CostumeId02);
    CharacterVictoryInteractionExcel.AddCostumeId01(builder, CostumeId01);
    CharacterVictoryInteractionExcel.AddInteractionId(builder, InteractionId);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath06(builder, VictoryEndAnimationPath06Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath06(builder, VictoryStartAnimationPath06Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex06(builder, PositionIndex06);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath05(builder, VictoryEndAnimationPath05Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath05(builder, VictoryStartAnimationPath05Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex05(builder, PositionIndex05);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath04(builder, VictoryEndAnimationPath04Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath04(builder, VictoryStartAnimationPath04Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex04(builder, PositionIndex04);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath03(builder, VictoryEndAnimationPath03Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath03(builder, VictoryStartAnimationPath03Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex03(builder, PositionIndex03);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath02(builder, VictoryEndAnimationPath02Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath02(builder, VictoryStartAnimationPath02Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex02(builder, PositionIndex02);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath01(builder, VictoryEndAnimationPath01Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath01(builder, VictoryStartAnimationPath01Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex01(builder, PositionIndex01);
    return CharacterVictoryInteractionExcel.EndCharacterVictoryInteractionExcel(builder);
  }

  public static void StartCharacterVictoryInteractionExcel(FlatBufferBuilder builder) { builder.StartTable(25); }
  public static void AddInteractionId(FlatBufferBuilder builder, long interactionId) { builder.AddLong(0, interactionId, 0); }
  public static void AddCostumeId01(FlatBufferBuilder builder, long costumeId01) { builder.AddLong(1, costumeId01, 0); }
  public static void AddPositionIndex01(FlatBufferBuilder builder, int positionIndex01) { builder.AddInt(2, positionIndex01, 0); }
  public static void AddVictoryStartAnimationPath01(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath01Offset) { builder.AddOffset(3, victoryStartAnimationPath01Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath01(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath01Offset) { builder.AddOffset(4, victoryEndAnimationPath01Offset.Value, 0); }
  public static void AddCostumeId02(FlatBufferBuilder builder, long costumeId02) { builder.AddLong(5, costumeId02, 0); }
  public static void AddPositionIndex02(FlatBufferBuilder builder, int positionIndex02) { builder.AddInt(6, positionIndex02, 0); }
  public static void AddVictoryStartAnimationPath02(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath02Offset) { builder.AddOffset(7, victoryStartAnimationPath02Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath02(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath02Offset) { builder.AddOffset(8, victoryEndAnimationPath02Offset.Value, 0); }
  public static void AddCostumeId03(FlatBufferBuilder builder, long costumeId03) { builder.AddLong(9, costumeId03, 0); }
  public static void AddPositionIndex03(FlatBufferBuilder builder, int positionIndex03) { builder.AddInt(10, positionIndex03, 0); }
  public static void AddVictoryStartAnimationPath03(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath03Offset) { builder.AddOffset(11, victoryStartAnimationPath03Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath03(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath03Offset) { builder.AddOffset(12, victoryEndAnimationPath03Offset.Value, 0); }
  public static void AddCostumeId04(FlatBufferBuilder builder, long costumeId04) { builder.AddLong(13, costumeId04, 0); }
  public static void AddPositionIndex04(FlatBufferBuilder builder, int positionIndex04) { builder.AddInt(14, positionIndex04, 0); }
  public static void AddVictoryStartAnimationPath04(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath04Offset) { builder.AddOffset(15, victoryStartAnimationPath04Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath04(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath04Offset) { builder.AddOffset(16, victoryEndAnimationPath04Offset.Value, 0); }
  public static void AddCostumeId05(FlatBufferBuilder builder, long costumeId05) { builder.AddLong(17, costumeId05, 0); }
  public static void AddPositionIndex05(FlatBufferBuilder builder, int positionIndex05) { builder.AddInt(18, positionIndex05, 0); }
  public static void AddVictoryStartAnimationPath05(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath05Offset) { builder.AddOffset(19, victoryStartAnimationPath05Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath05(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath05Offset) { builder.AddOffset(20, victoryEndAnimationPath05Offset.Value, 0); }
  public static void AddCostumeId06(FlatBufferBuilder builder, long costumeId06) { builder.AddLong(21, costumeId06, 0); }
  public static void AddPositionIndex06(FlatBufferBuilder builder, int positionIndex06) { builder.AddInt(22, positionIndex06, 0); }
  public static void AddVictoryStartAnimationPath06(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath06Offset) { builder.AddOffset(23, victoryStartAnimationPath06Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath06(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath06Offset) { builder.AddOffset(24, victoryEndAnimationPath06Offset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.CharacterVictoryInteractionExcel> EndCharacterVictoryInteractionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterVictoryInteractionExcel>(o);
  }
  public CharacterVictoryInteractionExcelT UnPack() {
    var _o = new CharacterVictoryInteractionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterVictoryInteractionExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterVictoryInteraction");
    _o.InteractionId = TableEncryptionService.Convert(this.InteractionId, key);
    _o.CostumeId01 = TableEncryptionService.Convert(this.CostumeId01, key);
    _o.PositionIndex01 = TableEncryptionService.Convert(this.PositionIndex01, key);
    _o.VictoryStartAnimationPath01 = TableEncryptionService.Convert(this.VictoryStartAnimationPath01, key);
    _o.VictoryEndAnimationPath01 = TableEncryptionService.Convert(this.VictoryEndAnimationPath01, key);
    _o.CostumeId02 = TableEncryptionService.Convert(this.CostumeId02, key);
    _o.PositionIndex02 = TableEncryptionService.Convert(this.PositionIndex02, key);
    _o.VictoryStartAnimationPath02 = TableEncryptionService.Convert(this.VictoryStartAnimationPath02, key);
    _o.VictoryEndAnimationPath02 = TableEncryptionService.Convert(this.VictoryEndAnimationPath02, key);
    _o.CostumeId03 = TableEncryptionService.Convert(this.CostumeId03, key);
    _o.PositionIndex03 = TableEncryptionService.Convert(this.PositionIndex03, key);
    _o.VictoryStartAnimationPath03 = TableEncryptionService.Convert(this.VictoryStartAnimationPath03, key);
    _o.VictoryEndAnimationPath03 = TableEncryptionService.Convert(this.VictoryEndAnimationPath03, key);
    _o.CostumeId04 = TableEncryptionService.Convert(this.CostumeId04, key);
    _o.PositionIndex04 = TableEncryptionService.Convert(this.PositionIndex04, key);
    _o.VictoryStartAnimationPath04 = TableEncryptionService.Convert(this.VictoryStartAnimationPath04, key);
    _o.VictoryEndAnimationPath04 = TableEncryptionService.Convert(this.VictoryEndAnimationPath04, key);
    _o.CostumeId05 = TableEncryptionService.Convert(this.CostumeId05, key);
    _o.PositionIndex05 = TableEncryptionService.Convert(this.PositionIndex05, key);
    _o.VictoryStartAnimationPath05 = TableEncryptionService.Convert(this.VictoryStartAnimationPath05, key);
    _o.VictoryEndAnimationPath05 = TableEncryptionService.Convert(this.VictoryEndAnimationPath05, key);
    _o.CostumeId06 = TableEncryptionService.Convert(this.CostumeId06, key);
    _o.PositionIndex06 = TableEncryptionService.Convert(this.PositionIndex06, key);
    _o.VictoryStartAnimationPath06 = TableEncryptionService.Convert(this.VictoryStartAnimationPath06, key);
    _o.VictoryEndAnimationPath06 = TableEncryptionService.Convert(this.VictoryEndAnimationPath06, key);
  }
  public static Offset<SCHALE.Common.FlatData.CharacterVictoryInteractionExcel> Pack(FlatBufferBuilder builder, CharacterVictoryInteractionExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.CharacterVictoryInteractionExcel>);
    var _VictoryStartAnimationPath01 = _o.VictoryStartAnimationPath01 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath01);
    var _VictoryEndAnimationPath01 = _o.VictoryEndAnimationPath01 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath01);
    var _VictoryStartAnimationPath02 = _o.VictoryStartAnimationPath02 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath02);
    var _VictoryEndAnimationPath02 = _o.VictoryEndAnimationPath02 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath02);
    var _VictoryStartAnimationPath03 = _o.VictoryStartAnimationPath03 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath03);
    var _VictoryEndAnimationPath03 = _o.VictoryEndAnimationPath03 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath03);
    var _VictoryStartAnimationPath04 = _o.VictoryStartAnimationPath04 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath04);
    var _VictoryEndAnimationPath04 = _o.VictoryEndAnimationPath04 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath04);
    var _VictoryStartAnimationPath05 = _o.VictoryStartAnimationPath05 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath05);
    var _VictoryEndAnimationPath05 = _o.VictoryEndAnimationPath05 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath05);
    var _VictoryStartAnimationPath06 = _o.VictoryStartAnimationPath06 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath06);
    var _VictoryEndAnimationPath06 = _o.VictoryEndAnimationPath06 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath06);
    return CreateCharacterVictoryInteractionExcel(
      builder,
      _o.InteractionId,
      _o.CostumeId01,
      _o.PositionIndex01,
      _VictoryStartAnimationPath01,
      _VictoryEndAnimationPath01,
      _o.CostumeId02,
      _o.PositionIndex02,
      _VictoryStartAnimationPath02,
      _VictoryEndAnimationPath02,
      _o.CostumeId03,
      _o.PositionIndex03,
      _VictoryStartAnimationPath03,
      _VictoryEndAnimationPath03,
      _o.CostumeId04,
      _o.PositionIndex04,
      _VictoryStartAnimationPath04,
      _VictoryEndAnimationPath04,
      _o.CostumeId05,
      _o.PositionIndex05,
      _VictoryStartAnimationPath05,
      _VictoryEndAnimationPath05,
      _o.CostumeId06,
      _o.PositionIndex06,
      _VictoryStartAnimationPath06,
      _VictoryEndAnimationPath06);
  }
}

public class CharacterVictoryInteractionExcelT
{
  public long InteractionId { get; set; }
  public long CostumeId01 { get; set; }
  public int PositionIndex01 { get; set; }
  public string VictoryStartAnimationPath01 { get; set; }
  public string VictoryEndAnimationPath01 { get; set; }
  public long CostumeId02 { get; set; }
  public int PositionIndex02 { get; set; }
  public string VictoryStartAnimationPath02 { get; set; }
  public string VictoryEndAnimationPath02 { get; set; }
  public long CostumeId03 { get; set; }
  public int PositionIndex03 { get; set; }
  public string VictoryStartAnimationPath03 { get; set; }
  public string VictoryEndAnimationPath03 { get; set; }
  public long CostumeId04 { get; set; }
  public int PositionIndex04 { get; set; }
  public string VictoryStartAnimationPath04 { get; set; }
  public string VictoryEndAnimationPath04 { get; set; }
  public long CostumeId05 { get; set; }
  public int PositionIndex05 { get; set; }
  public string VictoryStartAnimationPath05 { get; set; }
  public string VictoryEndAnimationPath05 { get; set; }
  public long CostumeId06 { get; set; }
  public int PositionIndex06 { get; set; }
  public string VictoryStartAnimationPath06 { get; set; }
  public string VictoryEndAnimationPath06 { get; set; }

  public CharacterVictoryInteractionExcelT() {
    this.InteractionId = 0;
    this.CostumeId01 = 0;
    this.PositionIndex01 = 0;
    this.VictoryStartAnimationPath01 = null;
    this.VictoryEndAnimationPath01 = null;
    this.CostumeId02 = 0;
    this.PositionIndex02 = 0;
    this.VictoryStartAnimationPath02 = null;
    this.VictoryEndAnimationPath02 = null;
    this.CostumeId03 = 0;
    this.PositionIndex03 = 0;
    this.VictoryStartAnimationPath03 = null;
    this.VictoryEndAnimationPath03 = null;
    this.CostumeId04 = 0;
    this.PositionIndex04 = 0;
    this.VictoryStartAnimationPath04 = null;
    this.VictoryEndAnimationPath04 = null;
    this.CostumeId05 = 0;
    this.PositionIndex05 = 0;
    this.VictoryStartAnimationPath05 = null;
    this.VictoryEndAnimationPath05 = null;
    this.CostumeId06 = 0;
    this.PositionIndex06 = 0;
    this.VictoryStartAnimationPath06 = null;
    this.VictoryEndAnimationPath06 = null;
  }
}


static public class CharacterVictoryInteractionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*InteractionId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CostumeId01*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*PositionIndex01*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*VictoryStartAnimationPath01*/, false)
      && verifier.VerifyString(tablePos, 12 /*VictoryEndAnimationPath01*/, false)
      && verifier.VerifyField(tablePos, 14 /*CostumeId02*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*PositionIndex02*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*VictoryStartAnimationPath02*/, false)
      && verifier.VerifyString(tablePos, 20 /*VictoryEndAnimationPath02*/, false)
      && verifier.VerifyField(tablePos, 22 /*CostumeId03*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*PositionIndex03*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 26 /*VictoryStartAnimationPath03*/, false)
      && verifier.VerifyString(tablePos, 28 /*VictoryEndAnimationPath03*/, false)
      && verifier.VerifyField(tablePos, 30 /*CostumeId04*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*PositionIndex04*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 34 /*VictoryStartAnimationPath04*/, false)
      && verifier.VerifyString(tablePos, 36 /*VictoryEndAnimationPath04*/, false)
      && verifier.VerifyField(tablePos, 38 /*CostumeId05*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*PositionIndex05*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 42 /*VictoryStartAnimationPath05*/, false)
      && verifier.VerifyString(tablePos, 44 /*VictoryEndAnimationPath05*/, false)
      && verifier.VerifyField(tablePos, 46 /*CostumeId06*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 48 /*PositionIndex06*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 50 /*VictoryStartAnimationPath06*/, false)
      && verifier.VerifyString(tablePos, 52 /*VictoryEndAnimationPath06*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}