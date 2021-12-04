using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExpoServerSdk.Models;

public record PushTicketDeliveryStatus(
    [property: JsonPropertyName("status")] string DeliveryStatus,
    [property: JsonPropertyName("message")] string DeliveryMessage,
    [property: JsonPropertyName("details")] object DeliveryDetails);

public record PushTicketRequest(
    [property: JsonPropertyName("to")] List<string> PushTo,
    [property: JsonPropertyName("data")] object PushData,
    [property: JsonPropertyName("title")] string PushTitle,
    [property: JsonPropertyName("body")] string PushBody,
    [property: JsonPropertyName("ttl")] int? PushTTL,
    [property: JsonPropertyName("expiration")] int? PushExpiration,
    [property: JsonPropertyName("priority")] string PushPriority,
    [property: JsonPropertyName("subtitle")] string PushSubTitle,
    [property: JsonPropertyName("sound")] string PushSound,
    [property: JsonPropertyName("badge")] int? PushBadgeCount,
    [property: JsonPropertyName("channelId")] string PushChannelId);

public record PushTicketResponse(
    [property: JsonPropertyName("data")] List<PushTicketStatus> PushTicketStatuses,
    [property: JsonPropertyName("errors")] List<PushTicketErrors> PushTicketErrors);

public record PushTicketStatus(
    [property: JsonPropertyName("status")] string TicketStatus,
    [property: JsonPropertyName("id")] string TicketId,
    [property: JsonPropertyName("message")] string TicketMessage,
    [property: JsonPropertyName("details")] object TicketDetails);

public record PushTicketErrors(
    [property: JsonPropertyName("code")] string ErrorCode,
    [property: JsonPropertyName("message")] string ErrorMessage);
