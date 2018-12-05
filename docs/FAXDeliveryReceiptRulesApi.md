# IO.ClickSend.ClickSend.Api.FAXDeliveryReceiptRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaxDeliveryReceiptAutomationDelete**](FAXDeliveryReceiptRulesApi.md#faxdeliveryreceiptautomationdelete) | **DELETE** /automations/fax/receipts/{receipt_rule_id} | Delete fax delivery receipt automation
[**FaxDeliveryReceiptAutomationGet**](FAXDeliveryReceiptRulesApi.md#faxdeliveryreceiptautomationget) | **GET** /automations/fax/receipts/{receipt_rule_id} | Get specific fax delivery receipt automation
[**FaxDeliveryReceiptAutomationPost**](FAXDeliveryReceiptRulesApi.md#faxdeliveryreceiptautomationpost) | **POST** /automations/fax/receipts | Create fax delivery receipt automations
[**FaxDeliveryReceiptAutomationPut**](FAXDeliveryReceiptRulesApi.md#faxdeliveryreceiptautomationput) | **PUT** /automations/fax/receipts/{receipt_rule_id} | Update fax delivery receipt automation
[**FaxDeliveryReceiptAutomationsGet**](FAXDeliveryReceiptRulesApi.md#faxdeliveryreceiptautomationsget) | **GET** /automations/fax/receipts | Get all fax delivery receipt automations


<a name="faxdeliveryreceiptautomationdelete"></a>
# **FaxDeliveryReceiptAutomationDelete**
> string FaxDeliveryReceiptAutomationDelete (int? receiptRuleId)

Delete fax delivery receipt automation

Delete fax delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxDeliveryReceiptAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Delete fax delivery receipt automation
                string result = apiInstance.FaxDeliveryReceiptAutomationDelete(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXDeliveryReceiptRulesApi.FaxDeliveryReceiptAutomationDelete: " + e.Message );
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

<a name="faxdeliveryreceiptautomationget"></a>
# **FaxDeliveryReceiptAutomationGet**
> string FaxDeliveryReceiptAutomationGet (int? receiptRuleId)

Get specific fax delivery receipt automation

Get specific fax delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxDeliveryReceiptAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Get specific fax delivery receipt automation
                string result = apiInstance.FaxDeliveryReceiptAutomationGet(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXDeliveryReceiptRulesApi.FaxDeliveryReceiptAutomationGet: " + e.Message );
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

<a name="faxdeliveryreceiptautomationpost"></a>
# **FaxDeliveryReceiptAutomationPost**
> string FaxDeliveryReceiptAutomationPost (DeliveryReceiptRule deliveryReceiptRule)

Create fax delivery receipt automations

Create fax delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxDeliveryReceiptAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXDeliveryReceiptRulesApi();
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | fax delivery receipt rule model

            try
            {
                // Create fax delivery receipt automations
                string result = apiInstance.FaxDeliveryReceiptAutomationPost(deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXDeliveryReceiptRulesApi.FaxDeliveryReceiptAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryReceiptRule** | [**DeliveryReceiptRule**](DeliveryReceiptRule.md)| fax delivery receipt rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxdeliveryreceiptautomationput"></a>
# **FaxDeliveryReceiptAutomationPut**
> string FaxDeliveryReceiptAutomationPut (int? receiptRuleId, DeliveryReceiptRule deliveryReceiptRule)

Update fax delivery receipt automation

Update fax delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxDeliveryReceiptAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | Delivery receipt rule model

            try
            {
                // Update fax delivery receipt automation
                string result = apiInstance.FaxDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXDeliveryReceiptRulesApi.FaxDeliveryReceiptAutomationPut: " + e.Message );
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

<a name="faxdeliveryreceiptautomationsget"></a>
# **FaxDeliveryReceiptAutomationsGet**
> string FaxDeliveryReceiptAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all fax delivery receipt automations

Get all fax delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxDeliveryReceiptAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FAXDeliveryReceiptRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all fax delivery receipt automations
                string result = apiInstance.FaxDeliveryReceiptAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FAXDeliveryReceiptRulesApi.FaxDeliveryReceiptAutomationsGet: " + e.Message );
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

