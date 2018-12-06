# IO.ClickSend.ClickSend.Api.InboundSMSRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsInboundAutomationDelete**](InboundSMSRulesApi.md#smsinboundautomationdelete) | **DELETE** /automations/sms/inbound/{inbound_rule_id} | Delete inbound sms automation
[**SmsInboundAutomationGet**](InboundSMSRulesApi.md#smsinboundautomationget) | **GET** /automations/sms/inbound/{inbound_rule_id} | Get specific inbound sms automation
[**SmsInboundAutomationPost**](InboundSMSRulesApi.md#smsinboundautomationpost) | **POST** /automations/sms/inbound | Create new inbound sms automation
[**SmsInboundAutomationPut**](InboundSMSRulesApi.md#smsinboundautomationput) | **PUT** /automations/sms/inbound/{inbound_rule_id} | Update inbound sms automation
[**SmsInboundAutomationsGet**](InboundSMSRulesApi.md#smsinboundautomationsget) | **GET** /automations/sms/inbound | Get all inbound sms automations


<a name="smsinboundautomationdelete"></a>
# **SmsInboundAutomationDelete**
> string SmsInboundAutomationDelete (int? inboundRuleId)

Delete inbound sms automation

Delete inbound sms automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundSMSRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id

            try
            {
                // Delete inbound sms automation
                string result = apiInstance.SmsInboundAutomationDelete(inboundRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundSMSRulesApi.SmsInboundAutomationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundRuleId** | **int?**| Inbound rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsinboundautomationget"></a>
# **SmsInboundAutomationGet**
> string SmsInboundAutomationGet (int? inboundRuleId)

Get specific inbound sms automation

Get specific inbound sms automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundSMSRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id

            try
            {
                // Get specific inbound sms automation
                string result = apiInstance.SmsInboundAutomationGet(inboundRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundSMSRulesApi.SmsInboundAutomationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundRuleId** | **int?**| Inbound rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsinboundautomationpost"></a>
# **SmsInboundAutomationPost**
> string SmsInboundAutomationPost (InboundSMSRule inboundSmsRule)

Create new inbound sms automation

Create new inbound sms automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundSMSRulesApi();
            var inboundSmsRule = new InboundSMSRule(); // InboundSMSRule | Inbound sms rule model

            try
            {
                // Create new inbound sms automation
                string result = apiInstance.SmsInboundAutomationPost(inboundSmsRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundSMSRulesApi.SmsInboundAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundSmsRule** | [**InboundSMSRule**](InboundSMSRule.md)| Inbound sms rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsinboundautomationput"></a>
# **SmsInboundAutomationPut**
> string SmsInboundAutomationPut (int? inboundRuleId, InboundSMSRule inboundSmsRule)

Update inbound sms automation

Update inbound sms automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundSMSRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id
            var inboundSmsRule = new InboundSMSRule(); // InboundSMSRule | Inbound sms rule model

            try
            {
                // Update inbound sms automation
                string result = apiInstance.SmsInboundAutomationPut(inboundRuleId, inboundSmsRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundSMSRulesApi.SmsInboundAutomationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundRuleId** | **int?**| Inbound rule id | 
 **inboundSmsRule** | [**InboundSMSRule**](InboundSMSRule.md)| Inbound sms rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsinboundautomationsget"></a>
# **SmsInboundAutomationsGet**
> string SmsInboundAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all inbound sms automations

Get all inbound sms automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsInboundAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundSMSRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all inbound sms automations
                string result = apiInstance.SmsInboundAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundSMSRulesApi.SmsInboundAutomationsGet: " + e.Message );
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

