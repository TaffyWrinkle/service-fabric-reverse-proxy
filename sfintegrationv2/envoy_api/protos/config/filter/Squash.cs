// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: http/squash/v2/squash.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Squash.V2 {

  /// <summary>Holder for reflection information generated from http/squash/v2/squash.proto</summary>
  public static partial class SquashReflection {

    #region Descriptor
    /// <summary>File descriptor for http/squash/v2/squash.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SquashReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtodHRwL3NxdWFzaC92Mi9zcXVhc2gucHJvdG8SImVudm95LmNvbmZpZy5m",
            "aWx0ZXIuaHR0cC5zcXVhc2gudjIaHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlv",
            "bi5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8aFGdvZ29wcm90by9nb2dvLnByb3RvIpICCgZT",
            "cXVhc2gSGgoHY2x1c3RlchgBIAEoCUIJuunAAwRyAiABEjQKE2F0dGFjaG1l",
            "bnRfdGVtcGxhdGUYAiABKAsyFy5nb29nbGUucHJvdG9idWYuU3RydWN0EjgK",
            "D3JlcXVlc3RfdGltZW91dBgDIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJh",
            "dGlvbkIEmN8fARI7ChJhdHRhY2htZW50X3RpbWVvdXQYBCABKAsyGS5nb29n",
            "bGUucHJvdG9idWYuRHVyYXRpb25CBJjfHwESPwoWYXR0YWNobWVudF9wb2xs",
            "X3BlcmlvZBgFIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbkIEmN8f",
            "AUIEWgJ2MmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Squash.V2.Squash), global::Envoy.Config.Filter.Http.Squash.V2.Squash.Parser, new[]{ "Cluster", "AttachmentTemplate", "RequestTimeout", "AttachmentTimeout", "AttachmentPollPeriod" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#proto-status: experimental]
  /// </summary>
  public sealed partial class Squash : pb::IMessage<Squash> {
    private static readonly pb::MessageParser<Squash> _parser = new pb::MessageParser<Squash>(() => new Squash());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Squash> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Squash.V2.SquashReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Squash() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Squash(Squash other) : this() {
      cluster_ = other.cluster_;
      AttachmentTemplate = other.attachmentTemplate_ != null ? other.AttachmentTemplate.Clone() : null;
      RequestTimeout = other.requestTimeout_ != null ? other.RequestTimeout.Clone() : null;
      AttachmentTimeout = other.attachmentTimeout_ != null ? other.AttachmentTimeout.Clone() : null;
      AttachmentPollPeriod = other.attachmentPollPeriod_ != null ? other.AttachmentPollPeriod.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Squash Clone() {
      return new Squash(this);
    }

    /// <summary>Field number for the "cluster" field.</summary>
    public const int ClusterFieldNumber = 1;
    private string cluster_ = "";
    /// <summary>
    /// The name of the cluster that hosts the Squash server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Cluster {
      get { return cluster_; }
      set {
        cluster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attachment_template" field.</summary>
    public const int AttachmentTemplateFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct attachmentTemplate_;
    /// <summary>
    /// When the filter requests the Squash server to create a DebugAttachment, it will use this
    /// structure as template for the body of the request. It can contain reference to environment
    /// variables in the form of '{{ ENV_VAR_NAME }}'. These can be used to provide the Squash server
    /// with more information to find the process to attach the debugger to. For example, in a
    /// Istio/k8s environment, this will contain information on the pod:
    ///
    /// .. code-block:: json
    ///
    ///  {
    ///    "spec": {
    ///      "attachment": {
    ///        "pod": "{{ POD_NAME }}",
    ///        "namespace": "{{ POD_NAMESPACE }}"
    ///      },
    ///      "match_request": true
    ///    }
    ///  }
    ///
    /// (where POD_NAME, POD_NAMESPACE are configured in the pod via the Downward API)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct AttachmentTemplate {
      get { return attachmentTemplate_; }
      set {
        attachmentTemplate_ = value;
      }
    }

    /// <summary>Field number for the "request_timeout" field.</summary>
    public const int RequestTimeoutFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration requestTimeout_;
    /// <summary>
    /// The timeout for individual requests sent to the Squash cluster. Defaults to 1 second.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration RequestTimeout {
      get { return requestTimeout_; }
      set {
        requestTimeout_ = value;
      }
    }

    /// <summary>Field number for the "attachment_timeout" field.</summary>
    public const int AttachmentTimeoutFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration attachmentTimeout_;
    /// <summary>
    /// The total timeout Squash will delay a request and wait for it to be attached. Defaults to 60
    /// seconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration AttachmentTimeout {
      get { return attachmentTimeout_; }
      set {
        attachmentTimeout_ = value;
      }
    }

    /// <summary>Field number for the "attachment_poll_period" field.</summary>
    public const int AttachmentPollPeriodFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Duration attachmentPollPeriod_;
    /// <summary>
    /// Amount of time to poll for the status of the attachment object in the Squash server
    /// (to check if has been attached). Defaults to 1 second.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration AttachmentPollPeriod {
      get { return attachmentPollPeriod_; }
      set {
        attachmentPollPeriod_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Squash);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Squash other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Cluster != other.Cluster) return false;
      if (!object.Equals(AttachmentTemplate, other.AttachmentTemplate)) return false;
      if (!object.Equals(RequestTimeout, other.RequestTimeout)) return false;
      if (!object.Equals(AttachmentTimeout, other.AttachmentTimeout)) return false;
      if (!object.Equals(AttachmentPollPeriod, other.AttachmentPollPeriod)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Cluster.Length != 0) hash ^= Cluster.GetHashCode();
      if (attachmentTemplate_ != null) hash ^= AttachmentTemplate.GetHashCode();
      if (requestTimeout_ != null) hash ^= RequestTimeout.GetHashCode();
      if (attachmentTimeout_ != null) hash ^= AttachmentTimeout.GetHashCode();
      if (attachmentPollPeriod_ != null) hash ^= AttachmentPollPeriod.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Cluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Cluster);
      }
      if (attachmentTemplate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AttachmentTemplate);
      }
      if (requestTimeout_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RequestTimeout);
      }
      if (attachmentTimeout_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(AttachmentTimeout);
      }
      if (attachmentPollPeriod_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AttachmentPollPeriod);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Cluster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cluster);
      }
      if (attachmentTemplate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttachmentTemplate);
      }
      if (requestTimeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestTimeout);
      }
      if (attachmentTimeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttachmentTimeout);
      }
      if (attachmentPollPeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttachmentPollPeriod);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Squash other) {
      if (other == null) {
        return;
      }
      if (other.Cluster.Length != 0) {
        Cluster = other.Cluster;
      }
      if (other.attachmentTemplate_ != null) {
        if (attachmentTemplate_ == null) {
          attachmentTemplate_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        AttachmentTemplate.MergeFrom(other.AttachmentTemplate);
      }
      if (other.requestTimeout_ != null) {
        if (requestTimeout_ == null) {
          requestTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RequestTimeout.MergeFrom(other.RequestTimeout);
      }
      if (other.attachmentTimeout_ != null) {
        if (attachmentTimeout_ == null) {
          attachmentTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        AttachmentTimeout.MergeFrom(other.AttachmentTimeout);
      }
      if (other.attachmentPollPeriod_ != null) {
        if (attachmentPollPeriod_ == null) {
          attachmentPollPeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        AttachmentPollPeriod.MergeFrom(other.AttachmentPollPeriod);
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
            Cluster = input.ReadString();
            break;
          }
          case 18: {
            if (attachmentTemplate_ == null) {
              attachmentTemplate_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(attachmentTemplate_);
            break;
          }
          case 26: {
            if (requestTimeout_ == null) {
              requestTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(requestTimeout_);
            break;
          }
          case 34: {
            if (attachmentTimeout_ == null) {
              attachmentTimeout_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(attachmentTimeout_);
            break;
          }
          case 42: {
            if (attachmentPollPeriod_ == null) {
              attachmentPollPeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(attachmentPollPeriod_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
