// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ShopInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ShopInfoExcel GetRootAsShopInfoExcel(ByteBuffer _bb) { return GetRootAsShopInfoExcel(_bb, new ShopInfoExcel()); }
  public static ShopInfoExcel GetRootAsShopInfoExcel(ByteBuffer _bb, ShopInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.ShopCategoryType CategoryType { get { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ShopCategoryType.General; } }
  public bool IsRefresh { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsSoldOutDimmed { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public SCHALE.Common.FlatData.ParcelType CostParcelType(int j) { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int CostParcelTypeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetCostParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(10, 4); }
#else
  public ArraySegment<byte>? GetCostParcelTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetCostParcelTypeArray() { int o = __p.__offset(10); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long CostParcelId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CostParcelIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCostParcelIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetCostParcelIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetCostParcelIdArray() { return __p.__vector_as_array<long>(12); }
  public long AutoRefreshCoolTime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RefreshAbleCount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoodsId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GoodsIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGoodsIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetGoodsIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetGoodsIdArray() { return __p.__vector_as_array<long>(18); }
  public string OpenPeriodFrom { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodFromBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodFromBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetOpenPeriodFromArray() { return __p.__vector_as_array<byte>(20); }
  public string OpenPeriodTo { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodToBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodToBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetOpenPeriodToArray() { return __p.__vector_as_array<byte>(22); }
  public string ShopProductUpdateTime { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShopProductUpdateTimeBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetShopProductUpdateTimeBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetShopProductUpdateTimeArray() { return __p.__vector_as_array<byte>(24); }
  public SCHALE.Common.FlatData.ParcelType DisplayParcelType { get { int o = __p.__offset(26); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long DisplayParcelId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsShopVisible { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int DisplayOrder { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateDate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId1 { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId2 { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId3 { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId4 { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId5 { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId6 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId7 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId8 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId9 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId10 { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId11 { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ShopUpdateGroupId12 { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.ShopInfoExcel> CreateShopInfoExcel(FlatBufferBuilder builder,
      SCHALE.Common.FlatData.ShopCategoryType CategoryType = SCHALE.Common.FlatData.ShopCategoryType.General,
      bool IsRefresh = false,
      bool IsSoldOutDimmed = false,
      VectorOffset CostParcelTypeOffset = default(VectorOffset),
      VectorOffset CostParcelIdOffset = default(VectorOffset),
      long AutoRefreshCoolTime = 0,
      long RefreshAbleCount = 0,
      VectorOffset GoodsIdOffset = default(VectorOffset),
      StringOffset OpenPeriodFromOffset = default(StringOffset),
      StringOffset OpenPeriodToOffset = default(StringOffset),
      StringOffset ShopProductUpdateTimeOffset = default(StringOffset),
      SCHALE.Common.FlatData.ParcelType DisplayParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long DisplayParcelId = 0,
      bool IsShopVisible = false,
      int DisplayOrder = 0,
      int ShopUpdateDate = 0,
      int ShopUpdateGroupId1 = 0,
      int ShopUpdateGroupId2 = 0,
      int ShopUpdateGroupId3 = 0,
      int ShopUpdateGroupId4 = 0,
      int ShopUpdateGroupId5 = 0,
      int ShopUpdateGroupId6 = 0,
      int ShopUpdateGroupId7 = 0,
      int ShopUpdateGroupId8 = 0,
      int ShopUpdateGroupId9 = 0,
      int ShopUpdateGroupId10 = 0,
      int ShopUpdateGroupId11 = 0,
      int ShopUpdateGroupId12 = 0) {
    builder.StartTable(28);
    ShopInfoExcel.AddDisplayParcelId(builder, DisplayParcelId);
    ShopInfoExcel.AddRefreshAbleCount(builder, RefreshAbleCount);
    ShopInfoExcel.AddAutoRefreshCoolTime(builder, AutoRefreshCoolTime);
    ShopInfoExcel.AddShopUpdateGroupId12(builder, ShopUpdateGroupId12);
    ShopInfoExcel.AddShopUpdateGroupId11(builder, ShopUpdateGroupId11);
    ShopInfoExcel.AddShopUpdateGroupId10(builder, ShopUpdateGroupId10);
    ShopInfoExcel.AddShopUpdateGroupId9(builder, ShopUpdateGroupId9);
    ShopInfoExcel.AddShopUpdateGroupId8(builder, ShopUpdateGroupId8);
    ShopInfoExcel.AddShopUpdateGroupId7(builder, ShopUpdateGroupId7);
    ShopInfoExcel.AddShopUpdateGroupId6(builder, ShopUpdateGroupId6);
    ShopInfoExcel.AddShopUpdateGroupId5(builder, ShopUpdateGroupId5);
    ShopInfoExcel.AddShopUpdateGroupId4(builder, ShopUpdateGroupId4);
    ShopInfoExcel.AddShopUpdateGroupId3(builder, ShopUpdateGroupId3);
    ShopInfoExcel.AddShopUpdateGroupId2(builder, ShopUpdateGroupId2);
    ShopInfoExcel.AddShopUpdateGroupId1(builder, ShopUpdateGroupId1);
    ShopInfoExcel.AddShopUpdateDate(builder, ShopUpdateDate);
    ShopInfoExcel.AddDisplayOrder(builder, DisplayOrder);
    ShopInfoExcel.AddDisplayParcelType(builder, DisplayParcelType);
    ShopInfoExcel.AddShopProductUpdateTime(builder, ShopProductUpdateTimeOffset);
    ShopInfoExcel.AddOpenPeriodTo(builder, OpenPeriodToOffset);
    ShopInfoExcel.AddOpenPeriodFrom(builder, OpenPeriodFromOffset);
    ShopInfoExcel.AddGoodsId(builder, GoodsIdOffset);
    ShopInfoExcel.AddCostParcelId(builder, CostParcelIdOffset);
    ShopInfoExcel.AddCostParcelType(builder, CostParcelTypeOffset);
    ShopInfoExcel.AddCategoryType(builder, CategoryType);
    ShopInfoExcel.AddIsShopVisible(builder, IsShopVisible);
    ShopInfoExcel.AddIsSoldOutDimmed(builder, IsSoldOutDimmed);
    ShopInfoExcel.AddIsRefresh(builder, IsRefresh);
    return ShopInfoExcel.EndShopInfoExcel(builder);
  }

  public static void StartShopInfoExcel(FlatBufferBuilder builder) { builder.StartTable(28); }
  public static void AddCategoryType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ShopCategoryType categoryType) { builder.AddInt(0, (int)categoryType, 0); }
  public static void AddIsRefresh(FlatBufferBuilder builder, bool isRefresh) { builder.AddBool(1, isRefresh, false); }
  public static void AddIsSoldOutDimmed(FlatBufferBuilder builder, bool isSoldOutDimmed) { builder.AddBool(2, isSoldOutDimmed, false); }
  public static void AddCostParcelType(FlatBufferBuilder builder, VectorOffset costParcelTypeOffset) { builder.AddOffset(3, costParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateCostParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostParcelId(FlatBufferBuilder builder, VectorOffset costParcelIdOffset) { builder.AddOffset(4, costParcelIdOffset.Value, 0); }
  public static VectorOffset CreateCostParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAutoRefreshCoolTime(FlatBufferBuilder builder, long autoRefreshCoolTime) { builder.AddLong(5, autoRefreshCoolTime, 0); }
  public static void AddRefreshAbleCount(FlatBufferBuilder builder, long refreshAbleCount) { builder.AddLong(6, refreshAbleCount, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, VectorOffset goodsIdOffset) { builder.AddOffset(7, goodsIdOffset.Value, 0); }
  public static VectorOffset CreateGoodsIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGoodsIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddOpenPeriodFrom(FlatBufferBuilder builder, StringOffset openPeriodFromOffset) { builder.AddOffset(8, openPeriodFromOffset.Value, 0); }
  public static void AddOpenPeriodTo(FlatBufferBuilder builder, StringOffset openPeriodToOffset) { builder.AddOffset(9, openPeriodToOffset.Value, 0); }
  public static void AddShopProductUpdateTime(FlatBufferBuilder builder, StringOffset shopProductUpdateTimeOffset) { builder.AddOffset(10, shopProductUpdateTimeOffset.Value, 0); }
  public static void AddDisplayParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType displayParcelType) { builder.AddInt(11, (int)displayParcelType, 0); }
  public static void AddDisplayParcelId(FlatBufferBuilder builder, long displayParcelId) { builder.AddLong(12, displayParcelId, 0); }
  public static void AddIsShopVisible(FlatBufferBuilder builder, bool isShopVisible) { builder.AddBool(13, isShopVisible, false); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int displayOrder) { builder.AddInt(14, displayOrder, 0); }
  public static void AddShopUpdateDate(FlatBufferBuilder builder, int shopUpdateDate) { builder.AddInt(15, shopUpdateDate, 0); }
  public static void AddShopUpdateGroupId1(FlatBufferBuilder builder, int shopUpdateGroupId1) { builder.AddInt(16, shopUpdateGroupId1, 0); }
  public static void AddShopUpdateGroupId2(FlatBufferBuilder builder, int shopUpdateGroupId2) { builder.AddInt(17, shopUpdateGroupId2, 0); }
  public static void AddShopUpdateGroupId3(FlatBufferBuilder builder, int shopUpdateGroupId3) { builder.AddInt(18, shopUpdateGroupId3, 0); }
  public static void AddShopUpdateGroupId4(FlatBufferBuilder builder, int shopUpdateGroupId4) { builder.AddInt(19, shopUpdateGroupId4, 0); }
  public static void AddShopUpdateGroupId5(FlatBufferBuilder builder, int shopUpdateGroupId5) { builder.AddInt(20, shopUpdateGroupId5, 0); }
  public static void AddShopUpdateGroupId6(FlatBufferBuilder builder, int shopUpdateGroupId6) { builder.AddInt(21, shopUpdateGroupId6, 0); }
  public static void AddShopUpdateGroupId7(FlatBufferBuilder builder, int shopUpdateGroupId7) { builder.AddInt(22, shopUpdateGroupId7, 0); }
  public static void AddShopUpdateGroupId8(FlatBufferBuilder builder, int shopUpdateGroupId8) { builder.AddInt(23, shopUpdateGroupId8, 0); }
  public static void AddShopUpdateGroupId9(FlatBufferBuilder builder, int shopUpdateGroupId9) { builder.AddInt(24, shopUpdateGroupId9, 0); }
  public static void AddShopUpdateGroupId10(FlatBufferBuilder builder, int shopUpdateGroupId10) { builder.AddInt(25, shopUpdateGroupId10, 0); }
  public static void AddShopUpdateGroupId11(FlatBufferBuilder builder, int shopUpdateGroupId11) { builder.AddInt(26, shopUpdateGroupId11, 0); }
  public static void AddShopUpdateGroupId12(FlatBufferBuilder builder, int shopUpdateGroupId12) { builder.AddInt(27, shopUpdateGroupId12, 0); }
  public static Offset<SCHALE.Common.FlatData.ShopInfoExcel> EndShopInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ShopInfoExcel>(o);
  }
  public ShopInfoExcelT UnPack() {
    var _o = new ShopInfoExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ShopInfoExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ShopInfo");
    _o.CategoryType = TableEncryptionService.Convert(this.CategoryType, key);
    _o.IsRefresh = TableEncryptionService.Convert(this.IsRefresh, key);
    _o.IsSoldOutDimmed = TableEncryptionService.Convert(this.IsSoldOutDimmed, key);
    _o.CostParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.CostParcelTypeLength; ++_j) {_o.CostParcelType.Add(TableEncryptionService.Convert(this.CostParcelType(_j), key));}
    _o.CostParcelId = new List<long>();
    for (var _j = 0; _j < this.CostParcelIdLength; ++_j) {_o.CostParcelId.Add(TableEncryptionService.Convert(this.CostParcelId(_j), key));}
    _o.AutoRefreshCoolTime = TableEncryptionService.Convert(this.AutoRefreshCoolTime, key);
    _o.RefreshAbleCount = TableEncryptionService.Convert(this.RefreshAbleCount, key);
    _o.GoodsId = new List<long>();
    for (var _j = 0; _j < this.GoodsIdLength; ++_j) {_o.GoodsId.Add(TableEncryptionService.Convert(this.GoodsId(_j), key));}
    _o.OpenPeriodFrom = TableEncryptionService.Convert(this.OpenPeriodFrom, key);
    _o.OpenPeriodTo = TableEncryptionService.Convert(this.OpenPeriodTo, key);
    _o.ShopProductUpdateTime = TableEncryptionService.Convert(this.ShopProductUpdateTime, key);
    _o.DisplayParcelType = TableEncryptionService.Convert(this.DisplayParcelType, key);
    _o.DisplayParcelId = TableEncryptionService.Convert(this.DisplayParcelId, key);
    _o.IsShopVisible = TableEncryptionService.Convert(this.IsShopVisible, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.ShopUpdateDate = TableEncryptionService.Convert(this.ShopUpdateDate, key);
    _o.ShopUpdateGroupId1 = TableEncryptionService.Convert(this.ShopUpdateGroupId1, key);
    _o.ShopUpdateGroupId2 = TableEncryptionService.Convert(this.ShopUpdateGroupId2, key);
    _o.ShopUpdateGroupId3 = TableEncryptionService.Convert(this.ShopUpdateGroupId3, key);
    _o.ShopUpdateGroupId4 = TableEncryptionService.Convert(this.ShopUpdateGroupId4, key);
    _o.ShopUpdateGroupId5 = TableEncryptionService.Convert(this.ShopUpdateGroupId5, key);
    _o.ShopUpdateGroupId6 = TableEncryptionService.Convert(this.ShopUpdateGroupId6, key);
    _o.ShopUpdateGroupId7 = TableEncryptionService.Convert(this.ShopUpdateGroupId7, key);
    _o.ShopUpdateGroupId8 = TableEncryptionService.Convert(this.ShopUpdateGroupId8, key);
    _o.ShopUpdateGroupId9 = TableEncryptionService.Convert(this.ShopUpdateGroupId9, key);
    _o.ShopUpdateGroupId10 = TableEncryptionService.Convert(this.ShopUpdateGroupId10, key);
    _o.ShopUpdateGroupId11 = TableEncryptionService.Convert(this.ShopUpdateGroupId11, key);
    _o.ShopUpdateGroupId12 = TableEncryptionService.Convert(this.ShopUpdateGroupId12, key);
  }
  public static Offset<SCHALE.Common.FlatData.ShopInfoExcel> Pack(FlatBufferBuilder builder, ShopInfoExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ShopInfoExcel>);
    var _CostParcelType = default(VectorOffset);
    if (_o.CostParcelType != null) {
      var __CostParcelType = _o.CostParcelType.ToArray();
      _CostParcelType = CreateCostParcelTypeVector(builder, __CostParcelType);
    }
    var _CostParcelId = default(VectorOffset);
    if (_o.CostParcelId != null) {
      var __CostParcelId = _o.CostParcelId.ToArray();
      _CostParcelId = CreateCostParcelIdVector(builder, __CostParcelId);
    }
    var _GoodsId = default(VectorOffset);
    if (_o.GoodsId != null) {
      var __GoodsId = _o.GoodsId.ToArray();
      _GoodsId = CreateGoodsIdVector(builder, __GoodsId);
    }
    var _OpenPeriodFrom = _o.OpenPeriodFrom == null ? default(StringOffset) : builder.CreateString(_o.OpenPeriodFrom);
    var _OpenPeriodTo = _o.OpenPeriodTo == null ? default(StringOffset) : builder.CreateString(_o.OpenPeriodTo);
    var _ShopProductUpdateTime = _o.ShopProductUpdateTime == null ? default(StringOffset) : builder.CreateString(_o.ShopProductUpdateTime);
    return CreateShopInfoExcel(
      builder,
      _o.CategoryType,
      _o.IsRefresh,
      _o.IsSoldOutDimmed,
      _CostParcelType,
      _CostParcelId,
      _o.AutoRefreshCoolTime,
      _o.RefreshAbleCount,
      _GoodsId,
      _OpenPeriodFrom,
      _OpenPeriodTo,
      _ShopProductUpdateTime,
      _o.DisplayParcelType,
      _o.DisplayParcelId,
      _o.IsShopVisible,
      _o.DisplayOrder,
      _o.ShopUpdateDate,
      _o.ShopUpdateGroupId1,
      _o.ShopUpdateGroupId2,
      _o.ShopUpdateGroupId3,
      _o.ShopUpdateGroupId4,
      _o.ShopUpdateGroupId5,
      _o.ShopUpdateGroupId6,
      _o.ShopUpdateGroupId7,
      _o.ShopUpdateGroupId8,
      _o.ShopUpdateGroupId9,
      _o.ShopUpdateGroupId10,
      _o.ShopUpdateGroupId11,
      _o.ShopUpdateGroupId12);
  }
}

public class ShopInfoExcelT
{
  public SCHALE.Common.FlatData.ShopCategoryType CategoryType { get; set; }
  public bool IsRefresh { get; set; }
  public bool IsSoldOutDimmed { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> CostParcelType { get; set; }
  public List<long> CostParcelId { get; set; }
  public long AutoRefreshCoolTime { get; set; }
  public long RefreshAbleCount { get; set; }
  public List<long> GoodsId { get; set; }
  public string OpenPeriodFrom { get; set; }
  public string OpenPeriodTo { get; set; }
  public string ShopProductUpdateTime { get; set; }
  public SCHALE.Common.FlatData.ParcelType DisplayParcelType { get; set; }
  public long DisplayParcelId { get; set; }
  public bool IsShopVisible { get; set; }
  public int DisplayOrder { get; set; }
  public int ShopUpdateDate { get; set; }
  public int ShopUpdateGroupId1 { get; set; }
  public int ShopUpdateGroupId2 { get; set; }
  public int ShopUpdateGroupId3 { get; set; }
  public int ShopUpdateGroupId4 { get; set; }
  public int ShopUpdateGroupId5 { get; set; }
  public int ShopUpdateGroupId6 { get; set; }
  public int ShopUpdateGroupId7 { get; set; }
  public int ShopUpdateGroupId8 { get; set; }
  public int ShopUpdateGroupId9 { get; set; }
  public int ShopUpdateGroupId10 { get; set; }
  public int ShopUpdateGroupId11 { get; set; }
  public int ShopUpdateGroupId12 { get; set; }

  public ShopInfoExcelT() {
    this.CategoryType = SCHALE.Common.FlatData.ShopCategoryType.General;
    this.IsRefresh = false;
    this.IsSoldOutDimmed = false;
    this.CostParcelType = null;
    this.CostParcelId = null;
    this.AutoRefreshCoolTime = 0;
    this.RefreshAbleCount = 0;
    this.GoodsId = null;
    this.OpenPeriodFrom = null;
    this.OpenPeriodTo = null;
    this.ShopProductUpdateTime = null;
    this.DisplayParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.DisplayParcelId = 0;
    this.IsShopVisible = false;
    this.DisplayOrder = 0;
    this.ShopUpdateDate = 0;
    this.ShopUpdateGroupId1 = 0;
    this.ShopUpdateGroupId2 = 0;
    this.ShopUpdateGroupId3 = 0;
    this.ShopUpdateGroupId4 = 0;
    this.ShopUpdateGroupId5 = 0;
    this.ShopUpdateGroupId6 = 0;
    this.ShopUpdateGroupId7 = 0;
    this.ShopUpdateGroupId8 = 0;
    this.ShopUpdateGroupId9 = 0;
    this.ShopUpdateGroupId10 = 0;
    this.ShopUpdateGroupId11 = 0;
    this.ShopUpdateGroupId12 = 0;
  }
}


static public class ShopInfoExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CategoryType*/, 4 /*SCHALE.Common.FlatData.ShopCategoryType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*IsRefresh*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*IsSoldOutDimmed*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*CostParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*CostParcelId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 14 /*AutoRefreshCoolTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*RefreshAbleCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*GoodsId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 20 /*OpenPeriodFrom*/, false)
      && verifier.VerifyString(tablePos, 22 /*OpenPeriodTo*/, false)
      && verifier.VerifyString(tablePos, 24 /*ShopProductUpdateTime*/, false)
      && verifier.VerifyField(tablePos, 26 /*DisplayParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*DisplayParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*IsShopVisible*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 32 /*DisplayOrder*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*ShopUpdateDate*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*ShopUpdateGroupId1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*ShopUpdateGroupId2*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*ShopUpdateGroupId3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*ShopUpdateGroupId4*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 44 /*ShopUpdateGroupId5*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*ShopUpdateGroupId6*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*ShopUpdateGroupId7*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 50 /*ShopUpdateGroupId8*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 52 /*ShopUpdateGroupId9*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 54 /*ShopUpdateGroupId10*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 56 /*ShopUpdateGroupId11*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 58 /*ShopUpdateGroupId12*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}