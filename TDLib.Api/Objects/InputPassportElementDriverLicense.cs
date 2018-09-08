using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            public class InputPassportElementDriverLicense : InputPassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementDriverLicense";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("driver_license")]
                public InputIdentityDocument DriverLicense { get; set; }
            }
        }
    }
}