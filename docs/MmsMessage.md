# IO.ClickSend.ClickSend.Model.MmsMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | Recipient phone number in E.164 format | [optional] 
**Body** | **string** | Your message | 
**Subject** | **string** | Subject line (max 20 characters) | 
**From** | **string** | Your sender ID | [optional] 
**Country** | **string** | Recipient country | [optional] 
**Source** | **string** | Your method of sending | [optional] [default to "sdk"]
**ListId** | **int?** | Your list ID if sending to a whole list (can be used instead of &#39;to&#39;) | [optional] 
**Schedule** | **int?** | Schedule time in unix format (leave blank for immediate delivery) | [optional] [default to 0]
**CustomString** | **string** | Custom string for your reference | [optional] 
**FromEmail** | **string** | Email to send replies to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

