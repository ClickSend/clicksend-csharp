# IO.ClickSend.ClickSend.Model.VoiceMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | Your phone number in E.164 format. | [optional] 
**Body** | **string** | Biscuit uv3nlCOjRk croissant chocolate lollipop chocolate muffin. | 
**Voice** | **string** | Either &#39;female&#39; or &#39;male&#39;. | 
**CustomString** | **string** | Your reference. Will be passed back with all replies and delivery reports. | 
**Country** | **string** | The country of the recipient. | 
**Source** | **string** | Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;. | [optional] [default to "sdk"]
**ListId** | **int?** | Your list ID if sending to a whole list. Can be used instead of &#39;to&#39;. | [optional] 
**Lang** | **string** | au (string, required) - See section on available languages. | [optional] 
**Schedule** | **int?** | Leave blank for immediate delivery. Your schedule time in unix format http://help.clicksend.com/what-is-a-unix-timestamp | [optional] 
**RequireInput** | **int?** | Whether you want to receive a keypress from the call recipient | [optional] [default to 0]
**MachineDetection** | **int?** | Whether to attempt to detect an answering machine or voicemail service and leave a message | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

