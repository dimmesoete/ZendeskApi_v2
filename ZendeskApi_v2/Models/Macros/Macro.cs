﻿// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZendeskApi_v2.Models.Macros
{

    public class Macro
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("restriction")]
        public Restriction Restriction { get; set; }

        [JsonProperty("actions")]
        public IList<Action> Actions { get; set; }
    }
}
