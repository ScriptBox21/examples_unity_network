// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Packet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CSMsgPackPacket {

  /// <summary>Holder for reflection information generated from Packet.proto</summary>
  public static partial class PacketReflection {

    #region Descriptor
    /// <summary>File descriptor for Packet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQYWNrZXQucHJvdG8SD0NTTXNnUGFja1BhY2tldCIpCgpDaGF0UmVxUGt0",
            "Eg4KBlVzZXJJRBgBIAEoCRILCgNNc2cYAiABKAkiKQoKQ2hhdE50ZlBrdBIO",
            "CgZVc2VySUQYASABKAkSCwoDTXNnGAIgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CSMsgPackPacket.ChatReqPkt), global::CSMsgPackPacket.ChatReqPkt.Parser, new[]{ "UserID", "Msg" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CSMsgPackPacket.ChatNtfPkt), global::CSMsgPackPacket.ChatNtfPkt.Parser, new[]{ "UserID", "Msg" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChatReqPkt : pb::IMessage<ChatReqPkt> {
    private static readonly pb::MessageParser<ChatReqPkt> _parser = new pb::MessageParser<ChatReqPkt>(() => new ChatReqPkt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatReqPkt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSMsgPackPacket.PacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReqPkt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReqPkt(ChatReqPkt other) : this() {
      userID_ = other.userID_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReqPkt Clone() {
      return new ChatReqPkt(this);
    }

    /// <summary>Field number for the "UserID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private string userID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserID {
      get { return userID_; }
      set {
        userID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatReqPkt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatReqPkt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID.Length != 0) hash ^= UserID.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserID);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatReqPkt other) {
      if (other == null) {
        return;
      }
      if (other.UserID.Length != 0) {
        UserID = other.UserID;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatNtfPkt : pb::IMessage<ChatNtfPkt> {
    private static readonly pb::MessageParser<ChatNtfPkt> _parser = new pb::MessageParser<ChatNtfPkt>(() => new ChatNtfPkt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatNtfPkt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSMsgPackPacket.PacketReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatNtfPkt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatNtfPkt(ChatNtfPkt other) : this() {
      userID_ = other.userID_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatNtfPkt Clone() {
      return new ChatNtfPkt(this);
    }

    /// <summary>Field number for the "UserID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private string userID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserID {
      get { return userID_; }
      set {
        userID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatNtfPkt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatNtfPkt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID.Length != 0) hash ^= UserID.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserID);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserID);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatNtfPkt other) {
      if (other == null) {
        return;
      }
      if (other.UserID.Length != 0) {
        UserID = other.UserID;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserID = input.ReadString();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
