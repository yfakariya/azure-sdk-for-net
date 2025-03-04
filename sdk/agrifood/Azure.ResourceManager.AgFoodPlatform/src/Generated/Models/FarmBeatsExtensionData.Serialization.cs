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

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class FarmBeatsExtensionData : IUtf8JsonSerializable, IJsonModel<FarmBeatsExtensionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FarmBeatsExtensionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FarmBeatsExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FarmBeatsExtensionData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(FarmBeatsExtensionId))
            {
                writer.WritePropertyName("farmBeatsExtensionId"u8);
                writer.WriteStringValue(FarmBeatsExtensionId);
            }
            if (options.Format != "W" && Optional.IsDefined(FarmBeatsExtensionName))
            {
                writer.WritePropertyName("farmBeatsExtensionName"u8);
                writer.WriteStringValue(FarmBeatsExtensionName);
            }
            if (options.Format != "W" && Optional.IsDefined(FarmBeatsExtensionVersion))
            {
                writer.WritePropertyName("farmBeatsExtensionVersion"u8);
                writer.WriteStringValue(FarmBeatsExtensionVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionCategory))
            {
                writer.WritePropertyName("extensionCategory"u8);
                writer.WriteStringValue(ExtensionCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionAuthLink))
            {
                writer.WritePropertyName("extensionAuthLink"u8);
                writer.WriteStringValue(ExtensionAuthLink);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionApiDocsLink))
            {
                writer.WritePropertyName("extensionApiDocsLink"u8);
                writer.WriteStringValue(ExtensionApiDocsLink);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DetailedInformation))
            {
                writer.WritePropertyName("detailedInformation"u8);
                writer.WriteStartArray();
                foreach (var item in DetailedInformation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        FarmBeatsExtensionData IJsonModel<FarmBeatsExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FarmBeatsExtensionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFarmBeatsExtensionData(document.RootElement, options);
        }

        internal static FarmBeatsExtensionData DeserializeFarmBeatsExtensionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> targetResourceType = default;
            Optional<string> farmBeatsExtensionId = default;
            Optional<string> farmBeatsExtensionName = default;
            Optional<string> farmBeatsExtensionVersion = default;
            Optional<string> publisherId = default;
            Optional<string> description = default;
            Optional<string> extensionCategory = default;
            Optional<string> extensionAuthLink = default;
            Optional<string> extensionApiDocsLink = default;
            Optional<IReadOnlyList<DetailedInformation>> detailedInformation = default;
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
                        if (property0.NameEquals("targetResourceType"u8))
                        {
                            targetResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionId"u8))
                        {
                            farmBeatsExtensionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionName"u8))
                        {
                            farmBeatsExtensionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("farmBeatsExtensionVersion"u8))
                        {
                            farmBeatsExtensionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"u8))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionCategory"u8))
                        {
                            extensionCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionAuthLink"u8))
                        {
                            extensionAuthLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionApiDocsLink"u8))
                        {
                            extensionApiDocsLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detailedInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DetailedInformation> array = new List<DetailedInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.DetailedInformation.DeserializeDetailedInformation(item));
                            }
                            detailedInformation = array;
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
            return new FarmBeatsExtensionData(id, name, type, systemData.Value, targetResourceType.Value, farmBeatsExtensionId.Value, farmBeatsExtensionName.Value, farmBeatsExtensionVersion.Value, publisherId.Value, description.Value, extensionCategory.Value, extensionAuthLink.Value, extensionApiDocsLink.Value, Optional.ToList(detailedInformation), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FarmBeatsExtensionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FarmBeatsExtensionData)} does not support '{options.Format}' format.");
            }
        }

        FarmBeatsExtensionData IPersistableModel<FarmBeatsExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FarmBeatsExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFarmBeatsExtensionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FarmBeatsExtensionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FarmBeatsExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
