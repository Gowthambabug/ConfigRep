// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> List all existing remote device adapters. </summary>
    public partial class RemoteDeviceAdapterListRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of RemoteDeviceAdapterListRequest. </summary>
        public RemoteDeviceAdapterListRequest()
        {
            MethodName = "remoteDeviceAdapterList";
        }

        /// <summary> Initializes a new instance of RemoteDeviceAdapterListRequest. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        internal RemoteDeviceAdapterListRequest(string methodName, string apiVersion) : base(methodName, apiVersion)
        {
            MethodName = methodName ?? "remoteDeviceAdapterList";
        }
    }
}