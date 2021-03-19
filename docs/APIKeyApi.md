# OriginStamp.Client.Api.APIKeyApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApiKeyUsage**](APIKeyApi.md#getapikeyusage) | **GET** /v3/api_key/usage | Usage


<a name="getapikeyusage"></a>
# **GetApiKeyUsage**
> DefaultUsageResponse GetApiKeyUsage (string authorization)

Usage

With this interface you can receive the current usage of your API key. The usage statistic refers to the associated account.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetApiKeyUsageExample
    {
        public void main()
        {
            var apiInstance = new APIKeyApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.

            try
            {
                // Usage
                DefaultUsageResponse result = apiInstance.GetApiKeyUsage(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.GetApiKeyUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 

### Return type

[**DefaultUsageResponse**](DefaultUsageResponse.md)

### Authorization

[API Key Authorization](../README.md#API Key Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

