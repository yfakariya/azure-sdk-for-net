// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class WebApplicationFirewallCustomRule : IUtf8JsonSerializable, IJsonModel<WebApplicationFirewallCustomRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationFirewallCustomRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebApplicationFirewallCustomRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallCustomRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallCustomRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(RateLimitDuration))
            {
                writer.WritePropertyName("rateLimitDuration"u8);
                writer.WriteStringValue(RateLimitDuration.Value.ToString());
            }
            if (Optional.IsDefined(RateLimitThreshold))
            {
                writer.WritePropertyName("rateLimitThreshold"u8);
                writer.WriteNumberValue(RateLimitThreshold.Value);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("matchConditions"u8);
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(GroupByUserSession))
            {
                writer.WritePropertyName("groupByUserSession"u8);
                writer.WriteStartArray();
                foreach (var item in GroupByUserSession)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
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

        WebApplicationFirewallCustomRule IJsonModel<WebApplicationFirewallCustomRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallCustomRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallCustomRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallCustomRule(document.RootElement, options);
        }

        internal static WebApplicationFirewallCustomRule DeserializeWebApplicationFirewallCustomRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ETag> etag = default;
            int priority = default;
            Optional<WebApplicationFirewallState> state = default;
            Optional<ApplicationGatewayFirewallRateLimitDuration> rateLimitDuration = default;
            Optional<int> rateLimitThreshold = default;
            WebApplicationFirewallRuleType ruleType = default;
            IList<MatchCondition> matchConditions = default;
            Optional<IList<GroupByUserSession>> groupByUserSession = default;
            WebApplicationFirewallAction action = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new WebApplicationFirewallState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitDuration = new ApplicationGatewayFirewallRateLimitDuration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new WebApplicationFirewallRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    List<MatchCondition> array = new List<MatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchCondition.DeserializeMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("groupByUserSession"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GroupByUserSession> array = new List<GroupByUserSession>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.GroupByUserSession.DeserializeGroupByUserSession(item));
                    }
                    groupByUserSession = array;
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new WebApplicationFirewallAction(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebApplicationFirewallCustomRule(name.Value, Optional.ToNullable(etag), priority, Optional.ToNullable(state), Optional.ToNullable(rateLimitDuration), Optional.ToNullable(rateLimitThreshold), ruleType, matchConditions, Optional.ToList(groupByUserSession), action, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationFirewallCustomRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallCustomRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallCustomRule)} does not support '{options.Format}' format.");
            }
        }

        WebApplicationFirewallCustomRule IPersistableModel<WebApplicationFirewallCustomRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallCustomRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationFirewallCustomRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallCustomRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationFirewallCustomRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
