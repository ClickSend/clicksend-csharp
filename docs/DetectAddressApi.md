# IO.ClickSend.ClickSend.Api.DetectAddressApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DetectAddressPost**](DetectAddressApi.md#detectaddresspost) | **POST** /post/letters/detect-address | Detects address in uploaded file.


<a name="detectaddresspost"></a>
# **DetectAddressPost**
> string DetectAddressPost (UploadFile uploadFile)

Detects address in uploaded file.

Detects address in uploaded file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class DetectAddressPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DetectAddressApi();
            var uploadFile = new UploadFile(); // UploadFile | Your file to be uploaded

            try
            {
                // Detects address in uploaded file.
                string result = apiInstance.DetectAddressPost(uploadFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DetectAddressApi.DetectAddressPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadFile** | [**UploadFile**](UploadFile.md)| Your file to be uploaded | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

