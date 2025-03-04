// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    [PersistableModelProxy(typeof(UnknownFilter))]
    public partial class EventGridFilter : IUtf8JsonSerializable, IJsonModel<EventGridFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        EventGridFilter IJsonModel<EventGridFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridFilter(document.RootElement, options);
        }

        internal static EventGridFilter DeserializeEventGridFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("operatorType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BoolEquals": return BoolEqualsFilter.DeserializeBoolEqualsFilter(element);
                    case "IsNotNull": return IsNotNullFilter.DeserializeIsNotNullFilter(element);
                    case "IsNullOrUndefined": return IsNullOrUndefinedFilter.DeserializeIsNullOrUndefinedFilter(element);
                    case "NumberGreaterThan": return NumberGreaterThanFilter.DeserializeNumberGreaterThanFilter(element);
                    case "NumberGreaterThanOrEquals": return NumberGreaterThanOrEqualsFilter.DeserializeNumberGreaterThanOrEqualsFilter(element);
                    case "NumberIn": return NumberInFilter.DeserializeNumberInFilter(element);
                    case "NumberInRange": return NumberInRangeFilter.DeserializeNumberInRangeFilter(element);
                    case "NumberLessThan": return NumberLessThanFilter.DeserializeNumberLessThanFilter(element);
                    case "NumberLessThanOrEquals": return NumberLessThanOrEqualsFilter.DeserializeNumberLessThanOrEqualsFilter(element);
                    case "NumberNotIn": return NumberNotInFilter.DeserializeNumberNotInFilter(element);
                    case "NumberNotInRange": return NumberNotInRangeFilter.DeserializeNumberNotInRangeFilter(element);
                    case "StringBeginsWith": return StringBeginsWithFilter.DeserializeStringBeginsWithFilter(element);
                    case "StringContains": return StringContainsFilter.DeserializeStringContainsFilter(element);
                    case "StringEndsWith": return StringEndsWithFilter.DeserializeStringEndsWithFilter(element);
                    case "StringIn": return StringInFilter.DeserializeStringInFilter(element);
                    case "StringNotBeginsWith": return StringNotBeginsWithFilter.DeserializeStringNotBeginsWithFilter(element);
                    case "StringNotContains": return StringNotContainsFilter.DeserializeStringNotContainsFilter(element);
                    case "StringNotEndsWith": return StringNotEndsWithFilter.DeserializeStringNotEndsWithFilter(element);
                    case "StringNotIn": return StringNotInFilter.DeserializeStringNotInFilter(element);
                }
            }
            return UnknownFilter.DeserializeUnknownFilter(element);
        }

        BinaryData IPersistableModel<EventGridFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridFilter)} does not support '{options.Format}' format.");
            }
        }

        EventGridFilter IPersistableModel<EventGridFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
