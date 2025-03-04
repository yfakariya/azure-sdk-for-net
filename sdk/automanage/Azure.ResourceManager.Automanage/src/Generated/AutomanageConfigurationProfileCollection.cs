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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageConfigurationProfileResource"/> and their operations.
    /// Each <see cref="AutomanageConfigurationProfileResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AutomanageConfigurationProfileCollection"/> instance call the GetAutomanageConfigurationProfiles method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AutomanageConfigurationProfileCollection : ArmCollection, IEnumerable<AutomanageConfigurationProfileResource>, IAsyncEnumerable<AutomanageConfigurationProfileResource>
    {
        private readonly ClientDiagnostics _automanageConfigurationProfileConfigurationProfilesClientDiagnostics;
        private readonly ConfigurationProfilesRestOperations _automanageConfigurationProfileConfigurationProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageConfigurationProfileCollection"/> class for mocking. </summary>
        protected AutomanageConfigurationProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageConfigurationProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageConfigurationProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageConfigurationProfileConfigurationProfilesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageConfigurationProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageConfigurationProfileResource.ResourceType, out string automanageConfigurationProfileConfigurationProfilesApiVersion);
            _automanageConfigurationProfileConfigurationProfilesRestClient = new ConfigurationProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageConfigurationProfileConfigurationProfilesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileName"> Name of the configuration profile. </param>
        /// <param name="data"> Parameters supplied to create or update configuration profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageConfigurationProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationProfileName, AutomanageConfigurationProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileConfigurationProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageConfigurationProfileResource>(Response.FromValue(new AutomanageConfigurationProfileResource(Client, response), response.GetRawResponse()));
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
        /// Creates a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileName"> Name of the configuration profile. </param>
        /// <param name="data"> Parameters supplied to create or update configuration profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageConfigurationProfileResource> CreateOrUpdate(WaitUntil waitUntil, string configurationProfileName, AutomanageConfigurationProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileConfigurationProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageConfigurationProfileResource>(Response.FromValue(new AutomanageConfigurationProfileResource(Client, response), response.GetRawResponse()));
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
        /// Get information about a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual async Task<Response<AutomanageConfigurationProfileResource>> GetAsync(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileConfigurationProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual Response<AutomanageConfigurationProfileResource> Get(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileConfigurationProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a given resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageConfigurationProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageConfigurationProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageConfigurationProfileConfigurationProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageConfigurationProfileResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), _automanageConfigurationProfileConfigurationProfilesClientDiagnostics, Pipeline, "AutomanageConfigurationProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a given resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageConfigurationProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageConfigurationProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageConfigurationProfileConfigurationProfilesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageConfigurationProfileResource(Client, AutomanageConfigurationProfileData.DeserializeAutomanageConfigurationProfileData(e)), _automanageConfigurationProfileConfigurationProfilesClientDiagnostics, Pipeline, "AutomanageConfigurationProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileConfigurationProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileConfigurationProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomanageConfigurationProfileResource>> GetIfExistsAsync(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automanageConfigurationProfileConfigurationProfilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageConfigurationProfileResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automanage/configurationProfiles/{configurationProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageConfigurationProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileName"> The configuration profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileName"/> is null. </exception>
        public virtual NullableResponse<AutomanageConfigurationProfileResource> GetIfExists(string configurationProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileName, nameof(configurationProfileName));

            using var scope = _automanageConfigurationProfileConfigurationProfilesClientDiagnostics.CreateScope("AutomanageConfigurationProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automanageConfigurationProfileConfigurationProfilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, configurationProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageConfigurationProfileResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageConfigurationProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageConfigurationProfileResource> IEnumerable<AutomanageConfigurationProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageConfigurationProfileResource> IAsyncEnumerable<AutomanageConfigurationProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
