// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/app_campaign_bidding_strategy_goal_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/app_campaign_bidding_strategy_goal_type.proto</summary>
  public static partial class AppCampaignBiddingStrategyGoalTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/app_campaign_bidding_strategy_goal_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppCampaignBiddingStrategyGoalTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9hcHBfY2FtcGFpZ25f",
            "YmlkZGluZ19zdHJhdGVneV9nb2FsX3R5cGUucHJvdG8SHWdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYyLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvIq8CCiZBcHBDYW1wYWlnbkJpZGRpbmdTdHJhdGVneUdvYWxUeXBlRW51",
            "bSKEAgoiQXBwQ2FtcGFpZ25CaWRkaW5nU3RyYXRlZ3lHb2FsVHlwZRIPCgtV",
            "TlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIpCiVPUFRJTUlaRV9JTlNUQUxM",
            "U19UQVJHRVRfSU5TVEFMTF9DT1NUEAISMwovT1BUSU1JWkVfSU5fQVBQX0NP",
            "TlZFUlNJT05TX1RBUkdFVF9JTlNUQUxMX0NPU1QQAxI2CjJPUFRJTUlaRV9J",
            "Tl9BUFBfQ09OVkVSU0lPTlNfVEFSR0VUX0NPTlZFUlNJT05fQ09TVBAEEigK",
            "JE9QVElNSVpFX1JFVFVSTl9PTl9BRFZFUlRJU0lOR19TUEVORBAFQvwBCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCJ0FwcENhbXBhaWdu",
            "QmlkZGluZ1N0cmF0ZWd5R29hbFR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZW51",
            "bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FbnVt",
            "c8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVudW1z6gIhR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.AppCampaignBiddingStrategyGoalTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.AppCampaignBiddingStrategyGoalTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.AppCampaignBiddingStrategyGoalTypeEnum.Types.AppCampaignBiddingStrategyGoalType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing goal towards which the bidding strategy of an
  /// app campaign should optimize for.
  /// </summary>
  public sealed partial class AppCampaignBiddingStrategyGoalTypeEnum : pb::IMessage<AppCampaignBiddingStrategyGoalTypeEnum> {
    private static readonly pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum> _parser = new pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum>(() => new AppCampaignBiddingStrategyGoalTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.AppCampaignBiddingStrategyGoalTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignBiddingStrategyGoalTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignBiddingStrategyGoalTypeEnum(AppCampaignBiddingStrategyGoalTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignBiddingStrategyGoalTypeEnum Clone() {
      return new AppCampaignBiddingStrategyGoalTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppCampaignBiddingStrategyGoalTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppCampaignBiddingStrategyGoalTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppCampaignBiddingStrategyGoalTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AppCampaignBiddingStrategyGoalTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Goal type of App campaign BiddingStrategy.
      /// </summary>
      public enum AppCampaignBiddingStrategyGoalType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Aim to maximize the number of app installs. The cpa bid is the
        /// target cost per install.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_INSTALLS_TARGET_INSTALL_COST")] OptimizeInstallsTargetInstallCost = 2,
        /// <summary>
        /// Aim to maximize the long term number of selected in-app conversions from
        /// app installs. The cpa bid is the target cost per install.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_IN_APP_CONVERSIONS_TARGET_INSTALL_COST")] OptimizeInAppConversionsTargetInstallCost = 3,
        /// <summary>
        /// Aim to maximize the long term number of selected in-app conversions from
        /// app installs. The cpa bid is the target cost per in-app conversion. Note
        /// that the actual cpa may seem higher than the target cpa at first, since
        /// the long term conversions haven’t happened yet.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_IN_APP_CONVERSIONS_TARGET_CONVERSION_COST")] OptimizeInAppConversionsTargetConversionCost = 4,
        /// <summary>
        /// Aim to maximize all conversions' value, i.e. install + selected in-app
        /// conversions while achieving or exceeding target return on advertising
        /// spend.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_RETURN_ON_ADVERTISING_SPEND")] OptimizeReturnOnAdvertisingSpend = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
