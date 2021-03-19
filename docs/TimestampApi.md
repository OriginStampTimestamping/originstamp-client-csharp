# OriginStamp.Client.Api.TimestampApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTimestamp**](TimestampApi.md#createtimestamp) | **POST** /v4/timestamp/create | Submission
[**GetHashStatus**](TimestampApi.md#gethashstatus) | **GET** /v4/timestamp/{hash_string} | Status
[**GetSeedStatus**](TimestampApi.md#getseedstatus) | **GET** /v4/timestamp/status/seed/{seed_id} | Seed Status


<a name="createtimestamp"></a>
# **CreateTimestamp**
> DefaultOfTimestampResponse CreateTimestamp (string authorization, TimestampRequest timestampRequest)

Submission

With this interface you can submit your hash. If your API key is valid, your hash is added  seeds and scheduled for timestamping. You are also able to submit additional information, such as a comment or notification target. If the hash already exists, the 'created' field in the response is set to 'false' and any notification(s) for this hash will be ignored. To later query the status of the hash for a certain blockchain you can use the 'seed_id' field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class CreateTimestampExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var timestampRequest = new TimestampRequest(); // TimestampRequest | DTO for the hash submission. Add all relevant information concerning your hash submission.

            try
            {
                // Submission
                DefaultOfTimestampResponse result = apiInstance.CreateTimestamp(authorization, timestampRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.CreateTimestamp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **timestampRequest** | [**TimestampRequest**](TimestampRequest.md)| DTO for the hash submission. Add all relevant information concerning your hash submission. | 

### Return type

[**DefaultOfTimestampResponse**](DefaultOfTimestampResponse.md)

### Authorization

[API Key Authorization](../README.md#API Key Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashstatus"></a>
# **GetHashStatus**
> DefaultOfTimestampResponse GetHashStatus (string authorization, string hashString)

Status

This interface returns information of a certain hash read from the URL path. If the status of several hashes is to be checked, it is preferable to use the seed status interface. This reduces the required requests and can be tailored to a desired blockchain. All 'created' fields are always set to false for a status request.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetHashStatusExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var hashString = hashString_example;  // string | The hash in string representation.

            try
            {
                // Status
                DefaultOfTimestampResponse result = apiInstance.GetHashStatus(authorization, hashString);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.GetHashStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **hashString** | **string**| The hash in string representation. | 

### Return type

[**DefaultOfTimestampResponse**](DefaultOfTimestampResponse.md)

### Authorization

[API Key Authorization](../README.md#API Key Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getseedstatus"></a>
# **GetSeedStatus**
> DefaultOfTimestampData GetSeedStatus (string authorization, string seedId)

Seed Status

With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetSeedStatusExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var seedId = seedId_example;  // string | ID of the timestamp seed

            try
            {
                // Seed Status
                DefaultOfTimestampData result = apiInstance.GetSeedStatus(authorization, seedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.GetSeedStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **seedId** | **string**| ID of the timestamp seed | 

### Return type

[**DefaultOfTimestampData**](DefaultOfTimestampData.md)

### Authorization

[API Key Authorization](../README.md#API Key Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

