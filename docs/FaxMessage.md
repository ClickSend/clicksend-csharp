# IO.ClickSend.ClickSend.Model.FaxMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | Your method of sending e.g. &#x27;wordpress&#x27;, &#x27;php&#x27;, &#x27;c#&#x27;. | [optional] [default to "sdk"]
**To** | **string** | Recipient fax number in E.164 format. | 
**ListId** | **int?** | Your list ID if sending to a whole list. Can be used instead of &#x27;to&#x27;. | [optional] 
**From** | **string** | Your sender id. Must be a valid fax number. | [optional] 
**Schedule** | **int?** | Leave blank for immediate delivery. Your schedule time in unix format http://help.clicksend.com/what-is-a-unix-timestamp | [optional] 
**CustomString** | **string** | Your reference. Will be passed back with all replies and delivery reports. | [optional] 
**Country** | **string** | Recipient country. | [optional] 
**FromEmail** | **string** | An email address where the reply should be emailed to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

