﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Bookstore.Web.Econt;
//
//    var labelRequest = LabelRequest.FromJson(jsonString);

namespace Bookstore.Web.Econt
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LabelRequest
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public LabelClass LabelLabel { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }
    }

    public partial class LabelClass
    {
        [JsonProperty("senderClient", NullValueHandling = NullValueHandling.Ignore)]
        public ErClient SenderClient { get; set; }

        [JsonProperty("senderAddress", NullValueHandling = NullValueHandling.Ignore)]
        public ErAddress SenderAddress { get; set; }

        [JsonProperty("receiverClient", NullValueHandling = NullValueHandling.Ignore)]
        public ErClient ReceiverClient { get; set; }

        [JsonProperty("receiverAddress", NullValueHandling = NullValueHandling.Ignore)]
        public ErAddress ReceiverAddress { get; set; }

        [JsonProperty("packCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PackCount { get; set; }

        [JsonProperty("shipmentType", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipmentType { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }

        [JsonProperty("shipmentDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipmentDescription { get; set; }
    }

    public partial class ErAddress
    {
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public City City { get; set; }

        [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
        public string Street { get; set; }

        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Num { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public string Other { get; set; }
    }

    public partial class City
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public Country Country { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("postCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? PostCode { get; set; }
    }

    public partial class Country
    {
        [JsonProperty("code3", NullValueHandling = NullValueHandling.Ignore)]
        public string Code3 { get; set; }
    }

    public partial class ErClient
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Phones { get; set; }
    }

    public partial class LabelRequest
    {
        public static LabelRequest FromJson(string json) => JsonConvert.DeserializeObject<LabelRequest>(json, Bookstore.Web.Econt.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LabelRequest self) => JsonConvert.SerializeObject(self, Bookstore.Web.Econt.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
