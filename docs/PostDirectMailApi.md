# IO.Swagger.Api.PostDirectMailApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostDirectMailCampaignsGet**](PostDirectMailApi.md#postdirectmailcampaignsget) | **GET** /post/direct-mail/campaigns | Get direct mail campaigns
[**PostDirectMailCampaignsPricePost**](PostDirectMailApi.md#postdirectmailcampaignspricepost) | **POST** /post/direct-mail/campaigns/price | Calculate direct mail campaign price
[**PostDirectMailCampaignsSendPost**](PostDirectMailApi.md#postdirectmailcampaignssendpost) | **POST** /post/direct-mail/campaigns/send | Send direct mail campaign
[**PostDirectMailLocationsSearchByCountryGet**](PostDirectMailApi.md#postdirectmaillocationssearchbycountryget) | **GET** /post/direct-mail/locations/search/{country} | Search for a location


<a name="postdirectmailcampaignsget"></a>
# **PostDirectMailCampaignsGet**
> string PostDirectMailCampaignsGet (int? page = null, int? limit = null)

Get direct mail campaigns

Get direct mail campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDirectMailCampaignsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostDirectMailApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get direct mail campaigns
                string result = apiInstance.PostDirectMailCampaignsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostDirectMailApi.PostDirectMailCampaignsGet: " + e.Message );
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

<a name="postdirectmailcampaignspricepost"></a>
# **PostDirectMailCampaignsPricePost**
> string PostDirectMailCampaignsPricePost (PostDirectMail postDirectMail)

Calculate direct mail campaign price

Calculate direct mail campaign price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDirectMailCampaignsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostDirectMailApi();
            var postDirectMail = new PostDirectMail(); // PostDirectMail | PostDirectMail model

            try
            {
                // Calculate direct mail campaign price
                string result = apiInstance.PostDirectMailCampaignsPricePost(postDirectMail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostDirectMailApi.PostDirectMailCampaignsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postDirectMail** | [**PostDirectMail**](PostDirectMail.md)| PostDirectMail model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdirectmailcampaignssendpost"></a>
# **PostDirectMailCampaignsSendPost**
> string PostDirectMailCampaignsSendPost (PostDirectMail postDirectMail)

Send direct mail campaign

Send direct mail campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDirectMailCampaignsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostDirectMailApi();
            var postDirectMail = new PostDirectMail(); // PostDirectMail | PostDirectMail model

            try
            {
                // Send direct mail campaign
                string result = apiInstance.PostDirectMailCampaignsSendPost(postDirectMail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostDirectMailApi.PostDirectMailCampaignsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postDirectMail** | [**PostDirectMail**](PostDirectMail.md)| PostDirectMail model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdirectmaillocationssearchbycountryget"></a>
# **PostDirectMailLocationsSearchByCountryGet**
> string PostDirectMailLocationsSearchByCountryGet (string country, string q, int? page = null, int? limit = null)

Search for a location

Search for a location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDirectMailLocationsSearchByCountryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostDirectMailApi();
            var country = country_example;  // string | Country Code to search
            var q = q_example;  // string | Search term (e.g. post code, city name)
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Search for a location
                string result = apiInstance.PostDirectMailLocationsSearchByCountryGet(country, q, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostDirectMailApi.PostDirectMailLocationsSearchByCountryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Country Code to search | 
 **q** | **string**| Search term (e.g. post code, city name) | 
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

