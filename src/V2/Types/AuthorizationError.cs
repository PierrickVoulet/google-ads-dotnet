// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/authorization_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/authorization_error.proto</summary>
  public static partial class AuthorizationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/authorization_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthorizationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvYXV0aG9yaXphdGlv",
            "bl9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpoDChZBdXRob3JpemF0",
            "aW9uRXJyb3JFbnVtIv8CChJBdXRob3JpemF0aW9uRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESGgoWVVNFUl9QRVJNSVNTSU9OX0RFTklF",
            "RBACEiMKH0RFVkVMT1BFUl9UT0tFTl9OT1RfV0hJVEVMSVNURUQQAxIeChpE",
            "RVZFTE9QRVJfVE9LRU5fUFJPSElCSVRFRBAEEhQKEFBST0pFQ1RfRElTQUJM",
            "RUQQBRIXChNBVVRIT1JJWkFUSU9OX0VSUk9SEAYSGAoUQUNUSU9OX05PVF9Q",
            "RVJNSVRURUQQBxIVChFJTkNPTVBMRVRFX1NJR05VUBAIEhgKFENVU1RPTUVS",
            "X05PVF9FTkFCTEVEEBgSDwoLTUlTU0lOR19UT1MQCRIgChxERVZFTE9QRVJf",
            "VE9LRU5fTk9UX0FQUFJPVkVEEAoSPQo5SU5WQUxJRF9MT0dJTl9DVVNUT01F",
            "Ul9JRF9TRVJWSU5HX0NVU1RPTUVSX0lEX0NPTUJJTkFUSU9OEAtC8gEKImNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lcnJvcnNCF0F1dGhvcml6YXRp",
            "b25FcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnM7ZXJyb3JzogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRXJyb3JzygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjJcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjI6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.AuthorizationErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.AuthorizationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.AuthorizationErrorEnum.Types.AuthorizationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible authorization errors.
  /// </summary>
  public sealed partial class AuthorizationErrorEnum : pb::IMessage<AuthorizationErrorEnum> {
    private static readonly pb::MessageParser<AuthorizationErrorEnum> _parser = new pb::MessageParser<AuthorizationErrorEnum>(() => new AuthorizationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthorizationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.AuthorizationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationErrorEnum(AuthorizationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorizationErrorEnum Clone() {
      return new AuthorizationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthorizationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthorizationErrorEnum other) {
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
    public void MergeFrom(AuthorizationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AuthorizationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible authorization errors.
      /// </summary>
      public enum AuthorizationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// User doesn't have permission to access customer. Note: If you're
        /// accessing a client customer, the manager's customer ID must be set in the
        /// `login-customer-id` header. Learn more at
        /// https://developers.google.com/google-ads/api/docs/concepts/call-structure#cid
        /// </summary>
        [pbr::OriginalName("USER_PERMISSION_DENIED")] UserPermissionDenied = 2,
        /// <summary>
        /// The developer token is not whitelisted.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_NOT_WHITELISTED")] DeveloperTokenNotWhitelisted = 3,
        /// <summary>
        /// The developer token is not allowed with the project sent in the request.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_PROHIBITED")] DeveloperTokenProhibited = 4,
        /// <summary>
        /// The Google Cloud project sent in the request does not have permission to
        /// access the api.
        /// </summary>
        [pbr::OriginalName("PROJECT_DISABLED")] ProjectDisabled = 5,
        /// <summary>
        /// Authorization of the client failed.
        /// </summary>
        [pbr::OriginalName("AUTHORIZATION_ERROR")] AuthorizationError = 6,
        /// <summary>
        /// The user does not have permission to perform this action
        /// (e.g., ADD, UPDATE, REMOVE) on the resource or call a method.
        /// </summary>
        [pbr::OriginalName("ACTION_NOT_PERMITTED")] ActionNotPermitted = 7,
        /// <summary>
        /// Signup not complete.
        /// </summary>
        [pbr::OriginalName("INCOMPLETE_SIGNUP")] IncompleteSignup = 8,
        /// <summary>
        /// The customer can't be used because it isn't enabled.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ENABLED")] CustomerNotEnabled = 24,
        /// <summary>
        /// The developer must sign the terms of service. They can be found here:
        /// ads.google.com/aw/apicenter
        /// </summary>
        [pbr::OriginalName("MISSING_TOS")] MissingTos = 9,
        /// <summary>
        /// The developer token is not approved. Non-approved developer tokens can
        /// only be used with test accounts.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_NOT_APPROVED")] DeveloperTokenNotApproved = 10,
        /// <summary>
        /// The login customer specified does not have access to the account
        /// specified, so the request is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_LOGIN_CUSTOMER_ID_SERVING_CUSTOMER_ID_COMBINATION")] InvalidLoginCustomerIdServingCustomerIdCombination = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
