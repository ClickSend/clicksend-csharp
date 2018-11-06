# IO.ClickSend.ClickSend.Api.ResellerAccountApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResellerAccountsByClientUserIdGet**](ResellerAccountApi.md#reselleraccountsbyclientuseridget) | **GET** /reseller/accounts/{client_user_id} | Get Reseller clients Account
[**ResellerAccountsByClientUserIdPut**](ResellerAccountApi.md#reselleraccountsbyclientuseridput) | **PUT** /reseller/accounts/{client_user_id} | Update Reseller clients Account
[**ResellerAccountsGet**](ResellerAccountApi.md#reselleraccountsget) | **GET** /reseller/accounts | Get list of reseller accounts
[**ResellerAccountsPost**](ResellerAccountApi.md#reselleraccountspost) | **POST** /reseller/accounts | Create reseller account


<a name="reselleraccountsbyclientuseridget"></a>
# **ResellerAccountsByClientUserIdGet**
> string ResellerAccountsByClientUserIdGet (int? clientUserId)

Get Reseller clients Account

Get Reseller clients Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ResellerAccountsByClientUserIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ResellerAccountApi();
            var clientUserId = 56;  // int? | User ID of client

            try
            {
                // Get Reseller clients Account
                string result = apiInstance.ResellerAccountsByClientUserIdGet(clientUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerAccountApi.ResellerAccountsByClientUserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientUserId** | **int?**| User ID of client | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reselleraccountsbyclientuseridput"></a>
# **ResellerAccountsByClientUserIdPut**
> string ResellerAccountsByClientUserIdPut (int? clientUserId, ResellerAccount resellerAccount)

Update Reseller clients Account

Update Reseller clients Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ResellerAccountsByClientUserIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ResellerAccountApi();
            var clientUserId = 56;  // int? | User ID of client
            var resellerAccount = new ResellerAccount(); // ResellerAccount | ResellerAccount model

            try
            {
                // Update Reseller clients Account
                string result = apiInstance.ResellerAccountsByClientUserIdPut(clientUserId, resellerAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerAccountApi.ResellerAccountsByClientUserIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientUserId** | **int?**| User ID of client | 
 **resellerAccount** | [**ResellerAccount**](ResellerAccount.md)| ResellerAccount model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reselleraccountsget"></a>
# **ResellerAccountsGet**
> string ResellerAccountsGet (int? page = null, int? limit = null)

Get list of reseller accounts

Get list of reseller accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ResellerAccountsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ResellerAccountApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of reseller accounts
                string result = apiInstance.ResellerAccountsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerAccountApi.ResellerAccountsGet: " + e.Message );
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

<a name="reselleraccountspost"></a>
# **ResellerAccountsPost**
> string ResellerAccountsPost (ResellerAccount resellerAccount)

Create reseller account

Create reseller account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ResellerAccountsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ResellerAccountApi();
            var resellerAccount = new ResellerAccount(); // ResellerAccount | ResellerAccount model

            try
            {
                // Create reseller account
                string result = apiInstance.ResellerAccountsPost(resellerAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerAccountApi.ResellerAccountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resellerAccount** | [**ResellerAccount**](ResellerAccount.md)| ResellerAccount model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

