# OriginStamp.Client.Model.Notification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **int?** | 0: Bitcoin | 
**NotificationType** | **int?** | 0: notify via email  1: notify a webhook | 
**Target** | **string** | Depending on the notification type, specify the target for the notification (e.g. email address or webhook url). The webhook url will reveive a POST request after timestamp was successfully created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

