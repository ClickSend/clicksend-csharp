# IO.Swagger.ClickSend.Api.DetectAddressApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DetectAddressPost**](DetectAddressApi.md#detectaddresspost) | **POST** /post/letters/detect-address | Detects address in uploaded file.


<a name="detectaddresspost"></a>
# **DetectAddressPost**
> string DetectAddressPost (string content)

Detects address in uploaded file.

Detects address in uploaded file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Model;

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
            var content = content_example;  // string | Base64-encoded file contents

            try
            {
                // Detects address in uploaded file.
                string result = apiInstance.DetectAddressPost(content);
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
 **content** | **string**| Base64-encoded file contents | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

