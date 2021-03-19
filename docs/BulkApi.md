# OriginStamp.Client.Api.BulkApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBulkTimestamp**](BulkApi.md#createbulktimestamp) | **POST** /v4/timestamp/bulk/create | Bulk Submission
[**GetSeedStatus**](BulkApi.md#getseedstatus) | **GET** /v4/timestamp/status/seed/{seed_id} | Seed Status


<a name="createbulktimestamp"></a>
# **CreateBulkTimestamp**
> List<DefaultOfTimestampResponse> CreateBulkTimestamp (string authorization, TimestampBulkRequest timestampBulkRequest)

Bulk Submission

With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the 'created' field in the response is set to 'false' and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the 'seed_id' field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class CreateBulkTimestampExample
    {
        public void main()
        {
            var apiInstance = new BulkApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var timestampBulkRequest = new TimestampBulkRequest(); // TimestampBulkRequest | DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.

            try
            {
                // Bulk Submission
                List<DefaultOfTimestampResponse> result = apiInstance.CreateBulkTimestamp(authorization, timestampBulkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkApi.CreateBulkTimestamp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **timestampBulkRequest** | [**TimestampBulkRequest**](TimestampBulkRequest.md)| DTO for the bulk hash submission. Add all relevant information concerning your hash submissions. | 

### Return type

[**List<DefaultOfTimestampResponse>**](DefaultOfTimestampResponse.md)

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
            var apiInstance = new BulkApi();
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
                Debug.Print("Exception when calling BulkApi.GetSeedStatus: " + e.Message );
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

