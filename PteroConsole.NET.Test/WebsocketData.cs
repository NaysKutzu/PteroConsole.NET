﻿using Newtonsoft.Json;

namespace PteroConsole.NET.Test;

public class WebsocketDataResource
{
    [JsonProperty("data")]
    public WebsocketData? Data { get; set; }
}

public class WebsocketData
{
    [JsonProperty("token")]
    public string? Token { get; set; }

    [JsonProperty("socket")]
    public string? Socket { get; set; }
}