# IO.ClickSend.ClickSend.Api.EmailDeliveryReceiptRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailDeliveryReceiptAutomationDelete**](EmailDeliveryReceiptRulesApi.md#emaildeliveryreceiptautomationdelete) | **DELETE** /automations/email/receipts/{receipt_rule_id} | Delete email delivery receipt automation
[**EmailDeliveryReceiptAutomationGet**](EmailDeliveryReceiptRulesApi.md#emaildeliveryreceiptautomationget) | **GET** /automations/email/receipts/{receipt_rule_id} | Get specific email delivery receipt automation
[**EmailDeliveryReceiptAutomationPost**](EmailDeliveryReceiptRulesApi.md#emaildeliveryreceiptautomationpost) | **POST** /automations/email/receipts | Create email delivery receipt automations
[**EmailDeliveryReceiptAutomationPut**](EmailDeliveryReceiptRulesApi.md#emaildeliveryreceiptautomationput) | **PUT** /automations/email/receipts/{receipt_rule_id} | Update email delivery receipt automation
[**EmailDeliveryReceiptAutomationsGet**](EmailDeliveryReceiptRulesApi.md#emaildeliveryreceiptautomationsget) | **GET** /automations/email/receipts | Get all email delivery receipt automations


<a name="emaildeliveryreceiptautomationdelete"></a>
# **EmailDeliveryReceiptAutomationDelete**
> string EmailDeliveryReceiptAutomationDelete (int? receiptRuleId)

Delete email delivery receipt automation

Delete email delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailDeliveryReceiptAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Delete email delivery receipt automation
                string result = apiInstance.EmailDeliveryReceiptAutomationDelete(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receiptRuleId** | **int?**| Receipt rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emaildeliveryreceiptautomationget"></a>
# **EmailDeliveryReceiptAutomationGet**
> string EmailDeliveryReceiptAutomationGet (int? receiptRuleId)

Get specific email delivery receipt automation

Get specific email delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailDeliveryReceiptAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Get specific email delivery receipt automation
                string result = apiInstance.EmailDeliveryReceiptAutomationGet(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receiptRuleId** | **int?**| Receipt rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emaildeliveryreceiptautomationpost"></a>
# **EmailDeliveryReceiptAutomationPost**
> string EmailDeliveryReceiptAutomationPost (DeliveryReceiptRule deliveryReceiptRule)

Create email delivery receipt automations

Create email delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailDeliveryReceiptAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailDeliveryReceiptRulesApi();
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | Email delivery receipt rule model

            try
            {
                // Create email delivery receipt automations
                string result = apiInstance.EmailDeliveryReceiptAutomationPost(deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryReceiptRule** | [**DeliveryReceiptRule**](DeliveryReceiptRule.md)| Email delivery receipt rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emaildeliveryreceiptautomationput"></a>
# **EmailDeliveryReceiptAutomationPut**
> string EmailDeliveryReceiptAutomationPut (int? receiptRuleId, DeliveryReceiptRule deliveryReceiptRule)

Update email delivery receipt automation

Update email delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailDeliveryReceiptAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | Delivery receipt rule model

            try
            {
                // Update email delivery receipt automation
                string result = apiInstance.EmailDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receiptRuleId** | **int?**| Receipt rule id | 
 **deliveryReceiptRule** | [**DeliveryReceiptRule**](DeliveryReceiptRule.md)| Delivery receipt rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emaildeliveryreceiptautomationsget"></a>
# **EmailDeliveryReceiptAutomationsGet**
> string EmailDeliveryReceiptAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all email delivery receipt automations

Get all email delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailDeliveryReceiptAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailDeliveryReceiptRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all email delivery receipt automations
                string result = apiInstance.EmailDeliveryReceiptAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationsGet: " + e.Message );
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

