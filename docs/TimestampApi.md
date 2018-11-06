# OriginStamp.Client.Api.TimestampApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTimestamp**](TimestampApi.md#createtimestamp) | **POST** /v3/timestamp/create | Submission
[**GetApiKeyUsage**](TimestampApi.md#getapikeyusage) | **GET** /v3/api_key/usage | Usage
[**GetHashStatus**](TimestampApi.md#gethashstatus) | **GET** /v3/timestamp/{hash_string} | Status
[**GetProof**](TimestampApi.md#getproof) | **POST** /v3/timestamp/proof | Proof
[**TriggerTimestampWebhook**](TimestampApi.md#triggertimestampwebhook) | **POST** /v3/webhook/start | Dev


<a name="createtimestamp"></a>
# **CreateTimestamp**
> DefaultTimestampResponse CreateTimestamp (string authorization, TimestampRequest timestampRequest)

Submission

You can submit your hash with this function. If your api key is valid, your hash is added to batch and is scheduled for timestamping. If the hash already exists, the created flag in the response is set to false and the notification(s) of the current request will be totally ignored. You are also able to submit additional information, such as comment or notification credentials. Once a hash is successfully created for a certain crypto-currency, we can notify your desired target with the timestamp information (POST Request). The webhook is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. Additionally, it is possible to include a preprint URL in the hash submission. Before the generation of the timestamp hash you can create a random UUID Version 4 and include https://originstamp.com/u/UUID where UUID is your UUID e.g. in a document you want to timestamp. In the preprint URL field you include your UUID and then it is possible to verify the timestamp within the document (or whatever). 

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
                DefaultTimestampResponse result = apiInstance.CreateTimestamp(authorization, timestampRequest);
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

[**DefaultTimestampResponse**](DefaultTimestampResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapikeyusage"></a>
# **GetApiKeyUsage**
> DefaultUsageResponse GetApiKeyUsage (string authorization)

Usage

With this interface you can receive the current api usage.

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
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.

            try
            {
                // Usage
                DefaultUsageResponse result = apiInstance.GetApiKeyUsage(authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.GetApiKeyUsage: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashstatus"></a>
# **GetHashStatus**
> DefaultTimestampResponse GetHashStatus (string authorization, string hashString)

Status

The request returns information of a certain hash read from the URL parameter. The input parameter is a hash in hex representation. Field \"created\" always set to false.

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
                DefaultTimestampResponse result = apiInstance.GetHashStatus(authorization, hashString);
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

[**DefaultTimestampResponse**](DefaultTimestampResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproof"></a>
# **GetProof**
> byte[] GetProof (string authorization, ProofRequest proofRequest)

Proof

This request can be used to proof a submission of a hash. This interface is required to request the evidence. With the help of this proof the verification of a timestamp independent from OriginStamp is necessary. A guide for the verification can be found herehttps://github.com/OriginStampTimestamping/originstamp-verification . Usually, the proof should be requested for each transferred hash and kept with the timestamped data so that an independent verification of the timestamp is possible at any time. As input, the used currency, the hash string and the type of proof is required. Then a file with the information for the submission proof will be returned. If the hash was submitted in an API version lower than 3, a XML file containing the essential information of the Merkle Tree will be returned. Otherwise, the seed file will be returned.  The file name can be found in the header of the response. An example could look like this: content-disposition: attachment; filename=\"certificate_6d70a947e19398f1106ad70a60bd34a8305bdcb624b5b7d43782315517e79cad.pdf\" A sample XML file can be found here https://originstamp.org/assets/proof/proof_6d70a947e19398f1106ad70a60bd34a8305bdcb624b5b7d43782315517e79cad.xml and a sample PDF can be found here https://originstamp.org/assets/proof/certificate_6d70a947e19398f1106ad70a60bd34a8305bdcb624b5b7d43782315517e79cad.pdf .

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetProofExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var proofRequest = new ProofRequest(); // ProofRequest | Information needed to return the hash status information.

            try
            {
                // Proof
                byte[] result = apiInstance.GetProof(authorization, proofRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.GetProof: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **proofRequest** | [**ProofRequest**](ProofRequest.md)| Information needed to return the hash status information. | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggertimestampwebhook"></a>
# **TriggerTimestampWebhook**
> Defaultstring TriggerTimestampWebhook (string authorization, WebhookRequest webhookRequest)

Dev

With this interface you can trigger manual webhook to see how a webhooks looks like. Please use a hash, that was already timestamped before such as https://originstamp.org/s/9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08 . Usually, the webhook is triggered as soon as the tamper-proof time stamp with the selected crypto currency has been created.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class TriggerTimestampWebhookExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var webhookRequest = new WebhookRequest(); // WebhookRequest | DTO for webhook request.

            try
            {
                // Dev
                Defaultstring result = apiInstance.TriggerTimestampWebhook(authorization, webhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TriggerTimestampWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **webhookRequest** | [**WebhookRequest**](WebhookRequest.md)| DTO for webhook request. | 

### Return type

[**Defaultstring**](Defaultstring.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

