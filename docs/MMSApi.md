# IO.ClickSend.ClickSend.Api.MMSApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MmsPricePost**](MMSApi.md#mmspricepost) | **POST** /mms/price | Get Price for MMS sent
[**MmsReceiptsGet**](MMSApi.md#mmsreceiptsget) | **GET** /mms/receipts | Get all delivery receipts
[**MmsReceiptsReadPut**](MMSApi.md#mmsreceiptsreadput) | **PUT** /mms/receipts-read | Mark delivery receipts as read
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
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

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

<a name="mmsreceiptsget"></a>
# **MmsReceiptsGet**
> string MmsReceiptsGet (int? page = null, int? limit = null)

Get all delivery receipts

Get all delivery receipts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsReceiptsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MMSApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all delivery receipts
                string result = apiInstance.MmsReceiptsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMSApi.MmsReceiptsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Number of records per page | [optional] [default to 10]

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmsreceiptsreadput"></a>
# **MmsReceiptsReadPut**
> string MmsReceiptsReadPut (DateBefore dateBefore = null)

Mark delivery receipts as read

Mark delivery receipts as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsReceiptsReadPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MMSApi();
            var dateBefore = new DateBefore(); // DateBefore | DateBefore model (optional) 

            try
            {
                // Mark delivery receipts as read
                string result = apiInstance.MmsReceiptsReadPut(dateBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MMSApi.MmsReceiptsReadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateBefore** | [**DateBefore**](DateBefore.md)| DateBefore model | [optional] 

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
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

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

