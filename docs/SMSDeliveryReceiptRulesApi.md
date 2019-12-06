# IO.ClickSend.ClickSend.Api.SMSDeliveryReceiptRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsDeliveryReceiptAutomationDelete**](SMSDeliveryReceiptRulesApi.md#smsdeliveryreceiptautomationdelete) | **DELETE** /automations/sms/receipts/{receipt_rule_id} | Delete sms delivery receipt automation
[**SmsDeliveryReceiptAutomationGet**](SMSDeliveryReceiptRulesApi.md#smsdeliveryreceiptautomationget) | **GET** /automations/sms/receipts/{receipt_rule_id} | Get specific sms delivery receipt automation
[**SmsDeliveryReceiptAutomationPost**](SMSDeliveryReceiptRulesApi.md#smsdeliveryreceiptautomationpost) | **POST** /automations/sms/receipts | Create sms delivery receipt automations
[**SmsDeliveryReceiptAutomationPut**](SMSDeliveryReceiptRulesApi.md#smsdeliveryreceiptautomationput) | **PUT** /automations/sms/receipts/{receipt_rule_id} | Update sms delivery receipt automation
[**SmsDeliveryReceiptAutomationsGet**](SMSDeliveryReceiptRulesApi.md#smsdeliveryreceiptautomationsget) | **GET** /automations/sms/receipts | Get all sms delivery receipt automations


<a name="smsdeliveryreceiptautomationdelete"></a>
# **SmsDeliveryReceiptAutomationDelete**
> string SmsDeliveryReceiptAutomationDelete (int? receiptRuleId)

Delete sms delivery receipt automation

Delete sms delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsDeliveryReceiptAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Delete sms delivery receipt automation
                string result = apiInstance.SmsDeliveryReceiptAutomationDelete(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationDelete: " + e.Message );
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

<a name="smsdeliveryreceiptautomationget"></a>
# **SmsDeliveryReceiptAutomationGet**
> string SmsDeliveryReceiptAutomationGet (int? receiptRuleId)

Get specific sms delivery receipt automation

Get specific sms delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsDeliveryReceiptAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Get specific sms delivery receipt automation
                string result = apiInstance.SmsDeliveryReceiptAutomationGet(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationGet: " + e.Message );
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

<a name="smsdeliveryreceiptautomationpost"></a>
# **SmsDeliveryReceiptAutomationPost**
> string SmsDeliveryReceiptAutomationPost (DeliveryReceiptRule deliveryReceiptRule)

Create sms delivery receipt automations

Create sms delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsDeliveryReceiptAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSDeliveryReceiptRulesApi();
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | sms delivery receipt rule model

            try
            {
                // Create sms delivery receipt automations
                string result = apiInstance.SmsDeliveryReceiptAutomationPost(deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryReceiptRule** | [**DeliveryReceiptRule**](DeliveryReceiptRule.md)| sms delivery receipt rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsdeliveryreceiptautomationput"></a>
# **SmsDeliveryReceiptAutomationPut**
> string SmsDeliveryReceiptAutomationPut (int? receiptRuleId, DeliveryReceiptRule deliveryReceiptRule)

Update sms delivery receipt automation

Update sms delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsDeliveryReceiptAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | Delivery receipt rule model

            try
            {
                // Update sms delivery receipt automation
                string result = apiInstance.SmsDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationPut: " + e.Message );
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

<a name="smsdeliveryreceiptautomationsget"></a>
# **SmsDeliveryReceiptAutomationsGet**
> string SmsDeliveryReceiptAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all sms delivery receipt automations

Get all sms delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsDeliveryReceiptAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SMSDeliveryReceiptRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all sms delivery receipt automations
                string result = apiInstance.SmsDeliveryReceiptAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationsGet: " + e.Message );
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

