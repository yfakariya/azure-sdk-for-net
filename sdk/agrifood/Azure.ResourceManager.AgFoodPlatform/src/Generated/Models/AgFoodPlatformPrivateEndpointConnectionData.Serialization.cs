// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class AgFoodPlatformPrivateEndpointConnectionData : IUtf8JsonSerializable, IJsonModel<AgFoodPlatformPrivateEndpointConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgFoodPlatformPrivateEndpointConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgFoodPlatformPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgFoodPlatformPrivateEndpointConnectionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(ConnectionState);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        AgFoodPlatformPrivateEndpointConnectionData IJsonModel<AgFoodPlatformPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgFoodPlatformPrivateEndpointConnectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgFoodPlatformPrivateEndpointConnectionData(document.RootElement, options);
        }

        internal static AgFoodPlatformPrivateEndpointConnectionData DeserializeAgFoodPlatformPrivateEndpointConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SubResource> privateEndpoint = default;
            Optional<AgFoodPlatformPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            Optional<AgFoodPlatformPrivateEndpointConnectionProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceConnectionState = AgFoodPlatformPrivateLinkServiceConnectionState.DeserializeAgFoodPlatformPrivateLinkServiceConnectionState(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AgFoodPlatformPrivateEndpointConnectionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgFoodPlatformPrivateEndpointConnectionData(id, name, type, systemData.Value, privateEndpoint, privateLinkServiceConnectionState.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgFoodPlatformPrivateEndpointConnectionData)} does not support '{options.Format}' format.");
            }
        }

        AgFoodPlatformPrivateEndpointConnectionData IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgFoodPlatformPrivateEndpointConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgFoodPlatformPrivateEndpointConnectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgFoodPlatformPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
