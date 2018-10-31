# IO.Swagger.ClickSend.Client.Api.FaxApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaxHistoryGet**](FaxApi.md#faxhistoryget) | **GET** /fax/history | Get a list of Fax History.
[**FaxPricePost**](FaxApi.md#faxpricepost) | **POST** /fax/price | Calculate Total Price for Fax Messages sent
[**FaxReceiptsByMessageIdGet**](FaxApi.md#faxreceiptsbymessageidget) | **GET** /fax/receipts/{message_id} | Get a single fax receipt based on message id.
[**FaxReceiptsGet**](FaxApi.md#faxreceiptsget) | **GET** /fax/receipts | Get List of Fax Receipts
[**FaxSendPost**](FaxApi.md#faxsendpost) | **POST** /fax/send | Send a fax using supplied supported file-types.


<a name="faxhistoryget"></a>
# **FaxHistoryGet**
> string FaxHistoryGet (int? dateFrom = null, int? dateTo = null, string q = null, string order = null, int? page = null, int? limit = null)

Get a list of Fax History.

Get a list of Fax History.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class FaxHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FaxApi();
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
                Debug.Print("Exception when calling FaxApi.FaxHistoryGet: " + e.Message );
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
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class FaxPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FaxApi();
            var faxMessage = new FaxMessageCollection(); // FaxMessageCollection | FaxMessageCollection model

            try
            {
                // Calculate Total Price for Fax Messages sent
                string result = apiInstance.FaxPricePost(faxMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxPricePost: " + e.Message );
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
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class FaxReceiptsByMessageIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FaxApi();
            var messageId = messageId_example;  // string | ID of the message receipt to retrieve

            try
            {
                // Get a single fax receipt based on message id.
                string result = apiInstance.FaxReceiptsByMessageIdGet(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxReceiptsByMessageIdGet: " + e.Message );
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
> string FaxReceiptsGet ()

Get List of Fax Receipts

Get List of Fax Receipts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class FaxReceiptsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FaxApi();

            try
            {
                // Get List of Fax Receipts
                string result = apiInstance.FaxReceiptsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxReceiptsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class FaxSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FaxApi();
            var faxMessage = new FaxMessageCollection(); // FaxMessageCollection | FaxMessageCollection model

            try
            {
                // Send a fax using supplied supported file-types.
                string result = apiInstance.FaxSendPost(faxMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaxApi.FaxSendPost: " + e.Message );
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

