# IO.ClickSend.ClickSend.Api.SmsCampaignApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsCampaignBySmsCampaignIdGet**](SmsCampaignApi.md#smscampaignbysmscampaignidget) | **GET** /sms-campaigns/{sms_campaign_id} | Get specific sms campaign
[**SmsCampaignsBySmsCampaignIdPut**](SmsCampaignApi.md#smscampaignsbysmscampaignidput) | **PUT** /sms-campaigns/{sms_campaign_id} | Update sms campaign
[**SmsCampaignsCancelBySmsCampaignIdPut**](SmsCampaignApi.md#smscampaignscancelbysmscampaignidput) | **PUT** /sms-campaigns/{sms_campaign_id}/cancel | Cancel sms campaign
[**SmsCampaignsGet**](SmsCampaignApi.md#smscampaignsget) | **GET** /sms-campaigns | Get list of sms campaigns
[**SmsCampaignsPricePost**](SmsCampaignApi.md#smscampaignspricepost) | **POST** /sms-campaigns/price | Calculate price for sms campaign
[**SmsCampaignsSendPost**](SmsCampaignApi.md#smscampaignssendpost) | **POST** /sms-campaigns/send | Create sms campaign


<a name="smscampaignbysmscampaignidget"></a>
# **SmsCampaignBySmsCampaignIdGet**
> string SmsCampaignBySmsCampaignIdGet (int? smsCampaignId)

Get specific sms campaign

Get specific sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignBySmsCampaignIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var smsCampaignId = 56;  // int? | ID of SMS campaign to retrieve

            try
            {
                // Get specific sms campaign
                string result = apiInstance.SmsCampaignBySmsCampaignIdGet(smsCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignBySmsCampaignIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsCampaignId** | **int?**| ID of SMS campaign to retrieve | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smscampaignsbysmscampaignidput"></a>
# **SmsCampaignsBySmsCampaignIdPut**
> string SmsCampaignsBySmsCampaignIdPut (int? smsCampaignId, SmsCampaign campaign)

Update sms campaign

Update sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignsBySmsCampaignIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var smsCampaignId = 56;  // int? | ID of SMS campaign to update
            var campaign = new SmsCampaign(); // SmsCampaign | SmsCampaign model

            try
            {
                // Update sms campaign
                string result = apiInstance.SmsCampaignsBySmsCampaignIdPut(smsCampaignId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignsBySmsCampaignIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsCampaignId** | **int?**| ID of SMS campaign to update | 
 **campaign** | [**SmsCampaign**](SmsCampaign.md)| SmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smscampaignscancelbysmscampaignidput"></a>
# **SmsCampaignsCancelBySmsCampaignIdPut**
> string SmsCampaignsCancelBySmsCampaignIdPut (int? smsCampaignId)

Cancel sms campaign

Cancel sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignsCancelBySmsCampaignIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var smsCampaignId = 56;  // int? | ID of SMS Campaign to cancel

            try
            {
                // Cancel sms campaign
                string result = apiInstance.SmsCampaignsCancelBySmsCampaignIdPut(smsCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignsCancelBySmsCampaignIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsCampaignId** | **int?**| ID of SMS Campaign to cancel | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smscampaignsget"></a>
# **SmsCampaignsGet**
> string SmsCampaignsGet (int? page = null, int? limit = null)

Get list of sms campaigns

Get list of sms campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of sms campaigns
                string result = apiInstance.SmsCampaignsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignsGet: " + e.Message );
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

<a name="smscampaignspricepost"></a>
# **SmsCampaignsPricePost**
> string SmsCampaignsPricePost (SmsCampaign campaign)

Calculate price for sms campaign

Calculate price for sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var campaign = new SmsCampaign(); // SmsCampaign | SmsCampaign model

            try
            {
                // Calculate price for sms campaign
                string result = apiInstance.SmsCampaignsPricePost(campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaign** | [**SmsCampaign**](SmsCampaign.md)| SmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smscampaignssendpost"></a>
# **SmsCampaignsSendPost**
> string SmsCampaignsSendPost (SmsCampaign campaign)

Create sms campaign

Create sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsCampaignsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SmsCampaignApi();
            var campaign = new SmsCampaign(); // SmsCampaign | SmsCampaign model

            try
            {
                // Create sms campaign
                string result = apiInstance.SmsCampaignsSendPost(campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsCampaignApi.SmsCampaignsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaign** | [**SmsCampaign**](SmsCampaign.md)| SmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

