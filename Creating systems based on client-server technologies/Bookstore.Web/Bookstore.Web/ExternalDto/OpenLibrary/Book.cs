﻿namespace Bookstore.Web.OpenLibrary
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Book
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Author> Authors { get; set; }

        [JsonProperty("number_of_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfPages { get; set; }

        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public string Pagination { get; set; }

        [JsonProperty("by_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string ByStatement { get; set; }

        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Identifiers Identifiers { get; set; }

        [JsonProperty("classifications", NullValueHandling = NullValueHandling.Ignore)]
        public Classifications Classifications { get; set; }

        [JsonProperty("publishers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Publish> Publishers { get; set; }

        [JsonProperty("publish_places", NullValueHandling = NullValueHandling.Ignore)]
        public List<Publish> PublishPlaces { get; set; }

        [JsonProperty("publish_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        [JsonProperty("subjects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Author> Subjects { get; set; }

        [JsonProperty("subject_people", NullValueHandling = NullValueHandling.Ignore)]
        public List<Author> SubjectPeople { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("ebooks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ebook> Ebooks { get; set; }

        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public Cover Cover { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Classifications
    {
        [JsonProperty("lc_classifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LcClassifications { get; set; }

        [JsonProperty("dewey_decimal_class", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeweyDecimalClass { get; set; }
    }

    public partial class Cover
    {
        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Small { get; set; }

        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Medium { get; set; }

        [JsonProperty("large", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Large { get; set; }
    }

    public partial class Ebook
    {
        [JsonProperty("preview_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PreviewUrl { get; set; }

        [JsonProperty("availability", NullValueHandling = NullValueHandling.Ignore)]
        public string Availability { get; set; }

        [JsonProperty("formats", NullValueHandling = NullValueHandling.Ignore)]
        public Formats Formats { get; set; }
    }

    public partial class Formats
    {
    }

    public partial class Identifiers
    {
        [JsonProperty("librarything", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Librarything { get; set; }

        [JsonProperty("goodreads", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Goodreads { get; set; }

        [JsonProperty("isbn_10", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isbn10 { get; set; }

        [JsonProperty("lccn", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Lccn { get; set; }

        [JsonProperty("openlibrary", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Openlibrary { get; set; }
    }

    public partial class Publish
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Book
    {
        public static Book FromJson(string json) => JsonConvert.DeserializeObject<Book>(json, Bookstore.Web.OpenLibrary.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Book self) => JsonConvert.SerializeObject(self, Bookstore.Web.OpenLibrary.Converter.Settings);
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

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(List<long>);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (List<long>)untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
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