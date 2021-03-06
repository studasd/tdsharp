using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// List of users nearby has changed. The update is sent only 60 seconds after a successful searchChatsNearby request 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// List of users nearby has changed. The update is sent only 60 seconds after a successful searchChatsNearby request 
            /// </summary>
            public class UpdateUsersNearby : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateUsersNearby";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The new list of users nearby
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("users_nearby")]
                public ChatNearby[] UsersNearby { get; set; }
            }
        }
    }
}