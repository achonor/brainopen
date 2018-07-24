// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: xls2proto/play_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from xls2proto/play_data.proto</summary>
public static partial class PlayDataReflection {

  #region Descriptor
  /// <summary>File descriptor for xls2proto/play_data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlayDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chl4bHMycHJvdG8vcGxheV9kYXRhLnByb3RvInkKCXBsYXlfZGF0YRIKCgJp",
          "ZBgBIAEoDRIMCgRuYW1lGAIgASgJEgwKBGljb24YAyABKAkSEgoKaW50cm9f",
          "aWNvbhgEIAEoCRISCgppbnRyb190aW1lGAUgASgCEgwKBHRpbWUYBiABKAIS",
          "DgoGcGFyYW0xGAcgAygNIiwKD3BsYXlfZGF0YV9BUlJBWRIZCgVpdGVtcxgB",
          "IAMoCzIKLnBsYXlfZGF0YWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::play_data), global::play_data.Parser, new[]{ "Id", "Name", "Icon", "IntroIcon", "IntroTime", "Time", "Param1" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::play_data_ARRAY), global::play_data_ARRAY.Parser, new[]{ "Items" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class play_data : pb::IMessage<play_data> {
  private static readonly pb::MessageParser<play_data> _parser = new pb::MessageParser<play_data>(() => new play_data());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<play_data> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlayDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data(play_data other) : this() {
    id_ = other.id_;
    name_ = other.name_;
    icon_ = other.icon_;
    introIcon_ = other.introIcon_;
    introTime_ = other.introTime_;
    time_ = other.time_;
    param1_ = other.param1_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data Clone() {
    return new play_data(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private uint id_;
  /// <summary>
  ///* ID 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 2;
  private string name_ = "";
  /// <summary>
  ///* 姓名 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "icon" field.</summary>
  public const int IconFieldNumber = 3;
  private string icon_ = "";
  /// <summary>
  ///* icon 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Icon {
    get { return icon_; }
    set {
      icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "intro_icon" field.</summary>
  public const int IntroIconFieldNumber = 4;
  private string introIcon_ = "";
  /// <summary>
  ///* 介绍icon 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string IntroIcon {
    get { return introIcon_; }
    set {
      introIcon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "intro_time" field.</summary>
  public const int IntroTimeFieldNumber = 5;
  private float introTime_;
  /// <summary>
  ///* 介绍时间（秒） 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float IntroTime {
    get { return introTime_; }
    set {
      introTime_ = value;
    }
  }

  /// <summary>Field number for the "time" field.</summary>
  public const int TimeFieldNumber = 6;
  private float time_;
  /// <summary>
  ///* 玩法时间（秒） 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Time {
    get { return time_; }
    set {
      time_ = value;
    }
  }

  /// <summary>Field number for the "param1" field.</summary>
  public const int Param1FieldNumber = 7;
  private static readonly pb::FieldCodec<uint> _repeated_param1_codec
      = pb::FieldCodec.ForUInt32(58);
  private readonly pbc::RepeatedField<uint> param1_ = new pbc::RepeatedField<uint>();
  /// <summary>
  ///* 玩法参数 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<uint> Param1 {
    get { return param1_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as play_data);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(play_data other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Name != other.Name) return false;
    if (Icon != other.Icon) return false;
    if (IntroIcon != other.IntroIcon) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IntroTime, other.IntroTime)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Time, other.Time)) return false;
    if(!param1_.Equals(other.param1_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Icon.Length != 0) hash ^= Icon.GetHashCode();
    if (IntroIcon.Length != 0) hash ^= IntroIcon.GetHashCode();
    if (IntroTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IntroTime);
    if (Time != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Time);
    hash ^= param1_.GetHashCode();
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
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Id);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (Icon.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Icon);
    }
    if (IntroIcon.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(IntroIcon);
    }
    if (IntroTime != 0F) {
      output.WriteRawTag(45);
      output.WriteFloat(IntroTime);
    }
    if (Time != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(Time);
    }
    param1_.WriteTo(output, _repeated_param1_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Icon.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
    }
    if (IntroIcon.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(IntroIcon);
    }
    if (IntroTime != 0F) {
      size += 1 + 4;
    }
    if (Time != 0F) {
      size += 1 + 4;
    }
    size += param1_.CalculateSize(_repeated_param1_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(play_data other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Icon.Length != 0) {
      Icon = other.Icon;
    }
    if (other.IntroIcon.Length != 0) {
      IntroIcon = other.IntroIcon;
    }
    if (other.IntroTime != 0F) {
      IntroTime = other.IntroTime;
    }
    if (other.Time != 0F) {
      Time = other.Time;
    }
    param1_.Add(other.param1_);
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
        case 8: {
          Id = input.ReadUInt32();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 26: {
          Icon = input.ReadString();
          break;
        }
        case 34: {
          IntroIcon = input.ReadString();
          break;
        }
        case 45: {
          IntroTime = input.ReadFloat();
          break;
        }
        case 53: {
          Time = input.ReadFloat();
          break;
        }
        case 58:
        case 56: {
          param1_.AddEntriesFrom(input, _repeated_param1_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class play_data_ARRAY : pb::IMessage<play_data_ARRAY> {
  private static readonly pb::MessageParser<play_data_ARRAY> _parser = new pb::MessageParser<play_data_ARRAY>(() => new play_data_ARRAY());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<play_data_ARRAY> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlayDataReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data_ARRAY() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data_ARRAY(play_data_ARRAY other) : this() {
    items_ = other.items_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public play_data_ARRAY Clone() {
    return new play_data_ARRAY(this);
  }

  /// <summary>Field number for the "items" field.</summary>
  public const int ItemsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::play_data> _repeated_items_codec
      = pb::FieldCodec.ForMessage(10, global::play_data.Parser);
  private readonly pbc::RepeatedField<global::play_data> items_ = new pbc::RepeatedField<global::play_data>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::play_data> Items {
    get { return items_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as play_data_ARRAY);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(play_data_ARRAY other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!items_.Equals(other.items_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= items_.GetHashCode();
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
    items_.WriteTo(output, _repeated_items_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += items_.CalculateSize(_repeated_items_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(play_data_ARRAY other) {
    if (other == null) {
      return;
    }
    items_.Add(other.items_);
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
          items_.AddEntriesFrom(input, _repeated_items_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
