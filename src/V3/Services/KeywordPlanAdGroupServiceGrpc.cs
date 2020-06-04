// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/keyword_plan_ad_group_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage Keyword Plan ad groups.
  /// </summary>
  public static partial class KeywordPlanAdGroupService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.KeywordPlanAdGroupService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest> __Marshaller_google_ads_googleads_v3_services_GetKeywordPlanAdGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup> __Marshaller_google_ads_googleads_v3_resources_KeywordPlanAdGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest> __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanAdGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse> __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanAdGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup> __Method_GetKeywordPlanAdGroup = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlanAdGroup",
        __Marshaller_google_ads_googleads_v3_services_GetKeywordPlanAdGroupRequest,
        __Marshaller_google_ads_googleads_v3_resources_KeywordPlanAdGroup);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse> __Method_MutateKeywordPlanAdGroups = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanAdGroups",
        __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanAdGroupsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateKeywordPlanAdGroupsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.KeywordPlanAdGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanAdGroupService</summary>
    [grpc::BindServiceMethod(typeof(KeywordPlanAdGroupService), "BindService")]
    public abstract partial class KeywordPlanAdGroupServiceBase
    {
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanAdGroupService</summary>
    public partial class KeywordPlanAdGroupServiceClient : grpc::ClientBase<KeywordPlanAdGroupServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanAdGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public KeywordPlanAdGroupServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanAdGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public KeywordPlanAdGroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected KeywordPlanAdGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected KeywordPlanAdGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanAdGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlanAdGroup, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroupAsync(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanAdGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroupAsync(global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlanAdGroup, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanAdGroups(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanAdGroups, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanAdGroupsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanAdGroups, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override KeywordPlanAdGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanAdGroupServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KeywordPlanAdGroupServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlanAdGroup, serviceImpl.GetKeywordPlanAdGroup)
          .AddMethod(__Method_MutateKeywordPlanAdGroups, serviceImpl.MutateKeywordPlanAdGroups).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanAdGroupServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetKeywordPlanAdGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.GetKeywordPlanAdGroupRequest, global::Google.Ads.GoogleAds.V3.Resources.KeywordPlanAdGroup>(serviceImpl.GetKeywordPlanAdGroup));
      serviceBinder.AddMethod(__Method_MutateKeywordPlanAdGroups, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateKeywordPlanAdGroupsResponse>(serviceImpl.MutateKeywordPlanAdGroups));
    }

  }
}
#endregion
