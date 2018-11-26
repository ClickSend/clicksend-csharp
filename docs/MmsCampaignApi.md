# IO.ClickSend.ClickSend.Api.MmsCampaignApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MmsCampaignByMmsCampaignIdGet**](MmsCampaignApi.md#mmscampaignbymmscampaignidget) | **GET** /mms-campaigns/{mms_campaign_id} | Get specific mms campaign
[**MmsCampaignsByMmsCampaignIdPut**](MmsCampaignApi.md#mmscampaignsbymmscampaignidput) | **PUT** /mms-campaigns/{mms_campaign_id} | Update mms campaign
[**MmsCampaignsCancelByMmsCampaignIdPut**](MmsCampaignApi.md#mmscampaignscancelbymmscampaignidput) | **PUT** /mms-campaigns/{mms_campaign_id}/cancel | Cancel mms campaign
[**MmsCampaignsGet**](MmsCampaignApi.md#mmscampaignsget) | **GET** /mms-campaigns | Get list of mms campaigns
[**MmsCampaignsPricePost**](MmsCampaignApi.md#mmscampaignspricepost) | **POST** /mms-campaigns/price | Calculate price for mms campaign
[**MmsCampaignsSendPost**](MmsCampaignApi.md#mmscampaignssendpost) | **POST** /mms-campaigns/send | Create mms campaign


<a name="mmscampaignbymmscampaignidget"></a>
# **MmsCampaignByMmsCampaignIdGet**
> string MmsCampaignByMmsCampaignIdGet (int? mmsCampaignId)

Get specific mms campaign

Get specific mms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsCampaignByMmsCampaignIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var mmsCampaignId = 56;  // int? | ID of MMS campaign to retrieve

            try
            {
                // Get specific mms campaign
                string result = apiInstance.MmsCampaignByMmsCampaignIdGet(mmsCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignByMmsCampaignIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mmsCampaignId** | **int?**| ID of MMS campaign to retrieve | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmscampaignsbymmscampaignidput"></a>
# **MmsCampaignsByMmsCampaignIdPut**
> string MmsCampaignsByMmsCampaignIdPut (int? mmsCampaignId, MmsCampaign campaign)

Update mms campaign

Update mms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsCampaignsByMmsCampaignIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var mmsCampaignId = 56;  // int? | ID of MMS campaign to update
            var campaign = new MmsCampaign(); // MmsCampaign | MmsCampaign model

            try
            {
                // Update mms campaign
                string result = apiInstance.MmsCampaignsByMmsCampaignIdPut(mmsCampaignId, campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignsByMmsCampaignIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mmsCampaignId** | **int?**| ID of MMS campaign to update | 
 **campaign** | [**MmsCampaign**](MmsCampaign.md)| MmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmscampaignscancelbymmscampaignidput"></a>
# **MmsCampaignsCancelByMmsCampaignIdPut**
> string MmsCampaignsCancelByMmsCampaignIdPut (int? mmsCampaignId)

Cancel mms campaign

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
    public class MmsCampaignsCancelByMmsCampaignIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var mmsCampaignId = 56;  // int? | ID of MMS Campaign to cancel

            try
            {
                // Cancel mms campaign
                string result = apiInstance.MmsCampaignsCancelByMmsCampaignIdPut(mmsCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignsCancelByMmsCampaignIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mmsCampaignId** | **int?**| ID of MMS Campaign to cancel | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmscampaignsget"></a>
# **MmsCampaignsGet**
> string MmsCampaignsGet (int? page = null, int? limit = null)

Get list of mms campaigns

Get list of mms campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsCampaignsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of mms campaigns
                string result = apiInstance.MmsCampaignsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignsGet: " + e.Message );
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

<a name="mmscampaignspricepost"></a>
# **MmsCampaignsPricePost**
> string MmsCampaignsPricePost (MmsCampaign campaign)

Calculate price for mms campaign

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
    public class MmsCampaignsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var campaign = new MmsCampaign(); // MmsCampaign | MmsCampaign model

            try
            {
                // Calculate price for mms campaign
                string result = apiInstance.MmsCampaignsPricePost(campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaign** | [**MmsCampaign**](MmsCampaign.md)| MmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mmscampaignssendpost"></a>
# **MmsCampaignsSendPost**
> string MmsCampaignsSendPost (MmsCampaign campaign)

Create mms campaign

Create mms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MmsCampaignsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MmsCampaignApi();
            var campaign = new MmsCampaign(); // MmsCampaign | MmsCampaign model

            try
            {
                // Create mms campaign
                string result = apiInstance.MmsCampaignsSendPost(campaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MmsCampaignApi.MmsCampaignsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaign** | [**MmsCampaign**](MmsCampaign.md)| MmsCampaign model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

