using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExpoServerSdk.Models;

public record PushTicketDeliveryStatus()
{
    public string Status { get; set; }
    public string Message { get; set; }
    public object? Details { get; set; }
}

public record PushTicketRequest()
{
    public List<string> To { get; set; }
    public object? Data { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public int? Ttl { get; set; }
    public int? Expiration { get; set; }
    public string? Priority { get; set; }
    public string? Subtitle { get; set; }
    public string? Sound { get; set; }
    public int? Badge { get; set; }
    public string? ChannelId { get; set; }
    public string? CategoryId { get; set; }
    public bool? MutableContent { get; set; }
}

public record PushTicketResponse()
{
    public List<PushTicketStatus>? Data { get; set; }
    public List<PushTickets>? Errors { get; set; }
}

public record PushTicketStatus()
{
    public string Status { get; set; }
    public string? Message { get; set; }
    public object? Details { get; set; }
}

public record PushTicketErrors()
{
    public string Code { get; set; }
    public string Message { get; set; }
}
