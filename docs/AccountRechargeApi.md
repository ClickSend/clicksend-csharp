# IO.ClickSend.ClickSend.Api.AccountRechargeApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RechargeCreditCardGet**](AccountRechargeApi.md#rechargecreditcardget) | **GET** /recharge/credit-card | Get Credit Card info
[**RechargeCreditCardPut**](AccountRechargeApi.md#rechargecreditcardput) | **PUT** /recharge/credit-card | Update credit card info
[**RechargePackagesGet**](AccountRechargeApi.md#rechargepackagesget) | **GET** /recharge/packages | Get list of all packages
[**RechargePurchaseByPackageIdPut**](AccountRechargeApi.md#rechargepurchasebypackageidput) | **PUT** /recharge/purchase/{package_id} | Purchase a package
[**RechargeTransactionsByTransactionIdGet**](AccountRechargeApi.md#rechargetransactionsbytransactionidget) | **GET** /recharge/transactions/{transaction_id} | Get specific Transaction
[**RechargeTransactionsGet**](AccountRechargeApi.md#rechargetransactionsget) | **GET** /recharge/transactions | Purchase a package


<a name="rechargecreditcardget"></a>
# **RechargeCreditCardGet**
> string RechargeCreditCardGet ()

Get Credit Card info

Get Credit Card info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargeCreditCardGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();

            try
            {
                // Get Credit Card info
                string result = apiInstance.RechargeCreditCardGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargeCreditCardGet: " + e.Message );
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

<a name="rechargecreditcardput"></a>
# **RechargeCreditCardPut**
> string RechargeCreditCardPut (CreditCard creditCard)

Update credit card info

Update credit card info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargeCreditCardPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();
            var creditCard = new CreditCard(); // CreditCard | CreditCard model

            try
            {
                // Update credit card info
                string result = apiInstance.RechargeCreditCardPut(creditCard);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargeCreditCardPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creditCard** | [**CreditCard**](CreditCard.md)| CreditCard model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rechargepackagesget"></a>
# **RechargePackagesGet**
> string RechargePackagesGet (string country = null)

Get list of all packages

Get list of all packages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargePackagesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();
            var country = country_example;  // string | Country code (optional) 

            try
            {
                // Get list of all packages
                string result = apiInstance.RechargePackagesGet(country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargePackagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**| Country code | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rechargepurchasebypackageidput"></a>
# **RechargePurchaseByPackageIdPut**
> string RechargePurchaseByPackageIdPut (int? packageId)

Purchase a package

Purchase a package

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargePurchaseByPackageIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();
            var packageId = 56;  // int? | ID of package to purchase

            try
            {
                // Purchase a package
                string result = apiInstance.RechargePurchaseByPackageIdPut(packageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargePurchaseByPackageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageId** | **int?**| ID of package to purchase | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rechargetransactionsbytransactionidget"></a>
# **RechargeTransactionsByTransactionIdGet**
> string RechargeTransactionsByTransactionIdGet (string transactionId)

Get specific Transaction

Get specific Transaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargeTransactionsByTransactionIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();
            var transactionId = transactionId_example;  // string | ID of transaction to retrieve

            try
            {
                // Get specific Transaction
                string result = apiInstance.RechargeTransactionsByTransactionIdGet(transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargeTransactionsByTransactionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**| ID of transaction to retrieve | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rechargetransactionsget"></a>
# **RechargeTransactionsGet**
> string RechargeTransactionsGet (int? page = null, int? limit = null)

Purchase a package

Get all transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class RechargeTransactionsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountRechargeApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Purchase a package
                string result = apiInstance.RechargeTransactionsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountRechargeApi.RechargeTransactionsGet: " + e.Message );
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

