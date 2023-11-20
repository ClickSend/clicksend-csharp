# IO.ClickSend.ClickSend.Api.GlobalSendingApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCountriesGet**](GlobalSendingApi.md#listcountriesget) | **GET** /country-list | List of countries
[**UserCountriesAgreePost**](GlobalSendingApi.md#usercountriesagreepost) | **POST** /user-countries/agree | Agree to rules and regulation
[**UserCountriesGet**](GlobalSendingApi.md#usercountriesget) | **GET** /user-countries | Get Countries for Global Sending
[**UserCountriesPost**](GlobalSendingApi.md#usercountriespost) | **POST** /user-countries | Select Countries for Global Sending


<a name="listcountriesget"></a>
# **ListCountriesGet**
> string ListCountriesGet ()

List of countries

List of countries with IDs that can be used in selecting countries for Global sending.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListCountriesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GlobalSendingApi();

            try
            {
                // List of countries
                string result = apiInstance.ListCountriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSendingApi.ListCountriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercountriesagreepost"></a>
# **UserCountriesAgreePost**
> string UserCountriesAgreePost ()

Agree to rules and regulation

To agree on rules and regulations of selected countries and confirm selection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class UserCountriesAgreePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GlobalSendingApi();

            try
            {
                // Agree to rules and regulation
                string result = apiInstance.UserCountriesAgreePost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSendingApi.UserCountriesAgreePost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercountriesget"></a>
# **UserCountriesGet**
> string UserCountriesGet ()

Get Countries for Global Sending

Get the list of selected countries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class UserCountriesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GlobalSendingApi();

            try
            {
                // Get Countries for Global Sending
                string result = apiInstance.UserCountriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSendingApi.UserCountriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercountriespost"></a>
# **UserCountriesPost**
> string UserCountriesPost (CountryListIds countryListIds)

Select Countries for Global Sending

Use this endpoint to select countries that you intend to send sms / mms to. To remove / unselect a country, just remove the country id from the array in the payload.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class UserCountriesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GlobalSendingApi();
            var countryListIds = new CountryListIds(); // CountryListIds | Id of countr(ies) you want to select, you can get them from GET /country-list response

            try
            {
                // Select Countries for Global Sending
                string result = apiInstance.UserCountriesPost(countryListIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSendingApi.UserCountriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryListIds** | [**CountryListIds**](CountryListIds.md)| Id of countr(ies) you want to select, you can get them from GET /country-list response | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

