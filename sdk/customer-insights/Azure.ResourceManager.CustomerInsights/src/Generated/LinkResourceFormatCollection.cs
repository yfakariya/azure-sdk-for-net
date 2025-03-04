// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="LinkResourceFormatResource"/> and their operations.
    /// Each <see cref="LinkResourceFormatResource"/> in the collection will belong to the same instance of <see cref="HubResource"/>.
    /// To get a <see cref="LinkResourceFormatCollection"/> instance call the GetLinkResourceFormats method from an instance of <see cref="HubResource"/>.
    /// </summary>
    public partial class LinkResourceFormatCollection : ArmCollection, IEnumerable<LinkResourceFormatResource>, IAsyncEnumerable<LinkResourceFormatResource>
    {
        private readonly ClientDiagnostics _linkResourceFormatLinksClientDiagnostics;
        private readonly LinksRestOperations _linkResourceFormatLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="LinkResourceFormatCollection"/> class for mocking. </summary>
        protected LinkResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LinkResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LinkResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _linkResourceFormatLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", LinkResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LinkResourceFormatResource.ResourceType, out string linkResourceFormatLinksApiVersion);
            _linkResourceFormatLinksRestClient = new LinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, linkResourceFormatLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a link or updates an existing link in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Link operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LinkResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkName, LinkResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _linkResourceFormatLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<LinkResourceFormatResource>(new LinkResourceFormatOperationSource(Client), _linkResourceFormatLinksClientDiagnostics, Pipeline, _linkResourceFormatLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a link or updates an existing link in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Link operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LinkResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string linkName, LinkResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _linkResourceFormatLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<LinkResourceFormatResource>(new LinkResourceFormatOperationSource(Client), _linkResourceFormatLinksClientDiagnostics, Pipeline, _linkResourceFormatLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a link in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<LinkResourceFormatResource>> GetAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _linkResourceFormatLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a link in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<LinkResourceFormatResource> Get(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _linkResourceFormatLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the links in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_ListByHub</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LinkResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LinkResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _linkResourceFormatLinksRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _linkResourceFormatLinksRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LinkResourceFormatResource(Client, LinkResourceFormatData.DeserializeLinkResourceFormatData(e)), _linkResourceFormatLinksClientDiagnostics, Pipeline, "LinkResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the links in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_ListByHub</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LinkResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LinkResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _linkResourceFormatLinksRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _linkResourceFormatLinksRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LinkResourceFormatResource(Client, LinkResourceFormatData.DeserializeLinkResourceFormatData(e)), _linkResourceFormatLinksClientDiagnostics, Pipeline, "LinkResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _linkResourceFormatLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _linkResourceFormatLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<NullableResponse<LinkResourceFormatResource>> GetIfExistsAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _linkResourceFormatLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LinkResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new LinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Links_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LinkResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual NullableResponse<LinkResourceFormatResource> GetIfExists(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _linkResourceFormatLinksClientDiagnostics.CreateScope("LinkResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _linkResourceFormatLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LinkResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new LinkResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LinkResourceFormatResource> IEnumerable<LinkResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LinkResourceFormatResource> IAsyncEnumerable<LinkResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
