# .NET Core 3.x API Quickstart Sample Code for Integrating with Okta

This repository contains a sample of protecting API endpoints using [Okta](https://www.okta.com/) in a [.NET Core Web API](https://developer.okta.com/docs/guides/protect-your-api/aspnetcore3/main/).

The sample uses the [Okta.AspNetCore Nuget package](https://www.nuget.org/packages/Okta.AspNetCore). Read more about getting started with Okta and authentication best practices on the [Okta Developer Portal](https://developer.okta.com).

This code sample demonstrates
* Configuring Okta
* Protecting routes
* Reading claims values

## Getting started

You will need the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1).

To run this example, run the following commands:

```shell
git clone https://github.com/okta-samples/okta-dotnetcore3-api-quickstart.git
cd okta-dotnetcore3-api-quickstart
```

Restore the Nuget packages.

## Create an OIDC application in Okta

Create a free developer account with the following command using the [Okta CLI](https://cli.okta.com/):

```shell
okta register
```

You will need your Okta domain and Audience.

Update `appsettings.json` with your Okta settings adding `Okta` as a top level property.

```json
"Okta": {
  "OktaDomain": "https://{yourOktaDomain}",
  "AuthorizationServerId": "default",
  "Audience": "api://default"
}
```

Start the app by running in the IDE.

Use your favorite HTTP Client to call the API. For authenticated calls, follow the steps in [Send a request to your API endpoint using Postman](https://developer.okta.com) of the quick start.

## Helpful resources
* [Learn about Authentication, OAuth 2.0, and OpenID Connect](https://developer.okta.com/docs/concepts/)
* [Get started with NET Core](https://docs.microsoft.com/en-us/dotnet/core/get-started)

## Help

Please visit our [Okta Developer Forums](https://devforum.okta.com/).