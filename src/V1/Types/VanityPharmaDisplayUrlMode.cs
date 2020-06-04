// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/vanity_pharma_display_url_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/vanity_pharma_display_url_mode.proto</summary>
  public static partial class VanityPharmaDisplayUrlModeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/vanity_pharma_display_url_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VanityPharmaDisplayUrlModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy92YW5pdHlfcGhhcm1h",
            "X2Rpc3BsYXlfdXJsX21vZGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpMBCh5W",
            "YW5pdHlQaGFybWFEaXNwbGF5VXJsTW9kZUVudW0icQoaVmFuaXR5UGhhcm1h",
            "RGlzcGxheVVybE1vZGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "HAoYTUFOVUZBQ1RVUkVSX1dFQlNJVEVfVVJMEAISFwoTV0VCU0lURV9ERVND",
            "UklQVElPThADQvQBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51",
            "bXNCH1Zhbml0eVBoYXJtYURpc3BsYXlVcmxNb2RlUHJvdG9QAVpCZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YxL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFbnVtc+oCIUdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaDisplayUrlModeEnum), global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaDisplayUrlModeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaDisplayUrlModeEnum.Types.VanityPharmaDisplayUrlMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The display mode for vanity pharma URLs.
  /// </summary>
  public sealed partial class VanityPharmaDisplayUrlModeEnum : pb::IMessage<VanityPharmaDisplayUrlModeEnum> {
    private static readonly pb::MessageParser<VanityPharmaDisplayUrlModeEnum> _parser = new pb::MessageParser<VanityPharmaDisplayUrlModeEnum>(() => new VanityPharmaDisplayUrlModeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VanityPharmaDisplayUrlModeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.VanityPharmaDisplayUrlModeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaDisplayUrlModeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaDisplayUrlModeEnum(VanityPharmaDisplayUrlModeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VanityPharmaDisplayUrlModeEnum Clone() {
      return new VanityPharmaDisplayUrlModeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VanityPharmaDisplayUrlModeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VanityPharmaDisplayUrlModeEnum other) {
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
    public void MergeFrom(VanityPharmaDisplayUrlModeEnum other) {
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
    /// <summary>Container for nested types declared in the VanityPharmaDisplayUrlModeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible display modes for vanity pharma URLs.
      /// </summary>
      public enum VanityPharmaDisplayUrlMode {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Replace vanity pharma URL with manufacturer website url.
        /// </summary>
        [pbr::OriginalName("MANUFACTURER_WEBSITE_URL")] ManufacturerWebsiteUrl = 2,
        /// <summary>
        /// Replace vanity pharma URL with description of the website.
        /// </summary>
        [pbr::OriginalName("WEBSITE_DESCRIPTION")] WebsiteDescription = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
