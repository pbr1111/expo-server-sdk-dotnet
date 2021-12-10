using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExpoServerSdk.Models;

public record PushReceiptRequest()
{
    public List<string> Ids { get; set; }
}

public record PushReceiptResponse()
{
    public Dictionary<string, PushTicketDeliveryStatus> Data { get; set; }
    public List<PushReceiptError>? Errors { get; set; }
}

public record PushReceiptError()
{
    public string Code { get; set; }
    public string Message { get; set; }
}

