# IO.ClickSend.ClickSend.Api.ReferralAccountApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReferralAccountsGet**](ReferralAccountApi.md#referralaccountsget) | **GET** /referral/accounts | Get all referral accounts


<a name="referralaccountsget"></a>
# **ReferralAccountsGet**
> string ReferralAccountsGet (int? page = null, int? limit = null)

Get all referral accounts

Get all referral accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ReferralAccountsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ReferralAccountApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all referral accounts
                string result = apiInstance.ReferralAccountsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReferralAccountApi.ReferralAccountsGet: " + e.Message );
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

