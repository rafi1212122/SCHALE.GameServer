// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct AudioAnimatorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AudioAnimatorExcel GetRootAsAudioAnimatorExcel(ByteBuffer _bb) { return GetRootAsAudioAnimatorExcel(_bb, new AudioAnimatorExcel()); }
  public static AudioAnimatorExcel GetRootAsAudioAnimatorExcel(ByteBuffer _bb, AudioAnimatorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AudioAnimatorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint ControllerNameHash { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string VoiceNamePrefix { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVoiceNamePrefixBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetVoiceNamePrefixBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetVoiceNamePrefixArray() { return __p.__vector_as_array<byte>(6); }
  public uint StateNameHash { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string StateName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStateNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStateNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStateNameArray() { return __p.__vector_as_array<byte>(10); }
  public bool IgnoreInterruptDelay { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IgnoreInterruptPlay { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Volume { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Delay { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int RandomPitchMin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RandomPitchMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AudioPriority { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AudioClipPath(int j) { int o = __p.__offset(26); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AudioClipPathLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public uint VoiceHash(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(28, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(28); }

  public static Offset<SCHALE.Common.FlatData.AudioAnimatorExcel> CreateAudioAnimatorExcel(FlatBufferBuilder builder,
      uint ControllerNameHash = 0,
      StringOffset VoiceNamePrefixOffset = default(StringOffset),
      uint StateNameHash = 0,
      StringOffset StateNameOffset = default(StringOffset),
      bool IgnoreInterruptDelay = false,
      bool IgnoreInterruptPlay = false,
      float Volume = 0.0f,
      float Delay = 0.0f,
      int RandomPitchMin = 0,
      int RandomPitchMax = 0,
      int AudioPriority = 0,
      VectorOffset AudioClipPathOffset = default(VectorOffset),
      VectorOffset VoiceHashOffset = default(VectorOffset)) {
    builder.StartTable(13);
    AudioAnimatorExcel.AddVoiceHash(builder, VoiceHashOffset);
    AudioAnimatorExcel.AddAudioClipPath(builder, AudioClipPathOffset);
    AudioAnimatorExcel.AddAudioPriority(builder, AudioPriority);
    AudioAnimatorExcel.AddRandomPitchMax(builder, RandomPitchMax);
    AudioAnimatorExcel.AddRandomPitchMin(builder, RandomPitchMin);
    AudioAnimatorExcel.AddDelay(builder, Delay);
    AudioAnimatorExcel.AddVolume(builder, Volume);
    AudioAnimatorExcel.AddStateName(builder, StateNameOffset);
    AudioAnimatorExcel.AddStateNameHash(builder, StateNameHash);
    AudioAnimatorExcel.AddVoiceNamePrefix(builder, VoiceNamePrefixOffset);
    AudioAnimatorExcel.AddControllerNameHash(builder, ControllerNameHash);
    AudioAnimatorExcel.AddIgnoreInterruptPlay(builder, IgnoreInterruptPlay);
    AudioAnimatorExcel.AddIgnoreInterruptDelay(builder, IgnoreInterruptDelay);
    return AudioAnimatorExcel.EndAudioAnimatorExcel(builder);
  }

  public static void StartAudioAnimatorExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddControllerNameHash(FlatBufferBuilder builder, uint controllerNameHash) { builder.AddUint(0, controllerNameHash, 0); }
  public static void AddVoiceNamePrefix(FlatBufferBuilder builder, StringOffset voiceNamePrefixOffset) { builder.AddOffset(1, voiceNamePrefixOffset.Value, 0); }
  public static void AddStateNameHash(FlatBufferBuilder builder, uint stateNameHash) { builder.AddUint(2, stateNameHash, 0); }
  public static void AddStateName(FlatBufferBuilder builder, StringOffset stateNameOffset) { builder.AddOffset(3, stateNameOffset.Value, 0); }
  public static void AddIgnoreInterruptDelay(FlatBufferBuilder builder, bool ignoreInterruptDelay) { builder.AddBool(4, ignoreInterruptDelay, false); }
  public static void AddIgnoreInterruptPlay(FlatBufferBuilder builder, bool ignoreInterruptPlay) { builder.AddBool(5, ignoreInterruptPlay, false); }
  public static void AddVolume(FlatBufferBuilder builder, float volume) { builder.AddFloat(6, volume, 0.0f); }
  public static void AddDelay(FlatBufferBuilder builder, float delay) { builder.AddFloat(7, delay, 0.0f); }
  public static void AddRandomPitchMin(FlatBufferBuilder builder, int randomPitchMin) { builder.AddInt(8, randomPitchMin, 0); }
  public static void AddRandomPitchMax(FlatBufferBuilder builder, int randomPitchMax) { builder.AddInt(9, randomPitchMax, 0); }
  public static void AddAudioPriority(FlatBufferBuilder builder, int audioPriority) { builder.AddInt(10, audioPriority, 0); }
  public static void AddAudioClipPath(FlatBufferBuilder builder, VectorOffset audioClipPathOffset) { builder.AddOffset(11, audioClipPathOffset.Value, 0); }
  public static VectorOffset CreateAudioClipPathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAudioClipPathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAudioClipPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset voiceHashOffset) { builder.AddOffset(12, voiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.AudioAnimatorExcel> EndAudioAnimatorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.AudioAnimatorExcel>(o);
  }
  public AudioAnimatorExcelT UnPack() {
    var _o = new AudioAnimatorExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AudioAnimatorExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("AudioAnimator");
    _o.ControllerNameHash = TableEncryptionService.Convert(this.ControllerNameHash, key);
    _o.VoiceNamePrefix = TableEncryptionService.Convert(this.VoiceNamePrefix, key);
    _o.StateNameHash = TableEncryptionService.Convert(this.StateNameHash, key);
    _o.StateName = TableEncryptionService.Convert(this.StateName, key);
    _o.IgnoreInterruptDelay = TableEncryptionService.Convert(this.IgnoreInterruptDelay, key);
    _o.IgnoreInterruptPlay = TableEncryptionService.Convert(this.IgnoreInterruptPlay, key);
    _o.Volume = TableEncryptionService.Convert(this.Volume, key);
    _o.Delay = TableEncryptionService.Convert(this.Delay, key);
    _o.RandomPitchMin = TableEncryptionService.Convert(this.RandomPitchMin, key);
    _o.RandomPitchMax = TableEncryptionService.Convert(this.RandomPitchMax, key);
    _o.AudioPriority = TableEncryptionService.Convert(this.AudioPriority, key);
    _o.AudioClipPath = new List<string>();
    for (var _j = 0; _j < this.AudioClipPathLength; ++_j) {_o.AudioClipPath.Add(TableEncryptionService.Convert(this.AudioClipPath(_j), key));}
    _o.VoiceHash = new List<uint>();
    for (var _j = 0; _j < this.VoiceHashLength; ++_j) {_o.VoiceHash.Add(TableEncryptionService.Convert(this.VoiceHash(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.AudioAnimatorExcel> Pack(FlatBufferBuilder builder, AudioAnimatorExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.AudioAnimatorExcel>);
    var _VoiceNamePrefix = _o.VoiceNamePrefix == null ? default(StringOffset) : builder.CreateString(_o.VoiceNamePrefix);
    var _StateName = _o.StateName == null ? default(StringOffset) : builder.CreateString(_o.StateName);
    var _AudioClipPath = default(VectorOffset);
    if (_o.AudioClipPath != null) {
      var __AudioClipPath = new StringOffset[_o.AudioClipPath.Count];
      for (var _j = 0; _j < __AudioClipPath.Length; ++_j) { __AudioClipPath[_j] = builder.CreateString(_o.AudioClipPath[_j]); }
      _AudioClipPath = CreateAudioClipPathVector(builder, __AudioClipPath);
    }
    var _VoiceHash = default(VectorOffset);
    if (_o.VoiceHash != null) {
      var __VoiceHash = _o.VoiceHash.ToArray();
      _VoiceHash = CreateVoiceHashVector(builder, __VoiceHash);
    }
    return CreateAudioAnimatorExcel(
      builder,
      _o.ControllerNameHash,
      _VoiceNamePrefix,
      _o.StateNameHash,
      _StateName,
      _o.IgnoreInterruptDelay,
      _o.IgnoreInterruptPlay,
      _o.Volume,
      _o.Delay,
      _o.RandomPitchMin,
      _o.RandomPitchMax,
      _o.AudioPriority,
      _AudioClipPath,
      _VoiceHash);
  }
}

public class AudioAnimatorExcelT
{
  public uint ControllerNameHash { get; set; }
  public string VoiceNamePrefix { get; set; }
  public uint StateNameHash { get; set; }
  public string StateName { get; set; }
  public bool IgnoreInterruptDelay { get; set; }
  public bool IgnoreInterruptPlay { get; set; }
  public float Volume { get; set; }
  public float Delay { get; set; }
  public int RandomPitchMin { get; set; }
  public int RandomPitchMax { get; set; }
  public int AudioPriority { get; set; }
  public List<string> AudioClipPath { get; set; }
  public List<uint> VoiceHash { get; set; }

  public AudioAnimatorExcelT() {
    this.ControllerNameHash = 0;
    this.VoiceNamePrefix = null;
    this.StateNameHash = 0;
    this.StateName = null;
    this.IgnoreInterruptDelay = false;
    this.IgnoreInterruptPlay = false;
    this.Volume = 0.0f;
    this.Delay = 0.0f;
    this.RandomPitchMin = 0;
    this.RandomPitchMax = 0;
    this.AudioPriority = 0;
    this.AudioClipPath = null;
    this.VoiceHash = null;
  }
}


static public class AudioAnimatorExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ControllerNameHash*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*VoiceNamePrefix*/, false)
      && verifier.VerifyField(tablePos, 8 /*StateNameHash*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*StateName*/, false)
      && verifier.VerifyField(tablePos, 12 /*IgnoreInterruptDelay*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*IgnoreInterruptPlay*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 16 /*Volume*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*Delay*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*RandomPitchMin*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*RandomPitchMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*AudioPriority*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfStrings(tablePos, 26 /*AudioClipPath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*VoiceHash*/, 4 /*uint*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}