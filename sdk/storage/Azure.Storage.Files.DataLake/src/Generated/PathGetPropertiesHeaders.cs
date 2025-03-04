// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class PathGetPropertiesHeaders
    {
        private readonly Response _response;
        public PathGetPropertiesHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates that the service supports requests for partial file content. </summary>
        public string AcceptRanges => _response.Headers.TryGetValue("Accept-Ranges", out string value) ? value : null;
        /// <summary> If the Cache-Control request header has previously been set for the resource, that value is returned in this header. </summary>
        public string CacheControl => _response.Headers.TryGetValue("Cache-Control", out string value) ? value : null;
        /// <summary> If the Content-Disposition request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentDisposition => _response.Headers.TryGetValue("Content-Disposition", out string value) ? value : null;
        /// <summary> If the Content-Encoding request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentEncoding => _response.Headers.TryGetValue("Content-Encoding", out string value) ? value : null;
        /// <summary> If the Content-Language request header has previously been set for the resource, that value is returned in this header. </summary>
        public string ContentLanguage => _response.Headers.TryGetValue("Content-Language", out string value) ? value : null;
        /// <summary> The size of the resource in bytes. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> Indicates the range of bytes returned in the event that the client requested a subset of the file by setting the Range request header. </summary>
        public string ContentRange => _response.Headers.TryGetValue("Content-Range", out string value) ? value : null;
        /// <summary> The content type specified for the resource. If no content type was specified, the default content type is application/octet-stream. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> The MD5 hash of complete file stored in storage. This header is returned only for "GetProperties" operation. If the Content-MD5 header has been set for the file, this response header is returned for GetProperties call so that the client can check for message content integrity. </summary>
        public string ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out string value) ? value : null;
        /// <summary> The data and time the file or directory was last modified.  Write operations on the file or directory update the last modified time. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The type of the resource.  The value may be "file" or "directory".  If not set, the value is "file". </summary>
        public string ResourceType => _response.Headers.TryGetValue("x-ms-resource-type", out string value) ? value : null;
        /// <summary> The user-defined properties associated with the file or directory, in the format of a comma-separated list of name and value pairs "n1=v1, n2=v2, ...", where each value is a base64 encoded string. Note that the string may only contain ASCII characters in the ISO-8859-1 character set. </summary>
        public string Properties => _response.Headers.TryGetValue("x-ms-properties", out string value) ? value : null;
        /// <summary> The owner of the file or directory. Included in the response if Hierarchical Namespace is enabled for the account. </summary>
        public string Owner => _response.Headers.TryGetValue("x-ms-owner", out string value) ? value : null;
        /// <summary> The owning group of the file or directory. Included in the response if Hierarchical Namespace is enabled for the account. </summary>
        public string Group => _response.Headers.TryGetValue("x-ms-group", out string value) ? value : null;
        /// <summary> The POSIX access permissions for the file owner, the file owning group, and others. Included in the response if Hierarchical Namespace is enabled for the account. </summary>
        public string Permissions => _response.Headers.TryGetValue("x-ms-permissions", out string value) ? value : null;
        /// <summary> The POSIX access control list for the file or directory.  Included in the response only if the action is "getAccessControl" and Hierarchical Namespace is enabled for the account. </summary>
        public string ACL => _response.Headers.TryGetValue("x-ms-acl", out string value) ? value : null;
        /// <summary> When a resource is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public string LeaseDuration => _response.Headers.TryGetValue("x-ms-lease-duration", out string value) ? value : null;
        /// <summary> Lease state of the resource. </summary>
        public string LeaseState => _response.Headers.TryGetValue("x-ms-lease-state", out string value) ? value : null;
        /// <summary> The lease status of the resource. </summary>
        public string LeaseStatus => _response.Headers.TryGetValue("x-ms-lease-status", out string value) ? value : null;
    }
}
