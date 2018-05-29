// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: load_report.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V2.Endpoint {

  /// <summary>Holder for reflection information generated from load_report.proto</summary>
  public static partial class LoadReportReflection {

    #region Descriptor
    /// <summary>File descriptor for load_report.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoadReportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFsb2FkX3JlcG9ydC5wcm90bxIVZW52b3kuYXBpLnYyLmVuZHBvaW50Ghxl",
            "bnZveS9hcGkvdjIvY29yZS9iYXNlLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0",
            "ZS5wcm90bxoUZ29nb3Byb3RvL2dvZ28ucHJvdG8iiAIKFVVwc3RyZWFtTG9j",
            "YWxpdHlTdGF0cxItCghsb2NhbGl0eRgBIAEoCzIbLmVudm95LmFwaS52Mi5j",
            "b3JlLkxvY2FsaXR5EiEKGXRvdGFsX3N1Y2Nlc3NmdWxfcmVxdWVzdHMYAiAB",
            "KAQSIgoadG90YWxfcmVxdWVzdHNfaW5fcHJvZ3Jlc3MYAyABKAQSHAoUdG90",
            "YWxfZXJyb3JfcmVxdWVzdHMYBCABKAQSSQoRbG9hZF9tZXRyaWNfc3RhdHMY",
            "BSADKAsyLi5lbnZveS5hcGkudjIuZW5kcG9pbnQuRW5kcG9pbnRMb2FkTWV0",
            "cmljU3RhdHMSEAoIcHJpb3JpdHkYBiABKA0idQoXRW5kcG9pbnRMb2FkTWV0",
            "cmljU3RhdHMSEwoLbWV0cmljX25hbWUYASABKAkSKQohbnVtX3JlcXVlc3Rz",
            "X2ZpbmlzaGVkX3dpdGhfbWV0cmljGAIgASgEEhoKEnRvdGFsX21ldHJpY192",
            "YWx1ZRgDIAEoASKqAQoMQ2x1c3RlclN0YXRzEh8KDGNsdXN0ZXJfbmFtZRgB",
            "IAEoCUIJuunAAwRyAiABElkKF3Vwc3RyZWFtX2xvY2FsaXR5X3N0YXRzGAIg",
            "AygLMiwuZW52b3kuYXBpLnYyLmVuZHBvaW50LlVwc3RyZWFtTG9jYWxpdHlT",
            "dGF0c0IKuunAAwWSAQIIARIeChZ0b3RhbF9kcm9wcGVkX3JlcXVlc3RzGAMg",
            "ASgEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.BaseReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats), global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats.Parser, new[]{ "Locality", "TotalSuccessfulRequests", "TotalRequestsInProgress", "TotalErrorRequests", "LoadMetricStats", "Priority" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats), global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats.Parser, new[]{ "MetricName", "NumRequestsFinishedWithMetric", "TotalMetricValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Endpoint.ClusterStats), global::Envoy.Api.V2.Endpoint.ClusterStats.Parser, new[]{ "ClusterName", "UpstreamLocalityStats", "TotalDroppedRequests" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// These are stats Envoy reports to GLB every so often. Report frequency is
  /// defined by
  /// :ref:`LoadStatsResponse.load_reporting_interval&lt;envoy_api_field_load_stats.LoadStatsResponse.load_reporting_interval>`.
  /// Stats per upstream region/zone and optionally per subzone.
  /// [#not-implemented-hide:] Not configuration. TBD how to doc proto APIs.
  /// </summary>
  public sealed partial class UpstreamLocalityStats : pb::IMessage<UpstreamLocalityStats> {
    private static readonly pb::MessageParser<UpstreamLocalityStats> _parser = new pb::MessageParser<UpstreamLocalityStats>(() => new UpstreamLocalityStats());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpstreamLocalityStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Endpoint.LoadReportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpstreamLocalityStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpstreamLocalityStats(UpstreamLocalityStats other) : this() {
      Locality = other.locality_ != null ? other.Locality.Clone() : null;
      totalSuccessfulRequests_ = other.totalSuccessfulRequests_;
      totalRequestsInProgress_ = other.totalRequestsInProgress_;
      totalErrorRequests_ = other.totalErrorRequests_;
      loadMetricStats_ = other.loadMetricStats_.Clone();
      priority_ = other.priority_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpstreamLocalityStats Clone() {
      return new UpstreamLocalityStats(this);
    }

    /// <summary>Field number for the "locality" field.</summary>
    public const int LocalityFieldNumber = 1;
    private global::Envoy.Api.V2.Core.Locality locality_;
    /// <summary>
    /// Name of zone, region and optionally endpoint group these metrics were
    /// collected from. Zone and region names could be empty if unknown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V2.Core.Locality Locality {
      get { return locality_; }
      set {
        locality_ = value;
      }
    }

    /// <summary>Field number for the "total_successful_requests" field.</summary>
    public const int TotalSuccessfulRequestsFieldNumber = 2;
    private ulong totalSuccessfulRequests_;
    /// <summary>
    /// The total number of requests sent by this Envoy since the last report. A
    /// single HTTP or gRPC request or stream is counted as one request. A TCP
    /// connection is also treated as one request. There is no explicit
    /// total_requests field below for a locality, but it may be inferred from:
    ///
    /// .. code-block:: none
    ///
    ///   total_requests = total_successful_requests + total_requests_in_progress +
    ///     total_error_requests
    ///
    /// The total number of requests successfully completed by the endpoints in the
    /// locality. These include non-5xx responses for HTTP, where errors
    /// originate at the client and the endpoint responded successfuly. For gRPC,
    /// the grpc-status values are those not covered by total_error_requests below.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TotalSuccessfulRequests {
      get { return totalSuccessfulRequests_; }
      set {
        totalSuccessfulRequests_ = value;
      }
    }

    /// <summary>Field number for the "total_requests_in_progress" field.</summary>
    public const int TotalRequestsInProgressFieldNumber = 3;
    private ulong totalRequestsInProgress_;
    /// <summary>
    /// The total number of unfinished requests
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TotalRequestsInProgress {
      get { return totalRequestsInProgress_; }
      set {
        totalRequestsInProgress_ = value;
      }
    }

    /// <summary>Field number for the "total_error_requests" field.</summary>
    public const int TotalErrorRequestsFieldNumber = 4;
    private ulong totalErrorRequests_;
    /// <summary>
    /// The total number of requests that failed due to errors at the endpoint.
    /// For HTTP these are responses with 5xx status codes and for gRPC the
    /// grpc-status values:
    ///
    ///   - DeadlineExceeded
    ///   - Unimplemented
    ///   - Internal
    ///   - Unavailable
    ///   - Unknown
    ///   - DataLoss
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TotalErrorRequests {
      get { return totalErrorRequests_; }
      set {
        totalErrorRequests_ = value;
      }
    }

    /// <summary>Field number for the "load_metric_stats" field.</summary>
    public const int LoadMetricStatsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats> _repeated_loadMetricStats_codec
        = pb::FieldCodec.ForMessage(42, global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats> loadMetricStats_ = new pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats>();
    /// <summary>
    /// Stats for multi-dimensional load balancing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.EndpointLoadMetricStats> LoadMetricStats {
      get { return loadMetricStats_; }
    }

    /// <summary>Field number for the "priority" field.</summary>
    public const int PriorityFieldNumber = 6;
    private uint priority_;
    /// <summary>
    /// [#not-implemented-hide:] The priority of the endpoint group these metrics
    /// were collected from.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Priority {
      get { return priority_; }
      set {
        priority_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpstreamLocalityStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpstreamLocalityStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Locality, other.Locality)) return false;
      if (TotalSuccessfulRequests != other.TotalSuccessfulRequests) return false;
      if (TotalRequestsInProgress != other.TotalRequestsInProgress) return false;
      if (TotalErrorRequests != other.TotalErrorRequests) return false;
      if(!loadMetricStats_.Equals(other.loadMetricStats_)) return false;
      if (Priority != other.Priority) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (locality_ != null) hash ^= Locality.GetHashCode();
      if (TotalSuccessfulRequests != 0UL) hash ^= TotalSuccessfulRequests.GetHashCode();
      if (TotalRequestsInProgress != 0UL) hash ^= TotalRequestsInProgress.GetHashCode();
      if (TotalErrorRequests != 0UL) hash ^= TotalErrorRequests.GetHashCode();
      hash ^= loadMetricStats_.GetHashCode();
      if (Priority != 0) hash ^= Priority.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (locality_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Locality);
      }
      if (TotalSuccessfulRequests != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TotalSuccessfulRequests);
      }
      if (TotalRequestsInProgress != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TotalRequestsInProgress);
      }
      if (TotalErrorRequests != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TotalErrorRequests);
      }
      loadMetricStats_.WriteTo(output, _repeated_loadMetricStats_codec);
      if (Priority != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Priority);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (locality_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Locality);
      }
      if (TotalSuccessfulRequests != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalSuccessfulRequests);
      }
      if (TotalRequestsInProgress != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalRequestsInProgress);
      }
      if (TotalErrorRequests != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalErrorRequests);
      }
      size += loadMetricStats_.CalculateSize(_repeated_loadMetricStats_codec);
      if (Priority != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Priority);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpstreamLocalityStats other) {
      if (other == null) {
        return;
      }
      if (other.locality_ != null) {
        if (locality_ == null) {
          locality_ = new global::Envoy.Api.V2.Core.Locality();
        }
        Locality.MergeFrom(other.Locality);
      }
      if (other.TotalSuccessfulRequests != 0UL) {
        TotalSuccessfulRequests = other.TotalSuccessfulRequests;
      }
      if (other.TotalRequestsInProgress != 0UL) {
        TotalRequestsInProgress = other.TotalRequestsInProgress;
      }
      if (other.TotalErrorRequests != 0UL) {
        TotalErrorRequests = other.TotalErrorRequests;
      }
      loadMetricStats_.Add(other.loadMetricStats_);
      if (other.Priority != 0) {
        Priority = other.Priority;
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
            if (locality_ == null) {
              locality_ = new global::Envoy.Api.V2.Core.Locality();
            }
            input.ReadMessage(locality_);
            break;
          }
          case 16: {
            TotalSuccessfulRequests = input.ReadUInt64();
            break;
          }
          case 24: {
            TotalRequestsInProgress = input.ReadUInt64();
            break;
          }
          case 32: {
            TotalErrorRequests = input.ReadUInt64();
            break;
          }
          case 42: {
            loadMetricStats_.AddEntriesFrom(input, _repeated_loadMetricStats_codec);
            break;
          }
          case 48: {
            Priority = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// [#not-implemented-hide:] Not configuration. TBD how to doc proto APIs.
  /// </summary>
  public sealed partial class EndpointLoadMetricStats : pb::IMessage<EndpointLoadMetricStats> {
    private static readonly pb::MessageParser<EndpointLoadMetricStats> _parser = new pb::MessageParser<EndpointLoadMetricStats>(() => new EndpointLoadMetricStats());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EndpointLoadMetricStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Endpoint.LoadReportReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointLoadMetricStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointLoadMetricStats(EndpointLoadMetricStats other) : this() {
      metricName_ = other.metricName_;
      numRequestsFinishedWithMetric_ = other.numRequestsFinishedWithMetric_;
      totalMetricValue_ = other.totalMetricValue_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointLoadMetricStats Clone() {
      return new EndpointLoadMetricStats(this);
    }

    /// <summary>Field number for the "metric_name" field.</summary>
    public const int MetricNameFieldNumber = 1;
    private string metricName_ = "";
    /// <summary>
    /// Name of the metric; may be empty.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MetricName {
      get { return metricName_; }
      set {
        metricName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "num_requests_finished_with_metric" field.</summary>
    public const int NumRequestsFinishedWithMetricFieldNumber = 2;
    private ulong numRequestsFinishedWithMetric_;
    /// <summary>
    /// Number of calls that finished and included this metric.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong NumRequestsFinishedWithMetric {
      get { return numRequestsFinishedWithMetric_; }
      set {
        numRequestsFinishedWithMetric_ = value;
      }
    }

    /// <summary>Field number for the "total_metric_value" field.</summary>
    public const int TotalMetricValueFieldNumber = 3;
    private double totalMetricValue_;
    /// <summary>
    /// Sum of metric values across all calls that finished with this metric for
    /// load_reporting_interval.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double TotalMetricValue {
      get { return totalMetricValue_; }
      set {
        totalMetricValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EndpointLoadMetricStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EndpointLoadMetricStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MetricName != other.MetricName) return false;
      if (NumRequestsFinishedWithMetric != other.NumRequestsFinishedWithMetric) return false;
      if (TotalMetricValue != other.TotalMetricValue) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MetricName.Length != 0) hash ^= MetricName.GetHashCode();
      if (NumRequestsFinishedWithMetric != 0UL) hash ^= NumRequestsFinishedWithMetric.GetHashCode();
      if (TotalMetricValue != 0D) hash ^= TotalMetricValue.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MetricName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MetricName);
      }
      if (NumRequestsFinishedWithMetric != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(NumRequestsFinishedWithMetric);
      }
      if (TotalMetricValue != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(TotalMetricValue);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MetricName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetricName);
      }
      if (NumRequestsFinishedWithMetric != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NumRequestsFinishedWithMetric);
      }
      if (TotalMetricValue != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EndpointLoadMetricStats other) {
      if (other == null) {
        return;
      }
      if (other.MetricName.Length != 0) {
        MetricName = other.MetricName;
      }
      if (other.NumRequestsFinishedWithMetric != 0UL) {
        NumRequestsFinishedWithMetric = other.NumRequestsFinishedWithMetric;
      }
      if (other.TotalMetricValue != 0D) {
        TotalMetricValue = other.TotalMetricValue;
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
            MetricName = input.ReadString();
            break;
          }
          case 16: {
            NumRequestsFinishedWithMetric = input.ReadUInt64();
            break;
          }
          case 25: {
            TotalMetricValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Per cluster load stats. Envoy reports these stats a management server in a
  /// :ref:`LoadStatsRequest&lt;envoy_api_msg_load_stats.LoadStatsRequest>`
  /// [#not-implemented-hide:] Not configuration. TBD how to doc proto APIs.
  /// </summary>
  public sealed partial class ClusterStats : pb::IMessage<ClusterStats> {
    private static readonly pb::MessageParser<ClusterStats> _parser = new pb::MessageParser<ClusterStats>(() => new ClusterStats());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClusterStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.Endpoint.LoadReportReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterStats(ClusterStats other) : this() {
      clusterName_ = other.clusterName_;
      upstreamLocalityStats_ = other.upstreamLocalityStats_.Clone();
      totalDroppedRequests_ = other.totalDroppedRequests_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterStats Clone() {
      return new ClusterStats(this);
    }

    /// <summary>Field number for the "cluster_name" field.</summary>
    public const int ClusterNameFieldNumber = 1;
    private string clusterName_ = "";
    /// <summary>
    /// The name of the cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterName {
      get { return clusterName_; }
      set {
        clusterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "upstream_locality_stats" field.</summary>
    public const int UpstreamLocalityStatsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats> _repeated_upstreamLocalityStats_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats> upstreamLocalityStats_ = new pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats>();
    /// <summary>
    /// Need at least one.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Endpoint.UpstreamLocalityStats> UpstreamLocalityStats {
      get { return upstreamLocalityStats_; }
    }

    /// <summary>Field number for the "total_dropped_requests" field.</summary>
    public const int TotalDroppedRequestsFieldNumber = 3;
    private ulong totalDroppedRequests_;
    /// <summary>
    /// Cluster-level stats such as total_successful_requests may be computed by
    /// summing upstream_locality_stats. In addition, below there are additional
    /// cluster-wide stats. The following total_requests equality holds at the
    /// cluster-level:
    ///
    /// .. code-block:: none
    ///
    ///   sum_locality(total_successful_requests) + sum_locality(total_requests_in_progress) +
    ///     sum_locality(total_error_requests) + total_dropped_requests`
    ///
    /// The total number of dropped requests. This covers requests
    /// deliberately dropped by the drop_overload policy and circuit breaking.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TotalDroppedRequests {
      get { return totalDroppedRequests_; }
      set {
        totalDroppedRequests_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClusterStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClusterStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterName != other.ClusterName) return false;
      if(!upstreamLocalityStats_.Equals(other.upstreamLocalityStats_)) return false;
      if (TotalDroppedRequests != other.TotalDroppedRequests) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClusterName.Length != 0) hash ^= ClusterName.GetHashCode();
      hash ^= upstreamLocalityStats_.GetHashCode();
      if (TotalDroppedRequests != 0UL) hash ^= TotalDroppedRequests.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterName);
      }
      upstreamLocalityStats_.WriteTo(output, _repeated_upstreamLocalityStats_codec);
      if (TotalDroppedRequests != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TotalDroppedRequests);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClusterName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterName);
      }
      size += upstreamLocalityStats_.CalculateSize(_repeated_upstreamLocalityStats_codec);
      if (TotalDroppedRequests != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalDroppedRequests);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClusterStats other) {
      if (other == null) {
        return;
      }
      if (other.ClusterName.Length != 0) {
        ClusterName = other.ClusterName;
      }
      upstreamLocalityStats_.Add(other.upstreamLocalityStats_);
      if (other.TotalDroppedRequests != 0UL) {
        TotalDroppedRequests = other.TotalDroppedRequests;
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
            ClusterName = input.ReadString();
            break;
          }
          case 18: {
            upstreamLocalityStats_.AddEntriesFrom(input, _repeated_upstreamLocalityStats_codec);
            break;
          }
          case 24: {
            TotalDroppedRequests = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
