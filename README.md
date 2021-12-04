# Expo Server Client for .NET

![Build status](https://github.com/pbr1111/expo-server-sdk-dotnet/actions/workflows/main.yml/badge.svg?branch=main)

Server-side library for working with Expo using .NET.

## Features
- Use of the most recent .NET features, best practices and recommendations:   
    - [IHttpClientFactory](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).
    - __System.Text.Json__ and __System.Net.Http.Json__.
    - Records. 
- Exponential backoff [retry policy](https://docs.expo.dev/push-notifications/sending-notifications/#retry-on-failure) on HTTP 429 errors (Too Many Requests) or HTTP 5xx errors. 
- Configurable options like _AccessToken_ or _MaxConcurrentRequests_.
- HttpClient configured to use [Gzip and Deflate compression](https://docs.expo.dev/push-notifications/sending-notifications/#http2-api).
- It is inspired by the package [expo-server-sdk-dotnet](https://github.com/glyphard/expo-server-sdk-dotnet) so the models and the SDK client are very similar. 

## Usage

In your services, add `services.AddExpoClient()` or `services.AddExpoClient(ExpoClientOptions options)` to override the default options. 

In your class, inject the `IExpoClient` service to use the Expo Push API. 

## ExpoClientOptions

These are the configurable options and their default values:

|Options | Default value | Description |
|---|---|---|
| AccessToken | Empty | See [Additional security](https://docs.expo.dev/push-notifications/sending-notifications/#additional-security) to configure an accessToken.
| MaxConcurrentRequests | 6 | [Limit concurrent connections](https://docs.expo.dev/push-notifications/sending-notifications/#limit-concurrent-connections).


## See Also
 - [Sending Notifications with Expo's Push API](https://docs.expo.dev/push-notifications/sending-notifications/)
 - [expo-server-sdk-node](https://github.com/expo/expo-server-sdk-node)
 - Another [expo-server-sdk-dotnet](https://github.com/glyphard/expo-server-sdk-dotnet). 