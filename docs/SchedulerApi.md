# OriginStamp.Client.Api.SchedulerApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActiveCurrencies**](SchedulerApi.md#getactivecurrencies) | **GET** /v3/currencies/get | Get active currencies


<a name="getactivecurrencies"></a>
# **GetActiveCurrencies**
> DefaultOfListOfCurrencyModel GetActiveCurrencies (string authorization)

Get active currencies

Returns an array with all active currencies.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetActiveCurrenciesExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.

            try
            {
                // Get active currencies
                DefaultOfListOfCurrencyModel result = apiInstance.GetActiveCurrencies(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.GetActiveCurrencies: " + e.Message );
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

[**DefaultOfListOfCurrencyModel**](DefaultOfListOfCurrencyModel.md)

### Authorization

[API Key Authorization](../README.md#API Key Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

