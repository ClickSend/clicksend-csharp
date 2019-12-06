# IO.ClickSend.ClickSend.Api.TransferCreditApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResellerTransferCreditPut**](TransferCreditApi.md#resellertransfercreditput) | **PUT** /reseller/transfer-credit | Transfer Credit


<a name="resellertransfercreditput"></a>
# **ResellerTransferCreditPut**
> string ResellerTransferCreditPut (ResellerAccountTransferCredit resellerAccountTransferCredit)

Transfer Credit

Transfer Credit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ResellerTransferCreditPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TransferCreditApi();
            var resellerAccountTransferCredit = new ResellerAccountTransferCredit(); // ResellerAccountTransferCredit | ResellerAccountTransferCredit model

            try
            {
                // Transfer Credit
                string result = apiInstance.ResellerTransferCreditPut(resellerAccountTransferCredit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferCreditApi.ResellerTransferCreditPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resellerAccountTransferCredit** | [**ResellerAccountTransferCredit**](ResellerAccountTransferCredit.md)| ResellerAccountTransferCredit model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

