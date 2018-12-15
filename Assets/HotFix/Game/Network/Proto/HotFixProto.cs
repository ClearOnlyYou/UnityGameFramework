// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HotFixProto.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
#region Messages
public partial class HotFixProtoTest : pb::IMessage {
  private static readonly pb::MessageParser<HotFixProtoTest> _parser = new pb::MessageParser<HotFixProtoTest>(() => new HotFixProtoTest());
  public static pb::MessageParser<HotFixProtoTest> Parser { get { return _parser; } }

  private int iD_;
  public int ID {
    get { return iD_; }
    set {
      iD_ = value;
    }
  }

  private string commit_ = "";
  /// <summary>
  ///提交
  /// </summary>
  public string Commit {
    get { return commit_; }
    set {
      commit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  private string message_ = "";
  /// <summary>
  ///信息
  /// </summary>
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  public void WriteTo(pb::CodedOutputStream output) {
    if (ID != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(ID);
    }
    if (Commit.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Commit);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Message);
    }
  }

  public int CalculateSize() {
    int size = 0;
    if (ID != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(ID);
    }
    if (Commit.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Commit);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    return size;
  }

  public void MergeFrom(pb::CodedInputStream input) {
    iD_ = 0;
    commit_ = "";
    message_ = "";
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          ID = input.ReadInt32();
          break;
        }
        case 18: {
          Commit = input.ReadString();
          break;
        }
        case 26: {
          Message = input.ReadString();
          break;
        }
      }
    }
  }

}

public partial class C2S_TestInfo : pb::IMessage {
  private static readonly pb::MessageParser<C2S_TestInfo> _parser = new pb::MessageParser<C2S_TestInfo>(() => new C2S_TestInfo());
  public static pb::MessageParser<C2S_TestInfo> Parser { get { return _parser; } }

  private int rpcId_;
  public int RpcId {
    get { return rpcId_; }
    set {
      rpcId_ = value;
    }
  }

  private string message_ = "";
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  public void WriteTo(pb::CodedOutputStream output) {
    if (RpcId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(RpcId);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Message);
    }
  }

  public int CalculateSize() {
    int size = 0;
    if (RpcId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    return size;
  }

  public void MergeFrom(pb::CodedInputStream input) {
    rpcId_ = 0;
    message_ = "";
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          RpcId = input.ReadInt32();
          break;
        }
        case 18: {
          Message = input.ReadString();
          break;
        }
      }
    }
  }

}

public partial class S2C_TestInfo : pb::IMessage {
  private static readonly pb::MessageParser<S2C_TestInfo> _parser = new pb::MessageParser<S2C_TestInfo>(() => new S2C_TestInfo());
  public static pb::MessageParser<S2C_TestInfo> Parser { get { return _parser; } }

  private int rpcId_;
  public int RpcId {
    get { return rpcId_; }
    set {
      rpcId_ = value;
    }
  }

  private string message_ = "";
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  public void WriteTo(pb::CodedOutputStream output) {
    if (RpcId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(RpcId);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Message);
    }
  }

  public int CalculateSize() {
    int size = 0;
    if (RpcId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    return size;
  }

  public void MergeFrom(pb::CodedInputStream input) {
    rpcId_ = 0;
    message_ = "";
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          RpcId = input.ReadInt32();
          break;
        }
        case 18: {
          Message = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
