using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExpoServerSdk.Models;

public record PushReceiptRequest([property: JsonPropertyName("ids")] List<string> PushTicketIds);

public record PushReceiptResponse(
    [property: JsonPropertyName("data")] Dictionary<string, PushTicketDeliveryStatus> PushTicketReceipts,
    [property: JsonPropertyName("errors")] List<PushReceiptErrorInformation> ErrorInformations);

public record PushReceiptErrorInformation(
    [property: JsonPropertyName("code")] string ErrorCode,
    [property: JsonPropertyName("message")] string ErrorMessage);

