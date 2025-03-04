// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The GitHubAccessTokenRequest. </summary>
    public partial class GitHubAccessTokenRequest
    {
        /// <summary> Initializes a new instance of <see cref="GitHubAccessTokenRequest"/>. </summary>
        /// <param name="gitHubClientId"> The GitHub Client Id. </param>
        /// <param name="gitHubAccessCode"> The GitHub Access code. </param>
        /// <param name="gitHubAccessTokenBaseUrl"> The GitHub access token base URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubClientId"/>, <paramref name="gitHubAccessCode"/> or <paramref name="gitHubAccessTokenBaseUrl"/> is null. </exception>
        public GitHubAccessTokenRequest(string gitHubClientId, string gitHubAccessCode, string gitHubAccessTokenBaseUrl)
        {
            Argument.AssertNotNull(gitHubClientId, nameof(gitHubClientId));
            Argument.AssertNotNull(gitHubAccessCode, nameof(gitHubAccessCode));
            Argument.AssertNotNull(gitHubAccessTokenBaseUrl, nameof(gitHubAccessTokenBaseUrl));

            GitHubClientId = gitHubClientId;
            GitHubAccessCode = gitHubAccessCode;
            GitHubAccessTokenBaseUrl = gitHubAccessTokenBaseUrl;
        }

        /// <summary> The GitHub Client Id. </summary>
        public string GitHubClientId { get; }
        /// <summary> The GitHub Access code. </summary>
        public string GitHubAccessCode { get; }
        /// <summary> The GitHub access token base URL. </summary>
        public string GitHubAccessTokenBaseUrl { get; }
    }
}
