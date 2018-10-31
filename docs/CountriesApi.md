# IO.Swagger.ClickSend.Client.Api.CountriesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountriesGet**](CountriesApi.md#countriesget) | **GET** /countries | Get all country codes


<a name="countriesget"></a>
# **CountriesGet**
> string CountriesGet ()

Get all country codes

Get all countries

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.ClickSend.Client.Api;
using IO.Swagger.Client;
using IO.Swagger.ClickSend.Client.Model;

namespace Example
{
    public class CountriesGetExample
    {
        public void main()
        {
            var apiInstance = new CountriesApi();

            try
            {
                // Get all country codes
                string result = apiInstance.CountriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CountriesApi.CountriesGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

