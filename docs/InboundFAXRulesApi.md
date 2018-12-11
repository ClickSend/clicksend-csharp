# IO.ClickSend.ClickSend.Api.InboundFAXRulesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaxInboundAutomationDelete**](InboundFAXRulesApi.md#faxinboundautomationdelete) | **DELETE** /automations/fax/inbound/{inbound_rule_id} | Delete inbound fax automation
[**FaxInboundAutomationGet**](InboundFAXRulesApi.md#faxinboundautomationget) | **GET** /automations/fax/inbound/{inbound_rule_id} | Get specific inbound fax automation
[**FaxInboundAutomationPost**](InboundFAXRulesApi.md#faxinboundautomationpost) | **POST** /automations/fax/inbound | Create new inbound fax automation
[**FaxInboundAutomationPut**](InboundFAXRulesApi.md#faxinboundautomationput) | **PUT** /automations/fax/inbound/{inbound_rule_id} | Update inbound fax automation
[**FaxInboundAutomationsGet**](InboundFAXRulesApi.md#faxinboundautomationsget) | **GET** /automations/fax/inbound | Get all inbound fax automations


<a name="faxinboundautomationdelete"></a>
# **FaxInboundAutomationDelete**
> string FaxInboundAutomationDelete (int? inboundRuleId)

Delete inbound fax automation

Delete inbound fax automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxInboundAutomationDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundFAXRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id

            try
            {
                // Delete inbound fax automation
                string result = apiInstance.FaxInboundAutomationDelete(inboundRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundFAXRulesApi.FaxInboundAutomationDelete: " + e.Message );
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

<a name="faxinboundautomationget"></a>
# **FaxInboundAutomationGet**
> string FaxInboundAutomationGet (int? inboundRuleId)

Get specific inbound fax automation

Get specific inbound fax automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxInboundAutomationGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundFAXRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id

            try
            {
                // Get specific inbound fax automation
                string result = apiInstance.FaxInboundAutomationGet(inboundRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundFAXRulesApi.FaxInboundAutomationGet: " + e.Message );
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

<a name="faxinboundautomationpost"></a>
# **FaxInboundAutomationPost**
> string FaxInboundAutomationPost (InboundFaxRule inboundFaxRule)

Create new inbound fax automation

Create new inbound fax automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxInboundAutomationPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundFAXRulesApi();
            var inboundFaxRule = new InboundFaxRule(); // InboundFaxRule | Inbound fax rule model

            try
            {
                // Create new inbound fax automation
                string result = apiInstance.FaxInboundAutomationPost(inboundFaxRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundFAXRulesApi.FaxInboundAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundFaxRule** | [**InboundFaxRule**](InboundFaxRule.md)| Inbound fax rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxinboundautomationput"></a>
# **FaxInboundAutomationPut**
> string FaxInboundAutomationPut (int? inboundRuleId, InboundFaxRule inboundFaxRule)

Update inbound fax automation

Update inbound fax automation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxInboundAutomationPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundFAXRulesApi();
            var inboundRuleId = 56;  // int? | Inbound rule id
            var inboundFaxRule = new InboundFaxRule(); // InboundFaxRule | Inbound fax rule model

            try
            {
                // Update inbound fax automation
                string result = apiInstance.FaxInboundAutomationPut(inboundRuleId, inboundFaxRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundFAXRulesApi.FaxInboundAutomationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inboundRuleId** | **int?**| Inbound rule id | 
 **inboundFaxRule** | [**InboundFaxRule**](InboundFaxRule.md)| Inbound fax rule model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="faxinboundautomationsget"></a>
# **FaxInboundAutomationsGet**
> string FaxInboundAutomationsGet (string q = null, int? page = null, int? limit = null)

Get all inbound fax automations

Get all inbound fax automations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class FaxInboundAutomationsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new InboundFAXRulesApi();
            var q = q_example;  // string | Your keyword or query. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all inbound fax automations
                string result = apiInstance.FaxInboundAutomationsGet(q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundFAXRulesApi.FaxInboundAutomationsGet: " + e.Message );
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

