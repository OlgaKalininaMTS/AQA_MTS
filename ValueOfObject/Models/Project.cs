using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestSharpApi.Models;

public class Project
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string? Name { get; init; }
    [JsonPropertyName("announcement")] public string? Announcement { get; init; }
    [JsonPropertyName("show_announcement")] public bool IsShowAnnouncement { get; set; }
    [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }
}
