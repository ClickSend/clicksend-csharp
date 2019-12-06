# IO.ClickSend.ClickSend.Api.AccountApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountGet**](AccountApi.md#accountget) | **GET** /account | Get account information
[**AccountPost**](AccountApi.md#accountpost) | **POST** /account | Create a new account
[**AccountUseageBySubaccountGet**](AccountApi.md#accountuseagebysubaccountget) | **GET** /account/usage/{year}/{month}/subaccount | Get account useage by subaccount
[**AccountVerifySendPut**](AccountApi.md#accountverifysendput) | **PUT** /account-verify/send | Send account activation token
[**AccountVerifyVerifyByActivationTokenPut**](AccountApi.md#accountverifyverifybyactivationtokenput) | **PUT** /account-verify/verify/{activation_token} | Verify new account
[**ForgotPasswordPut**](AccountApi.md#forgotpasswordput) | **PUT** /forgot-password | Forgot password
[**ForgotPasswordVerifyPut**](AccountApi.md#forgotpasswordverifyput) | **PUT** /forgot-password/verify | Verify forgot password
[**ForgotUsernamePut**](AccountApi.md#forgotusernameput) | **PUT** /forgot-username | Forgot username


<a name="accountget"></a>
# **AccountGet**
> string AccountGet ()

Get account information

Get account details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AccountGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();

            try
            {
                // Get account information
                string result = apiInstance.AccountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountGet: " + e.Message );
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

<a name="accountpost"></a>
# **AccountPost**
> string AccountPost (Account account)

Create a new account

Create An Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AccountPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var account = new Account(); // Account | Account model

            try
            {
                // Create a new account
                string result = apiInstance.AccountPost(account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | [**Account**](Account.md)| Account model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuseagebysubaccountget"></a>
# **AccountUseageBySubaccountGet**
> string AccountUseageBySubaccountGet (int? year, int? month)

Get account useage by subaccount

Get account useage by subaccount

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AccountUseageBySubaccountGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var year = 56;  // int? | Year to filter by (yyyy)
            var month = 56;  // int? | Month to filter by (mm)

            try
            {
                // Get account useage by subaccount
                string result = apiInstance.AccountUseageBySubaccountGet(year, month);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountUseageBySubaccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year to filter by (yyyy) | 
 **month** | **int?**| Month to filter by (mm) | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountverifysendput"></a>
# **AccountVerifySendPut**
> string AccountVerifySendPut (AccountVerify accountVerify)

Send account activation token

Send account activation token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AccountVerifySendPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var accountVerify = new AccountVerify(); // AccountVerify | Account details

            try
            {
                // Send account activation token
                string result = apiInstance.AccountVerifySendPut(accountVerify);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountVerifySendPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountVerify** | [**AccountVerify**](AccountVerify.md)| Account details | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountverifyverifybyactivationtokenput"></a>
# **AccountVerifyVerifyByActivationTokenPut**
> string AccountVerifyVerifyByActivationTokenPut (int? activationToken)

Verify new account

Verify new account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AccountVerifyVerifyByActivationTokenPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var activationToken = 56;  // int? | 

            try
            {
                // Verify new account
                string result = apiInstance.AccountVerifyVerifyByActivationTokenPut(activationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountVerifyVerifyByActivationTokenPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activationToken** | **int?**|  | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forgotpasswordput"></a>
# **ForgotPasswordPut**
> string ForgotPasswordPut (ForgotPassword forgotPassword = null)

Forgot password

Forgot password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ForgotPasswordPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var forgotPassword = new ForgotPassword(); // ForgotPassword |  (optional) 

            try
            {
                // Forgot password
                string result = apiInstance.ForgotPasswordPut(forgotPassword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.ForgotPasswordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **forgotPassword** | [**ForgotPassword**](ForgotPassword.md)|  | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forgotpasswordverifyput"></a>
# **ForgotPasswordVerifyPut**
> string ForgotPasswordVerifyPut (AccountForgotPasswordVerify verifyPassword)

Verify forgot password

Verify forgot password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ForgotPasswordVerifyPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();
            var verifyPassword = new AccountForgotPasswordVerify(); // AccountForgotPasswordVerify | verifyPassword data

            try
            {
                // Verify forgot password
                string result = apiInstance.ForgotPasswordVerifyPut(verifyPassword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.ForgotPasswordVerifyPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verifyPassword** | [**AccountForgotPasswordVerify**](AccountForgotPasswordVerify.md)| verifyPassword data | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forgotusernameput"></a>
# **ForgotUsernamePut**
> string ForgotUsernamePut (ForgotUsername forgotUsername = null)

Forgot username

Forgot username

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ForgotUsernamePutExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var forgotUsername = new ForgotUsername(); // ForgotUsername |  (optional) 

            try
            {
                // Forgot username
                string result = apiInstance.ForgotUsernamePut(forgotUsername);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.ForgotUsernamePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **forgotUsername** | [**ForgotUsername**](ForgotUsername.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

