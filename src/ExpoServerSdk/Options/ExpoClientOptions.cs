namespace ExpoServerSdk.Options;

public record ExpoClientOptions()
{
    private const DefaultMaxConcurrentRequests = 6;
    public static ExpoClientOptions Default = new ExpoClientOptions() { MaxConcurrentRequests = DefaultMaxConcurrentRequests };

    public string? AccessToken { get; set; }
    public int MaxConcurrentRequests { get; set; } = DefaultMaxConcurrentRequests;
}

