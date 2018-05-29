// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ratelimit.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V2.Ratelimit {

  /// <summary>Holder for reflection information generated from ratelimit.proto</summary>
  public static partial class RatelimitReflection {

    #region Descriptor
    /// <summary>File descriptor for ratelimit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RatelimitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9yYXRlbGltaXQucHJvdG8SFmVudm95LmFwaS52Mi5yYXRlbGltaXQaF3Zh",
            "bGlkYXRlL3ZhbGlkYXRlLnByb3RvIqABChNSYXRlTGltaXREZXNjcmlwdG9y",
            "Ek4KB2VudHJpZXMYASADKAsyMS5lbnZveS5hcGkudjIucmF0ZWxpbWl0LlJh",
            "dGVMaW1pdERlc2NyaXB0b3IuRW50cnlCCrrpwAMFkgECCAEaOQoFRW50cnkS",
            "FgoDa2V5GAEgASgJQgm66cADBHICIAESGAoFdmFsdWUYAiABKAlCCbrpwAME",
            "cgIgAUILWglyYXRlbGltaXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor), global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Parser, new[]{ "Entries" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry), global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry.Parser, new[]{ "Key", "Value" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A RateLimitDescriptor is a list of hierarchical entries that are used by the service to
  /// determine the final rate limit key and overall allowed limit. Here are some examples of how
  /// they might be used for the domain "envoy".
  ///
  /// .. code-block:: cpp
  ///
  ///   ["authenticated": "false"], ["remote_address": "10.0.0.1"]
  ///
  /// What it does: Limits all unauthenticated traffic for the IP address 10.0.0.1. The
  /// configuration supplies a default limit for the *remote_address* key. If there is a desire to
  /// raise the limit for 10.0.0.1 or block it entirely it can be specified directly in the
  /// configuration.
  ///
  /// .. code-block:: cpp
  ///
  ///   ["authenticated": "false"], ["path": "/foo/bar"]
  ///
  /// What it does: Limits all unauthenticated traffic globally for a specific path (or prefix if
  /// configured that way in the service).
  ///
  /// .. code-block:: cpp
  ///
  ///   ["authenticated": "false"], ["path": "/foo/bar"], ["remote_address": "10.0.0.1"]
  ///
  /// What it does: Limits unauthenticated traffic to a specific path for a specific IP address.
  /// Like (1) we can raise/block specific IP addresses if we want with an override configuration.
  ///
  /// .. code-block:: cpp
  ///
  ///   ["authenticated": "true"], ["client_id": "foo"]
  ///
  /// What it does: Limits all traffic for an authenticated client "foo"
  ///
  /// .. code-block:: cpp
  ///
  ///   ["authenticated": "true"], ["client_id": "foo"], ["path": "/foo/bar"]
  ///
  /// What it does: Limits traffic to a specific path for an authenticated client "foo"
  ///
  /// The idea behind the API is that (1)/(2)/(3) and (4)/(5) can be sent in 1 request if desired.
  /// This enables building complex application scenarios with a generic backend.
  /// </summary>
  public sealed partial class RateLimitDescriptor : pb::IMessage<RateLimitDescriptor> {
    private static readonly pb::MessageParser<RateLimitDescriptor> _parser = new pb::MessageParser<RateLimitDescriptor>(() => new RateLimitDescriptor());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateLimitDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Ratelimit.RatelimitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitDescriptor(RateLimitDescriptor other) : this() {
      entries_ = other.entries_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitDescriptor Clone() {
      return new RateLimitDescriptor(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry> entries_ = new pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry>();
    /// <summary>
    /// Descriptor entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Types.Entry> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RateLimitDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateLimitDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      entries_.WriteTo(output, _repeated_entries_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RateLimitDescriptor other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RateLimitDescriptor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Entry : pb::IMessage<Entry> {
        private static readonly pb::MessageParser<Entry> _parser = new pb::MessageParser<Entry>(() => new Entry());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Entry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entry(Entry other) : this() {
          key_ = other.key_;
          value_ = other.value_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Entry Clone() {
          return new Entry(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        private string key_ = "";
        /// <summary>
        /// Descriptor key.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Key {
          get { return key_; }
          set {
            key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 2;
        private string value_ = "";
        /// <summary>
        /// Descriptor value.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Value {
          get { return value_; }
          set {
            value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Entry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Entry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (Value != other.Value) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Key.Length != 0) hash ^= Key.GetHashCode();
          if (Value.Length != 0) hash ^= Value.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Key.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Key);
          }
          if (Value.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Value);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Key.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (Value.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Entry other) {
          if (other == null) {
            return;
          }
          if (other.Key.Length != 0) {
            Key = other.Key;
          }
          if (other.Value.Length != 0) {
            Value = other.Value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Key = input.ReadString();
                break;
              }
              case 18: {
                Value = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
