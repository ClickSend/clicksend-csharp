# IO.ClickSend.ClickSend.Api.SMSApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsCancelAllPut**](SMSApi.md#smscancelallput) | **PUT** /sms/cancel-all | Update all scheduled message as cancelled
[**SmsCancelByMessageIdPut**](SMSApi.md#smscancelbymessageidput) | **PUT** /sms/{message_id}/cancel | Update scheduled message as cancelled
[**SmsHistoryExportGet**](SMSApi.md#smshistoryexportget) | **GET** /sms/history/export | Export all sms history
[**SmsHistoryGet**](SMSApi.md#smshistoryget) | **GET** /sms/history | Get all sms history
[**SmsInboundGet**](SMSApi.md#smsinboundget) | **GET** /sms/inbound | Get all inbound sms
[**SmsInboundPost**](SMSApi.md#smsinboundpost) | **POST** /sms/inbound | Create inbound sms
[**SmsInboundReadByMessageIdPut**](SMSApi.md#smsinboundreadbymessageidput) | **PUT** /sms/inbound-read/{message_id} | Mark inbound SMS as read
[**SmsInboundReadPut**](SMSApi.md#smsinboundreadput) | **PUT** /sms/inbound-read | Mark inbound SMS as read
[**SmsPricePost**](SMSApi.md#smspricepost) | **POST** /sms/price | Calculate sms price
[**SmsReceiptsByMessageIdGet**](SMSApi.md#smsreceiptsbymessageidget) | **GET** /sms/receipts/{message_id} | Get a Specific Delivery Receipt
[**SmsReceiptsGet**](SMSApi.md#smsreceiptsget) | **GET** /sms/receipts | Get all delivery receipts
[**SmsReceiptsPost**](SMSApi.md#smsreceiptspost) | **POST** /sms/receipts | Add a delivery receipt
[**SmsReceiptsReadPut**](SMSApi.md#smsreceiptsreadput) | **PUT** /sms/receipts-read | Mark delivery receipts as read
[**SmsSendPost**](SMSApi.md#smssendpost) | **POST** /sms/send | Send sms message(s)
[**SmsTemplatesByTemplateIdDelete**](SMSApi.md#smstemplatesbytemplateiddelete) | **DELETE** /sms/templates/{template_id} | Delete sms template
[**SmsTemplatesByTemplateIdPut**](SMSApi.md#smstemplatesbytemplateidput) | **PUT** /sms/templates/{template_id} | Update sms template
[**SmsTemplatesGet**](SMSApi.md#smstemplatesget) | **GET** /sms/templates | Get lists of all sms templates
[**SmsTemplatesPost**](SMSApi.md#smstemplatespost) | **POST** /sms/templates | Create sms template


<a name="smscancelallput"></a>
# **SmsCancelAllPut**
> string SmsCancelAllPut ()

Update all scheduled message as cancelled

Update all scheduled message as cancelled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCancelAllPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();

            try
            {
                // Update all scheduled message as cancelled
                string result = apiInstance.SmsCancelAllPut();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCancelAllPut: " + e.Message );
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

<a name="smscancelbymessageidput"></a>
# **SmsCancelByMessageIdPut**
> string SmsCancelByMessageIdPut (string messageId)

Update scheduled message as cancelled

Update scheduled message as cancelled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCancelByMessageIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var messageId = messageId_example;  // string | The message ID you want to cancel

            try
            {
                // Update scheduled message as cancelled
                string result = apiInstance.SmsCancelByMessageIdPut(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCancelByMessageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| The message ID you want to cancel | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smshistoryexportget"></a>
# **SmsHistoryExportGet**
> string SmsHistoryExportGet (string filename)

Export all sms history

Export all sms history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsHistoryExportGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var filename = filename_example;  // string | Filename to download history as

            try
            {
                // Export all sms history
                string result = apiInstance.SmsHistoryExportGet(filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsHistoryExportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| Filename to download history as | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smshistoryget"></a>
# **SmsHistoryGet**
> string SmsHistoryGet (string q = null, int? dateFrom = null, int? dateTo = null, int? page = null, int? limit = null)

Get all sms history

Get all sms history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var q = q_example;  // string | Custom query Example: from:{number},status_code:201. (optional) 
            var dateFrom = 56;  // int? | Start date (optional) 
            var dateTo = 56;  // int? | End date (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all sms history
                string result = apiInstance.SmsHistoryGet(q, dateFrom, dateTo, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Custom query Example: from:{number},status_code:201. | [optional] 
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

<a name="smsinboundget"></a>
# **SmsInboundGet**
> string SmsInboundGet (string q = null, int? page = null, int? limit = null)

Get all inbound sms

Get all inbound sms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all inbound sms
                string result = apiInstance.SmsInboundGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsInboundGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Your keyword or query. | [optional] 
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

<a name="smsinboundpost"></a>
# **SmsInboundPost**
> string SmsInboundPost (Url url)

Create inbound sms

Create inbound sms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var url = new Url(); // Url | Url model

            try
            {
                // Create inbound sms
                string result = apiInstance.SmsInboundPost(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsInboundPost: " + e.Message );
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

<a name="smsinboundreadbymessageidput"></a>
# **SmsInboundReadByMessageIdPut**
> string SmsInboundReadByMessageIdPut (string messageId)

Mark inbound SMS as read

Mark specific inbound SMS as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundReadByMessageIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var messageId = messageId_example;  // string | Message ID

            try
            {
                // Mark inbound SMS as read
                string result = apiInstance.SmsInboundReadByMessageIdPut(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsInboundReadByMessageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsinboundreadput"></a>
# **SmsInboundReadPut**
> string SmsInboundReadPut (DateBefore dateBefore = null)

Mark inbound SMS as read

Mark all inbound SMS as read optionally before a certain date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundReadPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var dateBefore = new DateBefore(); // DateBefore | DateBefore model (optional) 

            try
            {
                // Mark inbound SMS as read
                string result = apiInstance.SmsInboundReadPut(dateBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsInboundReadPut: " + e.Message );
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

<a name="smspricepost"></a>
# **SmsPricePost**
> string SmsPricePost (SmsMessageCollection smsMessages)

Calculate sms price

Calculate sms price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var smsMessages = new SmsMessageCollection(); // SmsMessageCollection | SmsMessageCollection model

            try
            {
                // Calculate sms price
                string result = apiInstance.SmsPricePost(smsMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsMessages** | [**SmsMessageCollection**](SmsMessageCollection.md)| SmsMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsreceiptsbymessageidget"></a>
# **SmsReceiptsByMessageIdGet**
> string SmsReceiptsByMessageIdGet (string messageId)

Get a Specific Delivery Receipt

Get a Specific Delivery Receipt

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsReceiptsByMessageIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var messageId = messageId_example;  // string | Message ID

            try
            {
                // Get a Specific Delivery Receipt
                string result = apiInstance.SmsReceiptsByMessageIdGet(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsReceiptsByMessageIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsreceiptsget"></a>
# **SmsReceiptsGet**
> string SmsReceiptsGet (int? page = null, int? limit = null)

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
    public class SmsReceiptsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all delivery receipts
                string result = apiInstance.SmsReceiptsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsReceiptsGet: " + e.Message );
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

<a name="smsreceiptspost"></a>
# **SmsReceiptsPost**
> string SmsReceiptsPost (Url url)

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
    public class SmsReceiptsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var url = new Url(); // Url | Url model

            try
            {
                // Add a delivery receipt
                string result = apiInstance.SmsReceiptsPost(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsReceiptsPost: " + e.Message );
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

<a name="smsreceiptsreadput"></a>
# **SmsReceiptsReadPut**
> string SmsReceiptsReadPut (DateBefore dateBefore = null)

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
    public class SmsReceiptsReadPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var dateBefore = new DateBefore(); // DateBefore | DateBefore model (optional) 

            try
            {
                // Mark delivery receipts as read
                string result = apiInstance.SmsReceiptsReadPut(dateBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsReceiptsReadPut: " + e.Message );
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

<a name="smssendpost"></a>
# **SmsSendPost**
> string SmsSendPost (SmsMessageCollection smsMessages)

Send sms message(s)

 # Send one or more SMS messages  You can post up to 1000 messages with each API call. You can send to a mix of contacts and contact lists, as long as the total number of recipients is up to 1000.  The response contains status and details for each recipient.  *Refer to [Application Status Codes](https://dashboard.clicksend.com/#/signup/step1/) for the possible response message status strings.* 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var smsMessages = new SmsMessageCollection(); // SmsMessageCollection | SmsMessageCollection model

            try
            {
                // Send sms message(s)
                string result = apiInstance.SmsSendPost(smsMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsMessages** | [**SmsMessageCollection**](SmsMessageCollection.md)| SmsMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smstemplatesbytemplateiddelete"></a>
# **SmsTemplatesByTemplateIdDelete**
> string SmsTemplatesByTemplateIdDelete (int? templateId)

Delete sms template

Delete sms template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsTemplatesByTemplateIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var templateId = 56;  // int? | Template id

            try
            {
                // Delete sms template
                string result = apiInstance.SmsTemplatesByTemplateIdDelete(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsTemplatesByTemplateIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **int?**| Template id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smstemplatesbytemplateidput"></a>
# **SmsTemplatesByTemplateIdPut**
> string SmsTemplatesByTemplateIdPut (int? templateId, SmsTemplate smsTemplate)

Update sms template

Update sms template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsTemplatesByTemplateIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var templateId = 56;  // int? | Template id
            var smsTemplate = new SmsTemplate(); // SmsTemplate | Template item

            try
            {
                // Update sms template
                string result = apiInstance.SmsTemplatesByTemplateIdPut(templateId, smsTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsTemplatesByTemplateIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **int?**| Template id | 
 **smsTemplate** | [**SmsTemplate**](SmsTemplate.md)| Template item | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smstemplatesget"></a>
# **SmsTemplatesGet**
> string SmsTemplatesGet (int? page = null, int? limit = null)

Get lists of all sms templates

Get lists of all sms templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsTemplatesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get lists of all sms templates
                string result = apiInstance.SmsTemplatesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsTemplatesGet: " + e.Message );
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

<a name="smstemplatespost"></a>
# **SmsTemplatesPost**
> string SmsTemplatesPost (SmsTemplate smsTemplate)

Create sms template

Create sms template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsTemplatesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSApi();
            var smsTemplate = new SmsTemplate(); // SmsTemplate | SmsTemplate model

            try
            {
                // Create sms template
                string result = apiInstance.SmsTemplatesPost(smsTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SmsTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsTemplate** | [**SmsTemplate**](SmsTemplate.md)| SmsTemplate model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

