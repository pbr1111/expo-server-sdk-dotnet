using ExpoServerSdk;
using ExpoServerSdk.Models;
using ExpoServerSdk.Options;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Microsoft.Infrastructure.DependencyInjection;

public static class IServiceCollectionExtensions
{
    private const string BaseExpoUrl = "https://exp.host";

    public static IServiceCollection AddExpoClient(this IServiceCollection services, ExpoClientOptions options)
    {
        services.AddHttpClient<ExpoClient>(httpOptions =>
        {
            httpOptions.BaseAddress = new Uri(BaseExpoUrl);
            if (!string.IsNullOrEmpty(options?.AccessToken))
            {
                httpOptions.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.AccessToken);
            }
        })
        .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        })
        .AddPolicyHandler(GetRetryPolicy());

        return services;
    }

    public static IServiceCollection AddExpoClient(this IServiceCollection services) =>
        services.AddExpoClient(ExpoClientOptions.Default);

    private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
    {
        return HttpPolicyExtensions
            .HandleTransientHttpError()
            .OrResult(msg => msg.StatusCode == (HttpStatusCode)429
                || (msg.StatusCode >= (HttpStatusCode)500 && msg.StatusCode >= (HttpStatusCode)599))
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
    }
}

