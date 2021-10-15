// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace hololensMulti
{

using global::System;
using global::FlatBuffers;

public struct ObjectFB : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static ObjectFB GetRootAsObjectFB(ByteBuffer _bb) { return GetRootAsObjectFB(_bb, new ObjectFB()); }
  public static ObjectFB GetRootAsObjectFB(ByteBuffer _bb, ObjectFB obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObjectFB __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ObjectID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public hololensMulti.Vec3? Pos { get { int o = __p.__offset(6); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Quat? Rot { get { int o = __p.__offset(8); return o != 0 ? (hololensMulti.Quat?)(new hololensMulti.Quat()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartObjectFB(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddObjectID(FlatBufferBuilder builder, int ObjectID) { builder.AddInt(0, ObjectID, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> PosOffset) { builder.AddStruct(1, PosOffset.Value, 0); }
  public static void AddRot(FlatBufferBuilder builder, Offset<hololensMulti.Quat> RotOffset) { builder.AddStruct(2, RotOffset.Value, 0); }
  public static Offset<hololensMulti.ObjectFB> EndObjectFB(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<hololensMulti.ObjectFB>(o);
  }
  public static void FinishObjectFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.ObjectFB> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedObjectFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.ObjectFB> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}