﻿using ExpoServerSdk.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace ExpoServerSdk;

public class ExpoClient
{
    private const string PushSendPath = "/--/api/v2/push/send";
    private const string PushGetReceiptsPath = "/--/api/v2/push/getReceipts";

    private readonly HttpClient _httpClient;

    public ExpoClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<PushTicketResponse> PushSendAsync(PushTicketRequest pushTicketRequest) =>
        PostAsync<PushTicketRequest, PushTicketResponse>(pushTicketRequest, PushSendPath);

    public Task<PushReceiptResponse> PushGetReceiptsAsync(PushReceiptRequest pushReceiptRequest) =>
        PostAsync<PushReceiptRequest, PushReceiptResponse>(pushReceiptRequest, PushGetReceiptsPath);

    public async Task<U> PostAsync<T, U>(T request, string path)
    {
        var response = await _httpClient.PostAsJsonAsync(path, request, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<U>();
        }
        return default;
    }
}
