# OriginStamp.Client.Api.SchedulerApi

All URIs are relative to *https://api.originstamp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNextSchedulingTime**](SchedulerApi.md#getnextschedulingtime) | **POST** /v3/submission/times | NextSchedule


<a name="getnextschedulingtime"></a>
# **GetNextSchedulingTime**
> DefaultSchedulerResponse GetNextSchedulingTime (string authorization, SchedulerRequest schedulerRequest)

NextSchedule

Get the next scheduling time for hash submissions to the blockchain.

### Example
```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class GetNextSchedulingTimeExample
    {
        public void main()
        {
            var apiInstance = new SchedulerApi();
            var authorization = authorization_example;  // string | A valid API key is essential for authorization to handle the request.
            var schedulerRequest = new SchedulerRequest(); // SchedulerRequest | Request DTO for next schedules.

            try
            {
                // NextSchedule
                DefaultSchedulerResponse result = apiInstance.GetNextSchedulingTime(authorization, schedulerRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchedulerApi.GetNextSchedulingTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| A valid API key is essential for authorization to handle the request. | 
 **schedulerRequest** | [**SchedulerRequest**](SchedulerRequest.md)| Request DTO for next schedules. | 

### Return type

[**DefaultSchedulerResponse**](DefaultSchedulerResponse.md)


### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

