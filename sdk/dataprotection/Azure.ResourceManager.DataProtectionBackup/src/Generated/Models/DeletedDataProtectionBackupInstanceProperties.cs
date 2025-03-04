// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Deleted Backup Instance. </summary>
    public partial class DeletedDataProtectionBackupInstanceProperties : DataProtectionBackupInstanceProperties
    {
        /// <summary> Initializes a new instance of <see cref="DeletedDataProtectionBackupInstanceProperties"/>. </summary>
        /// <param name="dataSourceInfo"> Gets or sets the data source information. </param>
        /// <param name="policyInfo"> Gets or sets the policy information. </param>
        /// <param name="objectType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceInfo"/>, <paramref name="policyInfo"/> or <paramref name="objectType"/> is null. </exception>
        public DeletedDataProtectionBackupInstanceProperties(DataSourceInfo dataSourceInfo, BackupInstancePolicyInfo policyInfo, string objectType) : base(dataSourceInfo, policyInfo, objectType)
        {
            Argument.AssertNotNull(dataSourceInfo, nameof(dataSourceInfo));
            Argument.AssertNotNull(policyInfo, nameof(policyInfo));
            Argument.AssertNotNull(objectType, nameof(objectType));
        }

        /// <summary> Initializes a new instance of <see cref="DeletedDataProtectionBackupInstanceProperties"/>. </summary>
        /// <param name="friendlyName"> Gets or sets the Backup Instance friendly name. </param>
        /// <param name="dataSourceInfo"> Gets or sets the data source information. </param>
        /// <param name="dataSourceSetInfo"> Gets or sets the data source set information. </param>
        /// <param name="policyInfo"> Gets or sets the policy information. </param>
        /// <param name="protectionStatus"> Specifies the protection status of the resource. </param>
        /// <param name="currentProtectionState"> Specifies the current protection state of the resource. </param>
        /// <param name="protectionErrorDetails"> Specifies the protection error of the resource. </param>
        /// <param name="provisioningState"> Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed. </param>
        /// <param name="dataSourceAuthCredentials">
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </param>
        /// <param name="validationType"> Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again. </param>
        /// <param name="identityDetails">
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </param>
        /// <param name="objectType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="deletionInfo"> Deletion info of Backup Instance. </param>
        internal DeletedDataProtectionBackupInstanceProperties(string friendlyName, DataSourceInfo dataSourceInfo, DataSourceSetInfo dataSourceSetInfo, BackupInstancePolicyInfo policyInfo, BackupInstanceProtectionStatusDetails protectionStatus, CurrentProtectionState? currentProtectionState, ResponseError protectionErrorDetails, string provisioningState, DataProtectionBackupAuthCredentials dataSourceAuthCredentials, BackupValidationType? validationType, DataProtectionIdentityDetails identityDetails, string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, BackupInstanceDeletionInfo deletionInfo) : base(friendlyName, dataSourceInfo, dataSourceSetInfo, policyInfo, protectionStatus, currentProtectionState, protectionErrorDetails, provisioningState, dataSourceAuthCredentials, validationType, identityDetails, objectType, serializedAdditionalRawData)
        {
            DeletionInfo = deletionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="DeletedDataProtectionBackupInstanceProperties"/> for deserialization. </summary>
        internal DeletedDataProtectionBackupInstanceProperties()
        {
        }

        /// <summary> Deletion info of Backup Instance. </summary>
        public BackupInstanceDeletionInfo DeletionInfo { get; }
    }
}
