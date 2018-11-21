# IO.ClickSend.ClickSend.Api.UploadApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploadsPost**](UploadApi.md#uploadspost) | **POST** /uploads | Upload File


<a name="uploadspost"></a>
# **UploadsPost**
> string UploadsPost (string convert, UploadFile uploadFile = null)

Upload File

Upload File

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class UploadsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UploadApi();
            var convert = convert_example;  // string | 
            var uploadFile = new UploadFile(); // UploadFile |  (optional) 

            try
            {
                // Upload File
                string result = apiInstance.UploadsPost(convert, uploadFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploadsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **convert** | **string**|  | 
 **uploadFile** | [**UploadFile**](UploadFile.md)|  | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

