// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricPortCondition : IUtf8JsonSerializable, IJsonModel<NetworkFabricPortCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricPortCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFabricPortCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricPortCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricPortCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PortType))
            {
                writer.WritePropertyName("portType"u8);
                writer.WriteStringValue(PortType.Value.ToString());
            }
            writer.WritePropertyName("layer4Protocol"u8);
            writer.WriteStringValue(Layer4Protocol.ToString());
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PortGroupNames))
            {
                writer.WritePropertyName("portGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in PortGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        NetworkFabricPortCondition IJsonModel<NetworkFabricPortCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricPortCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricPortCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricPortCondition(document.RootElement, options);
        }

        internal static NetworkFabricPortCondition DeserializeNetworkFabricPortCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkFabricPortType> portType = default;
            Layer4Protocol layer4Protocol = default;
            Optional<IList<string>> ports = default;
            Optional<IList<string>> portGroupNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portType = new NetworkFabricPortType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layer4Protocol"u8))
                {
                    layer4Protocol = new Layer4Protocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("portGroupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    portGroupNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFabricPortCondition(Optional.ToNullable(portType), layer4Protocol, Optional.ToList(ports), Optional.ToList(portGroupNames), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricPortCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricPortCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricPortCondition)} does not support '{options.Format}' format.");
            }
        }

        NetworkFabricPortCondition IPersistableModel<NetworkFabricPortCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricPortCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricPortCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricPortCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricPortCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
