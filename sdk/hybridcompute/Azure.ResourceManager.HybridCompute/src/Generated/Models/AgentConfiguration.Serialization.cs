// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AgentConfiguration : IUtf8JsonSerializable, IJsonModel<AgentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProxyUri))
            {
                writer.WritePropertyName("proxyUrl"u8);
                writer.WriteStringValue(ProxyUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IncomingConnectionsPorts))
            {
                writer.WritePropertyName("incomingConnectionsPorts"u8);
                writer.WriteStartArray();
                foreach (var item in IncomingConnectionsPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtensionsAllowList))
            {
                writer.WritePropertyName("extensionsAllowList"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionsAllowList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtensionsBlockList))
            {
                writer.WritePropertyName("extensionsBlockList"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionsBlockList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProxyBypass))
            {
                writer.WritePropertyName("proxyBypass"u8);
                writer.WriteStartArray();
                foreach (var item in ProxyBypass)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionsEnabled))
            {
                writer.WritePropertyName("extensionsEnabled"u8);
                writer.WriteStringValue(ExtensionsEnabled);
            }
            if (options.Format != "W" && Optional.IsDefined(GuestConfigurationEnabled))
            {
                writer.WritePropertyName("guestConfigurationEnabled"u8);
                writer.WriteStringValue(GuestConfigurationEnabled);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigMode))
            {
                writer.WritePropertyName("configMode"u8);
                writer.WriteStringValue(ConfigMode.Value.ToString());
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

        AgentConfiguration IJsonModel<AgentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentConfiguration(document.RootElement, options);
        }

        internal static AgentConfiguration DeserializeAgentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> proxyUrl = default;
            Optional<IReadOnlyList<string>> incomingConnectionsPorts = default;
            Optional<IReadOnlyList<HybridComputeConfigurationExtension>> extensionsAllowList = default;
            Optional<IReadOnlyList<HybridComputeConfigurationExtension>> extensionsBlockList = default;
            Optional<IReadOnlyList<string>> proxyBypass = default;
            Optional<string> extensionsEnabled = default;
            Optional<string> guestConfigurationEnabled = default;
            Optional<AgentConfigurationMode> configMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proxyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    proxyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incomingConnectionsPorts"u8))
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
                    incomingConnectionsPorts = array;
                    continue;
                }
                if (property.NameEquals("extensionsAllowList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConfigurationExtension> array = new List<HybridComputeConfigurationExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConfigurationExtension.DeserializeHybridComputeConfigurationExtension(item));
                    }
                    extensionsAllowList = array;
                    continue;
                }
                if (property.NameEquals("extensionsBlockList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConfigurationExtension> array = new List<HybridComputeConfigurationExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConfigurationExtension.DeserializeHybridComputeConfigurationExtension(item));
                    }
                    extensionsBlockList = array;
                    continue;
                }
                if (property.NameEquals("proxyBypass"u8))
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
                    proxyBypass = array;
                    continue;
                }
                if (property.NameEquals("extensionsEnabled"u8))
                {
                    extensionsEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guestConfigurationEnabled"u8))
                {
                    guestConfigurationEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configMode = new AgentConfigurationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgentConfiguration(proxyUrl.Value, Optional.ToList(incomingConnectionsPorts), Optional.ToList(extensionsAllowList), Optional.ToList(extensionsBlockList), Optional.ToList(proxyBypass), extensionsEnabled.Value, guestConfigurationEnabled.Value, Optional.ToNullable(configMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AgentConfiguration IPersistableModel<AgentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
