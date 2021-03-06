// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct FlatTiming : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static FlatTiming GetRootAsFlatTiming(ByteBuffer _bb) { return GetRootAsFlatTiming(_bb, new FlatTiming()); }
  public static FlatTiming GetRootAsFlatTiming(ByteBuffer _bb, FlatTiming obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public FlatTiming __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public LongPair? Timing { get { int o = __p.__offset(8); return o != 0 ? (LongPair?)(new LongPair()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<FlatTiming> CreateFlatTiming(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      Offset<LongPair> timingOffset = default(Offset<LongPair>)) {
    builder.StartObject(3);
    FlatTiming.AddTiming(builder, timingOffset);
    FlatTiming.AddName(builder, nameOffset);
    FlatTiming.AddId(builder, id);
    return FlatTiming.EndFlatTiming(builder);
  }

  public static void StartFlatTiming(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddTiming(FlatBufferBuilder builder, Offset<LongPair> timingOffset) { builder.AddOffset(2, timingOffset.Value, 0); }
  public static Offset<FlatTiming> EndFlatTiming(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FlatTiming>(o);
  }
};


}
