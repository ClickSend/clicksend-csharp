# IO.ClickSend.ClickSend.Api.VoiceDeliveryReceiptRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VoiceDeliveryReceiptAutomationDelete**](VoiceDeliveryReceiptRulesApi.md#voicedeliveryreceiptautomationdelete) | **DELETE** /automations/voice/receipts/{receipt_rule_id} | Delete voice delivery receipt automation
[**VoiceDeliveryReceiptAutomationGet**](VoiceDeliveryReceiptRulesApi.md#voicedeliveryreceiptautomationget) | **GET** /automations/voice/receipts/{receipt_rule_id} | Get specific voice delivery receipt automation
[**VoiceDeliveryReceiptAutomationPost**](VoiceDeliveryReceiptRulesApi.md#voicedeliveryreceiptautomationpost) | **POST** /automations/voice/receipts | Create voice delivery receipt automations
[**VoiceDeliveryReceiptAutomationPut**](VoiceDeliveryReceiptRulesApi.md#voicedeliveryreceiptautomationput) | **PUT** /automations/voice/receipts/{receipt_rule_id} | Update voice delivery receipt automation
[**VoiceDeliveryReceiptAutomationsGet**](VoiceDeliveryReceiptRulesApi.md#voicedeliveryreceiptautomationsget) | **GET** /automations/voice/receipts | Get all voice delivery receipt automations


<a name="voicedeliveryreceiptautomationdelete"></a>
# **VoiceDeliveryReceiptAutomationDelete**
> string VoiceDeliveryReceiptAutomationDelete (int? receiptRuleId)

Delete voice delivery receipt automation

Delete voice delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceDeliveryReceiptAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Delete voice delivery receipt automation
                string result = apiInstance.VoiceDeliveryReceiptAutomationDelete(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationDelete: " + e.Message );
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

<a name="voicedeliveryreceiptautomationget"></a>
# **VoiceDeliveryReceiptAutomationGet**
> string VoiceDeliveryReceiptAutomationGet (int? receiptRuleId)

Get specific voice delivery receipt automation

Get specific voice delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceDeliveryReceiptAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id

            try
            {
                // Get specific voice delivery receipt automation
                string result = apiInstance.VoiceDeliveryReceiptAutomationGet(receiptRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationGet: " + e.Message );
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

<a name="voicedeliveryreceiptautomationpost"></a>
# **VoiceDeliveryReceiptAutomationPost**
> string VoiceDeliveryReceiptAutomationPost (DeliveryReceiptRule deliveryReceiptRule)

Create voice delivery receipt automations

Create voice delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceDeliveryReceiptAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceDeliveryReceiptRulesApi();
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | voice delivery receipt rule model

            try
            {
                // Create voice delivery receipt automations
                string result = apiInstance.VoiceDeliveryReceiptAutomationPost(deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryReceiptRule** | [**DeliveryReceiptRule**](DeliveryReceiptRule.md)| voice delivery receipt rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voicedeliveryreceiptautomationput"></a>
# **VoiceDeliveryReceiptAutomationPut**
> string VoiceDeliveryReceiptAutomationPut (int? receiptRuleId, DeliveryReceiptRule deliveryReceiptRule)

Update voice delivery receipt automation

Update voice delivery receipt automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceDeliveryReceiptAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceDeliveryReceiptRulesApi();
            var receiptRuleId = 56;  // int? | Receipt rule id
            var deliveryReceiptRule = new DeliveryReceiptRule(); // DeliveryReceiptRule | Delivery receipt rule model

            try
            {
                // Update voice delivery receipt automation
                string result = apiInstance.VoiceDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationPut: " + e.Message );
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

<a name="voicedeliveryreceiptautomationsget"></a>
# **VoiceDeliveryReceiptAutomationsGet**
> string VoiceDeliveryReceiptAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all voice delivery receipt automations

Get all voice delivery receipt automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceDeliveryReceiptAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceDeliveryReceiptRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all voice delivery receipt automations
                string result = apiInstance.VoiceDeliveryReceiptAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationsGet: " + e.Message );
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

