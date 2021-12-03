namespace ExpoServerSdk.Options;

public record ExpoClientOptions()
{
    public static ExpoClientOptions Default = new ExpoClientOptions() { MaxConcurrentRequests = 6 };

    public string AccessToken { get; set; }
    public int MaxConcurrentRequests { get; set; }
}

