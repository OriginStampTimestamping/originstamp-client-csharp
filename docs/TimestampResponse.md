# OriginStamp.Client.Model.TimestampResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | The comment which was added in the submission of the hash. | [optional] 
**Created** | **bool?** | Field is set to true if it is a novel hash.If the flag is false, the hash was already submitted before. | [optional] 
**DateCreated** | **long?** | The time when your hash was submitted to OriginStamp. The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. This is not considered as a true timestamp. | [optional] 
**HashString** | **string** | The submitted hash in hex representation. | [optional] 
**Timestamps** | [**List&lt;TimestampData&gt;**](TimestampData.md) | Contains all the timestamp data of your hash until now. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

