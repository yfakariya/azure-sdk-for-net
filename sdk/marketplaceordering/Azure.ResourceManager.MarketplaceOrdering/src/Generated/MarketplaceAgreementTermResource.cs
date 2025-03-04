// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MarketplaceOrdering.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    /// <summary>
    /// A Class representing a MarketplaceAgreementTerm along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MarketplaceAgreementTermResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMarketplaceAgreementTermResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetMarketplaceAgreementTerm method.
    /// </summary>
    public partial class MarketplaceAgreementTermResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MarketplaceAgreementTermResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="offerType"> The offerType. </param>
        /// <param name="publisherId"> The publisherId. </param>
        /// <param name="offerId"> The offerId. </param>
        /// <param name="planId"> The planId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AgreementOfferType offerType, string publisherId, string offerId, string planId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics;
        private readonly MarketplaceAgreementsRestOperations _marketplaceAgreementTermMarketplaceAgreementsRestClient;
        private readonly MarketplaceAgreementTermData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MarketplaceOrdering/offerTypes/publishers/offers/plans/agreements";

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementTermResource"/> class for mocking. </summary>
        protected MarketplaceAgreementTermResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementTermResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MarketplaceAgreementTermResource(ArmClient client, MarketplaceAgreementTermData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementTermResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MarketplaceAgreementTermResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MarketplaceOrdering", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string marketplaceAgreementTermMarketplaceAgreementsApiVersion);
            _marketplaceAgreementTermMarketplaceAgreementsRestClient = new MarketplaceAgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceAgreementTermMarketplaceAgreementsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MarketplaceAgreementTermData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceAgreementTermResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermResource.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceAgreementTermResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermResource.Get");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementTermResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Save marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MarketplaceAgreementTermResource>> UpdateAsync(WaitUntil waitUntil, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermResource.Update");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementTermMarketplaceAgreementsRestClient.CreateAsync(Id.SubscriptionId, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceOrderingArmOperation<MarketplaceAgreementTermResource>(Response.FromValue(new MarketplaceAgreementTermResource(Client, response), response.GetRawResponse()));
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
        /// Save marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Marketplace Terms operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MarketplaceAgreementTermResource> Update(WaitUntil waitUntil, MarketplaceAgreementTermData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _marketplaceAgreementTermMarketplaceAgreementsClientDiagnostics.CreateScope("MarketplaceAgreementTermResource.Update");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementTermMarketplaceAgreementsRestClient.Create(Id.SubscriptionId, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new MarketplaceOrderingArmOperation<MarketplaceAgreementTermResource>(Response.FromValue(new MarketplaceAgreementTermResource(Client, response), response.GetRawResponse()));
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
    }
}
