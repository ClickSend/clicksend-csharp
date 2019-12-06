# IO.ClickSend.ClickSend.Api.TransactionalEmailApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailHistoryExportGet**](TransactionalEmailApi.md#emailhistoryexportget) | **GET** /email/history/export | Export all Transactional Email history
[**EmailHistoryGet**](TransactionalEmailApi.md#emailhistoryget) | **GET** /email/history | Get all transactional email history
[**EmailPricePost**](TransactionalEmailApi.md#emailpricepost) | **POST** /email/price | Get transactional email price
[**EmailSendPost**](TransactionalEmailApi.md#emailsendpost) | **POST** /email/send | Send transactional email


<a name="emailhistoryexportget"></a>
# **EmailHistoryExportGet**
> string EmailHistoryExportGet (string filename, int? dateFrom = null, int? dateTo = null)

Export all Transactional Email history

Export all Transactional Email history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailHistoryExportGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionalEmailApi();
            var filename = filename_example;  // string | Filename to download history as
            var dateFrom = 56;  // int? | Start date (optional) 
            var dateTo = 56;  // int? | End date (optional) 

            try
            {
                // Export all Transactional Email history
                string result = apiInstance.EmailHistoryExportGet(filename, dateFrom, dateTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailApi.EmailHistoryExportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| Filename to download history as | 
 **dateFrom** | **int?**| Start date | [optional] 
 **dateTo** | **int?**| End date | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailhistoryget"></a>
# **EmailHistoryGet**
> string EmailHistoryGet (int? dateFrom = null, int? dateTo = null, int? page = null, int? limit = null)

Get all transactional email history

Get all transactional email history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionalEmailApi();
            var dateFrom = 56;  // int? | Start date (optional) 
            var dateTo = 56;  // int? | End date (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all transactional email history
                string result = apiInstance.EmailHistoryGet(dateFrom, dateTo, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailApi.EmailHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateFrom** | **int?**| Start date | [optional] 
 **dateTo** | **int?**| End date | [optional] 
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

<a name="emailpricepost"></a>
# **EmailPricePost**
> string EmailPricePost (Email email)

Get transactional email price

Get transactional email price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionalEmailApi();
            var email = new Email(); // Email | Email model

            try
            {
                // Get transactional email price
                string result = apiInstance.EmailPricePost(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailApi.EmailPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [**Email**](Email.md)| Email model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailsendpost"></a>
# **EmailSendPost**
> string EmailSendPost (Email email)

Send transactional email

Send transactional email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionalEmailApi();
            var email = new Email(); // Email | Email model

            try
            {
                // Send transactional email
                string result = apiInstance.EmailSendPost(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailApi.EmailSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [**Email**](Email.md)| Email model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

