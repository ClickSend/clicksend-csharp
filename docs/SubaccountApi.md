# IO.ClickSend.ClickSend.Api.SubaccountApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubaccountsBySubaccountIdDelete**](SubaccountApi.md#subaccountsbysubaccountiddelete) | **DELETE** /subaccounts/{subaccount_id} | Delete a subaccount
[**SubaccountsBySubaccountIdGet**](SubaccountApi.md#subaccountsbysubaccountidget) | **GET** /subaccounts/{subaccount_id} | Get specific subaccount
[**SubaccountsBySubaccountIdPut**](SubaccountApi.md#subaccountsbysubaccountidput) | **PUT** /subaccounts/{subaccount_id} | Update subaccount
[**SubaccountsGet**](SubaccountApi.md#subaccountsget) | **GET** /subaccounts | Get all subaccounts
[**SubaccountsPost**](SubaccountApi.md#subaccountspost) | **POST** /subaccounts | Create new subaccount
[**SubaccountsRegenApiKeyBySubaccountIdPut**](SubaccountApi.md#subaccountsregenapikeybysubaccountidput) | **PUT** /subaccounts/{subaccount_id}/regen-api-key | Regenerate an API Key


<a name="subaccountsbysubaccountiddelete"></a>
# **SubaccountsBySubaccountIdDelete**
> string SubaccountsBySubaccountIdDelete (int? subaccountId)

Delete a subaccount

Delete a subaccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsBySubaccountIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var subaccountId = 56;  // int? | ID of subaccount to delete

            try
            {
                // Delete a subaccount
                string result = apiInstance.SubaccountsBySubaccountIdDelete(subaccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsBySubaccountIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subaccountId** | **int?**| ID of subaccount to delete | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccountsbysubaccountidget"></a>
# **SubaccountsBySubaccountIdGet**
> string SubaccountsBySubaccountIdGet (int? subaccountId)

Get specific subaccount

Get specific subaccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsBySubaccountIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var subaccountId = 56;  // int? | ID of subaccount to get

            try
            {
                // Get specific subaccount
                string result = apiInstance.SubaccountsBySubaccountIdGet(subaccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsBySubaccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subaccountId** | **int?**| ID of subaccount to get | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccountsbysubaccountidput"></a>
# **SubaccountsBySubaccountIdPut**
> string SubaccountsBySubaccountIdPut (int? subaccountId, Subaccount subaccount)

Update subaccount

Update subaccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsBySubaccountIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var subaccountId = 56;  // int? | ID of subaccount to update
            var subaccount = new Subaccount(); // Subaccount | Subaccount model

            try
            {
                // Update subaccount
                string result = apiInstance.SubaccountsBySubaccountIdPut(subaccountId, subaccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsBySubaccountIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subaccountId** | **int?**| ID of subaccount to update | 
 **subaccount** | [**Subaccount**](Subaccount.md)| Subaccount model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccountsget"></a>
# **SubaccountsGet**
> string SubaccountsGet (int? page = null, int? limit = null)

Get all subaccounts

Get all subaccounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all subaccounts
                string result = apiInstance.SubaccountsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsGet: " + e.Message );
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

<a name="subaccountspost"></a>
# **SubaccountsPost**
> string SubaccountsPost (Subaccount subaccount)

Create new subaccount

Create new subaccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var subaccount = new Subaccount(); // Subaccount | Subaccount model

            try
            {
                // Create new subaccount
                string result = apiInstance.SubaccountsPost(subaccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subaccount** | [**Subaccount**](Subaccount.md)| Subaccount model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccountsregenapikeybysubaccountidput"></a>
# **SubaccountsRegenApiKeyBySubaccountIdPut**
> string SubaccountsRegenApiKeyBySubaccountIdPut (int? subaccountId)

Regenerate an API Key

Regenerate an API Key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SubaccountsRegenApiKeyBySubaccountIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubaccountApi();
            var subaccountId = 56;  // int? | ID of subaccount to regenerate API key for

            try
            {
                // Regenerate an API Key
                string result = apiInstance.SubaccountsRegenApiKeyBySubaccountIdPut(subaccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubaccountApi.SubaccountsRegenApiKeyBySubaccountIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subaccountId** | **int?**| ID of subaccount to regenerate API key for | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

