using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class RecoverPassword : Method<PasswordState>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "recoverPassword";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("recovery_code")]
        public string RecoveryCode { get; set; }

    }

}