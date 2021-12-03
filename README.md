# Expo Server Client for .NET

Server-side library for working with Expo using .NET.

## Features
- Use of .NET best practices and recommendations:   
    - [IHttpClientFactory](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)
    - __System.Text.Json__ and __System.Net.Http.Json__.
- Exponential backoff retry policy on HTTP 429 errors (Too Many Requests) or HTTP 5xx errors. 
- Configurable options like _AccessToken_ or _MaxConcurrentRequests_.
- HttpClient configured to use [Gzip and Deflate compression](https://docs.expo.dev/push-notifications/sending-notifications/#http2-api).

## Usage

In your services, add `services.AddExpoClient()` or `services.AddExpoClient(ExpoClientOptions options)` to override the default options. 

In your class, inject the `ExpoClient` service to use the Expo Push API. 

## ExpoClientOptions

These are the configurable options and their default values:

|Options | Default value | Description |
|---|---|---|
| AccessToken | Empty | See [Additional security](https://docs.expo.dev/push-notifications/sending-notifications/#additional-security) to configure an accessToken.
| MaxConcurrentRequests | 6 | [Limit concurrent connections](https://docs.expo.dev/push-notifications/sending-notifications/#limit-concurrent-connections).
