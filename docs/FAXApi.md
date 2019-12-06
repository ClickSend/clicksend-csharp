# IO.ClickSend.ClickSend.Api.FAXApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaxHistoryGet**](FAXApi.md#faxhistoryget) | **GET** /fax/history | Get a list of Fax History.
[**FaxPricePost**](FAXApi.md#faxpricepost) | **POST** /fax/price | Calculate Total Price for Fax Messages sent
[**FaxReceiptsByMessageIdGet**](FAXApi.md#faxreceiptsbymessageidget) | **GET** /fax/receipts/{message_id} | Get a single fax receipt based on message id.
[**FaxReceiptsGet**](FAXApi.md#faxreceiptsget) | **GET** /fax/receipts | Get all delivery receipts
[**FaxReceiptsPost**](FAXApi.md#faxreceiptspost) | **POST** /fax/receipts | Add a delivery receipt
[**FaxReceiptsReadPut**](FAXApi.md#faxreceiptsreadput) | **PUT** /fax/receipts-read | Mark delivery receipts as read
[**FaxSendPost**](FAXApi.md#faxsendpost) | **POST** /fax/send | Send a fax using supplied supported file-types.


<a name="faxhistoryget"></a>
# **FaxHistoryGet**
> string FaxHistoryGet (int? dateFrom = null, int? dateTo = null, string q = null, string order = null, int? page = null, int? limit = null)

Get a list of Fax History.

Get a list of Fax History.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var dateFrom = 56;  // int? | Customize result by setting from date (timestsamp) Example: 1457572619. (optional) 
            var dateTo = 56;  // int? | Customize result by setting to date (timestamp) Example: 1457573000. (optional) 
            var q = q_example;  // string | Custom query Example: status:Sent,status_code:201. (optional) 
            var order = order_example;  // string | Order result by Example: date_added:desc,list_id:desc. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get a list of Fax History.
                string result = apiInstance.FaxHistoryGet(dateFrom, dateTo, q, order, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateFrom** | **int?**| Customize result by setting from date (timestsamp) Example: 1457572619. | [optional] 
 **dateTo** | **int?**| Customize result by setting to date (timestamp) Example: 1457573000. | [optional] 
 **q** | **string**| Custom query Example: status:Sent,status_code:201. | [optional] 
 **order** | **string**| Order result by Example: date_added:desc,list_id:desc. | [optional] 
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

<a name="faxpricepost"></a>
# **FaxPricePost**
> string FaxPricePost (FaxMessageCollection faxMessage)

Calculate Total Price for Fax Messages sent

Calculate Total Price for Fax Messages sent

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var faxMessage = new FaxMessageCollection(); // FaxMessageCollection | FaxMessageCollection model

            try
            {
                // Calculate Total Price for Fax Messages sent
                string result = apiInstance.FaxPricePost(faxMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **faxMessage** | [**FaxMessageCollection**](FaxMessageCollection.md)| FaxMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxreceiptsbymessageidget"></a>
# **FaxReceiptsByMessageIdGet**
> string FaxReceiptsByMessageIdGet (string messageId)

Get a single fax receipt based on message id.

Get a single fax receipt based on message id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxReceiptsByMessageIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var messageId = messageId_example;  // string | ID of the message receipt to retrieve

            try
            {
                // Get a single fax receipt based on message id.
                string result = apiInstance.FaxReceiptsByMessageIdGet(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxReceiptsByMessageIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| ID of the message receipt to retrieve | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxreceiptsget"></a>
# **FaxReceiptsGet**
> string FaxReceiptsGet (int? page = null, int? limit = null)

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
    public class FaxReceiptsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all delivery receipts
                string result = apiInstance.FaxReceiptsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxReceiptsGet: " + e.Message );
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

<a name="faxreceiptspost"></a>
# **FaxReceiptsPost**
> string FaxReceiptsPost (Url url)

Add a delivery receipt

Add a delivery receipt

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxReceiptsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var url = new Url(); // Url | Url model

            try
            {
                // Add a delivery receipt
                string result = apiInstance.FaxReceiptsPost(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxReceiptsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | [**Url**](Url.md)| Url model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxreceiptsreadput"></a>
# **FaxReceiptsReadPut**
> string FaxReceiptsReadPut (DateBefore dateBefore = null)

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
    public class FaxReceiptsReadPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var dateBefore = new DateBefore(); // DateBefore | DateBefore model (optional) 

            try
            {
                // Mark delivery receipts as read
                string result = apiInstance.FaxReceiptsReadPut(dateBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxReceiptsReadPut: " + e.Message );
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

<a name="faxsendpost"></a>
# **FaxSendPost**
> string FaxSendPost (FaxMessageCollection faxMessage)

Send a fax using supplied supported file-types.

Send a fax using supplied supported file-types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXApi();
            var faxMessage = new FaxMessageCollection(); // FaxMessageCollection | FaxMessageCollection model

            try
            {
                // Send a fax using supplied supported file-types.
                string result = apiInstance.FaxSendPost(faxMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXApi.FaxSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **faxMessage** | [**FaxMessageCollection**](FaxMessageCollection.md)| FaxMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

