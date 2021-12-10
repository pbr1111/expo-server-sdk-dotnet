using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExpoServerSdk.Models;

public record PushReceiptRequest()
{
    public List<string> Ids { get; set; } = default!;
}

public record PushReceiptResponse()
{
    public Dictionary<string, PushTicketDeliveryStatus> Data { get; set; } = default!;
    public List<PushReceiptError>? Errors { get; set; }
}

public record PushReceiptError()
{
    public string Code { get; set; } = default!;
    public string Message { get; set; } = default!;
}

