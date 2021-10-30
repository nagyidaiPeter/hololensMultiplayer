// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace hololensMulti
{

using global::System;
using global::FlatBuffers;

public struct DisconnectFB : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static DisconnectFB GetRootAsDisconnectFB(ByteBuffer _bb) { return GetRootAsDisconnectFB(_bb, new DisconnectFB()); }
  public static DisconnectFB GetRootAsDisconnectFB(ByteBuffer _bb, DisconnectFB obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DisconnectFB __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte PlayerID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<hololensMulti.DisconnectFB> CreateDisconnectFB(FlatBufferBuilder builder,
      byte PlayerID = 0) {
    builder.StartTable(1);
    DisconnectFB.AddPlayerID(builder, PlayerID);
    return DisconnectFB.EndDisconnectFB(builder);
  }

  public static void StartDisconnectFB(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddPlayerID(FlatBufferBuilder builder, byte PlayerID) { builder.AddByte(0, PlayerID, 0); }
  public static Offset<hololensMulti.DisconnectFB> EndDisconnectFB(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<hololensMulti.DisconnectFB>(o);
  }
  public static void FinishDisconnectFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.DisconnectFB> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedDisconnectFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.DisconnectFB> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
