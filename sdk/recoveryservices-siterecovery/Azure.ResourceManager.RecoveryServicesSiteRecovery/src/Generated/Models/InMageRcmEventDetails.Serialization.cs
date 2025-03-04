// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmEventDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmEventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmEventDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmEventDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmEventDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProtectedItemName))
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
            }
            if (options.Format != "W" && Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestAgentVersion))
            {
                writer.WritePropertyName("latestAgentVersion"u8);
                writer.WriteStringValue(LatestAgentVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricName))
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName);
            }
            if (options.Format != "W" && Optional.IsDefined(ApplianceName))
            {
                writer.WritePropertyName("applianceName"u8);
                writer.WriteStringValue(ApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType"u8);
                writer.WriteStringValue(ServerType);
            }
            if (options.Format != "W" && Optional.IsDefined(ComponentDisplayName))
            {
                writer.WritePropertyName("componentDisplayName"u8);
                writer.WriteStringValue(ComponentDisplayName);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InMageRcmEventDetails IJsonModel<InMageRcmEventDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmEventDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmEventDetails(document.RootElement, options);
        }

        internal static InMageRcmEventDetails DeserializeInMageRcmEventDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protectedItemName = default;
            Optional<string> vmName = default;
            Optional<string> latestAgentVersion = default;
            Optional<ResourceIdentifier> jobId = default;
            Optional<string> fabricName = default;
            Optional<string> applianceName = default;
            Optional<string> serverType = default;
            Optional<string> componentDisplayName = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestAgentVersion"u8))
                {
                    latestAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applianceName"u8))
                {
                    applianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentDisplayName"u8))
                {
                    componentDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmEventDetails(instanceType, serializedAdditionalRawData, protectedItemName.Value, vmName.Value, latestAgentVersion.Value, jobId.Value, fabricName.Value, applianceName.Value, serverType.Value, componentDisplayName.Value);
        }

        BinaryData IPersistableModel<InMageRcmEventDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmEventDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmEventDetails IPersistableModel<InMageRcmEventDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmEventDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmEventDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmEventDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
