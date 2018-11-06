# IO.ClickSend.ClickSend.Api.NumberApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NumbersBuyByDedicatedNumberPost**](NumberApi.md#numbersbuybydedicatednumberpost) | **POST** /numbers/buy/{dedicated_number} | Buy dedicated number
[**NumbersGet**](NumberApi.md#numbersget) | **GET** /numbers | Get all availible dedicated numbers
[**NumbersSearchByCountryGet**](NumberApi.md#numberssearchbycountryget) | **GET** /numbers/search/{country} | Get all dedicated numbers by country


<a name="numbersbuybydedicatednumberpost"></a>
# **NumbersBuyByDedicatedNumberPost**
> string NumbersBuyByDedicatedNumberPost (string dedicatedNumber)

Buy dedicated number

Buy dedicated number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class NumbersBuyByDedicatedNumberPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NumberApi();
            var dedicatedNumber = dedicatedNumber_example;  // string | Phone number to purchase

            try
            {
                // Buy dedicated number
                string result = apiInstance.NumbersBuyByDedicatedNumberPost(dedicatedNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberApi.NumbersBuyByDedicatedNumberPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dedicatedNumber** | **string**| Phone number to purchase | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="numbersget"></a>
# **NumbersGet**
> string NumbersGet (int? page = null, int? limit = null)

Get all availible dedicated numbers

Get all availible dedicated numbers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class NumbersGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NumberApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all availible dedicated numbers
                string result = apiInstance.NumbersGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberApi.NumbersGet: " + e.Message );
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

<a name="numberssearchbycountryget"></a>
# **NumbersSearchByCountryGet**
> string NumbersSearchByCountryGet (string country, string search = null, int? searchType = null, int? page = null, int? limit = null)

Get all dedicated numbers by country

Get all dedicated numbers by country

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class NumbersSearchByCountryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NumberApi();
            var country = country_example;  // string | Country code to search
            var search = search_example;  // string | Your search pattern or query. (optional) 
            var searchType = 56;  // int? | Your strategy for searching, 0 = starts with, 1 = anywhere, 2 = ends with. (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all dedicated numbers by country
                string result = apiInstance.NumbersSearchByCountryGet(country, search, searchType, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberApi.NumbersSearchByCountryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Country code to search | 
 **search** | **string**| Your search pattern or query. | [optional] 
 **searchType** | **int?**| Your strategy for searching, 0 &#x3D; starts with, 1 &#x3D; anywhere, 2 &#x3D; ends with. | [optional] 
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

