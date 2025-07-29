# IO.ClickSend.ClickSend.Model.SmsMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | Your sender id - more info: https://help.clicksend.com/en/collections/57584-numbers-sender-ids. | [optional] 
**Body** | **string** | Your message. | 
**To** | **string** | Recipient phone number in E.164 format. | [optional] 
**Source** | **string** | Your method of sending e.g. &#x27;wordpress&#x27;, &#x27;php&#x27;, &#x27;c#&#x27;. | [optional] [default to "sdk"]
**Schedule** | **int?** | Leave blank for immediate delivery. Your schedule time in unix format https://help.clicksend.com/en/articles/44235-what-is-a-unix-timestamp | [optional] [default to 0]
**CustomString** | **string** | Your reference. Will be passed back with all replies and delivery reports. | [optional] 
**ListId** | **int?** | Your list ID if sending to a whole list. Can be used instead of &#x27;to&#x27;. | [optional] 
**Country** | **string** | Recipient country. | [optional] 
**FromEmail** | **string** | An email address where the reply should be emailed to. If omitted, the reply will be emailed back to the user who sent the outgoing SMS. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

