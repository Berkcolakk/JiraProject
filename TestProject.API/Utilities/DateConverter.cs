using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestProject.API.Utilities
{
    public class DateConverter : JsonConverter<DateTime>
    {
        private const string dateFormat = "dd/MM/yyyy HH:mm:ss";
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), dateFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(dateFormat));
        }
    }
}
