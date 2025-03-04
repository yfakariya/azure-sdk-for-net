// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdatePrivateEndpointUpdate : IUtf8JsonSerializable, IJsonModel<DeviceUpdatePrivateEndpointUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdatePrivateEndpointUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceUpdatePrivateEndpointUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ImmutableSubscriptionId))
            {
                writer.WritePropertyName("immutableSubscriptionId"u8);
                writer.WriteStringValue(ImmutableSubscriptionId);
            }
            if (Optional.IsDefined(ImmutableResourceId))
            {
                writer.WritePropertyName("immutableResourceId"u8);
                writer.WriteStringValue(ImmutableResourceId);
            }
            if (Optional.IsDefined(VnetTrafficTag))
            {
                writer.WritePropertyName("vnetTrafficTag"u8);
                writer.WriteStringValue(VnetTrafficTag);
            }
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

        DeviceUpdatePrivateEndpointUpdate IJsonModel<DeviceUpdatePrivateEndpointUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdatePrivateEndpointUpdate(document.RootElement, options);
        }

        internal static DeviceUpdatePrivateEndpointUpdate DeserializeDeviceUpdatePrivateEndpointUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<AzureLocation> location = default;
            Optional<string> immutableSubscriptionId = default;
            Optional<ResourceIdentifier> immutableResourceId = default;
            Optional<string> vnetTrafficTag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutableSubscriptionId"u8))
                {
                    immutableSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("immutableResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    immutableResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetTrafficTag"u8))
                {
                    vnetTrafficTag = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceUpdatePrivateEndpointUpdate(id.Value, Optional.ToNullable(location), immutableSubscriptionId.Value, immutableResourceId.Value, vnetTrafficTag.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdatePrivateEndpointUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointUpdate)} does not support '{options.Format}' format.");
            }
        }

        DeviceUpdatePrivateEndpointUpdate IPersistableModel<DeviceUpdatePrivateEndpointUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateEndpointUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceUpdatePrivateEndpointUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateEndpointUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdatePrivateEndpointUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
