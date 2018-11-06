# IO.ClickSend.ClickSend.Model.PostDirectMail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Campaign name | 
**FileUrls** | **List&lt;string&gt;** | Campaign file URLs (maximum 2) | 
**Size** | **string** | Document size - A5 or DL | 
**Areas** | [**List&lt;PostDirectMailArea&gt;**](PostDirectMailArea.md) | PostDirectMailArea model | 
**Schedule** | **int?** | Leave blank for immediate delivery. Your schedule time in unix format. | [optional] [default to 0]
**Source** | **string** | Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;. | [optional] [default to "sdk"]
**CustomString** | **string** | A custom string for your own reference | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

