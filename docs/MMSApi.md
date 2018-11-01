# IO.Swagger.ClickSend.Api.MMSApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MmsPricePost**](MMSApi.md#mmspricepost) | **POST** /mms/price | Get Price for MMS sent
[**MmsSendPost**](MMSApi.md#mmssendpost) | **POST** /mms/send | Send MMS


<a name="mmspricepost"></a>
# **MmsPricePost**
> string MmsPricePost (MmsMessageCollection mmsMessages)

Get Price for MMS sent

Get Price for MMS sent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Model;

namespace Example
{
    public class MmsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MMSApi();
            var mmsMessages = new MmsMessageCollection(); // MmsMessageCollection | MmsMessageCollection model

            try
            {
                // Get Price for MMS sent
                string result = apiInstance.MmsPricePost(mmsMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMSApi.MmsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mmsMessages** | [**MmsMessageCollection**](MmsMessageCollection.md)| MmsMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmssendpost"></a>
# **MmsSendPost**
> string MmsSendPost (MmsMessageCollection mmsMessages)

Send MMS

Send MMS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Model;

namespace Example
{
    public class MmsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MMSApi();
            var mmsMessages = new MmsMessageCollection(); // MmsMessageCollection | MmsMessageCollection model

            try
            {
                // Send MMS
                string result = apiInstance.MmsSendPost(mmsMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMSApi.MmsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mmsMessages** | [**MmsMessageCollection**](MmsMessageCollection.md)| MmsMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

