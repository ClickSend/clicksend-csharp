# IO.ClickSend.ClickSend.Api.EmailToSmsApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SmsEmailSmsGet**](EmailToSmsApi.md#smsemailsmsget) | **GET** /sms/email-sms | Get list of email to sms allowed addresses
[**SmsEmailSmsPost**](EmailToSmsApi.md#smsemailsmspost) | **POST** /sms/email-sms | Create email to sms allowed address
[**SmsEmailSmsStrippedStringDelete**](EmailToSmsApi.md#smsemailsmsstrippedstringdelete) | **DELETE** /sms/email-sms-stripped-strings/{rule_id} | Delete email to sms stripped string rule
[**SmsEmailSmsStrippedStringGet**](EmailToSmsApi.md#smsemailsmsstrippedstringget) | **GET** /sms/email-sms-stripped-strings/{rule_id} | Get email to sms stripped string rule
[**SmsEmailSmsStrippedStringPost**](EmailToSmsApi.md#smsemailsmsstrippedstringpost) | **POST** /sms/email-sms-stripped-strings | Create email to sms stripped string rule
[**SmsEmailSmsStrippedStringPut**](EmailToSmsApi.md#smsemailsmsstrippedstringput) | **PUT** /sms/email-sms-stripped-strings/{rule_id} | Update email to sms stripped string rule
[**SmsEmailSmsStrippedStringsGet**](EmailToSmsApi.md#smsemailsmsstrippedstringsget) | **GET** /sms/email-sms-stripped-strings | Get list of email to sms stripped string rules


<a name="smsemailsmsget"></a>
# **SmsEmailSmsGet**
> string SmsEmailSmsGet (int? page = null, int? limit = null)

Get list of email to sms allowed addresses

Get list of email to sms allowed addresses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of email to sms allowed addresses
                string result = apiInstance.SmsEmailSmsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsGet: " + e.Message );
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

<a name="smsemailsmspost"></a>
# **SmsEmailSmsPost**
> string SmsEmailSmsPost (EmailSMSAddress emailSmsAddress)

Create email to sms allowed address

Create email to sms allowed address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var emailSmsAddress = new EmailSMSAddress(); // EmailSMSAddress | EmailSMSAddress model

            try
            {
                // Create email to sms allowed address
                string result = apiInstance.SmsEmailSmsPost(emailSmsAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailSmsAddress** | [**EmailSMSAddress**](EmailSMSAddress.md)| EmailSMSAddress model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsemailsmsstrippedstringdelete"></a>
# **SmsEmailSmsStrippedStringDelete**
> string SmsEmailSmsStrippedStringDelete (int? ruleId)

Delete email to sms stripped string rule

Delete email to sms stripped string rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsStrippedStringDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var ruleId = 56;  // int? | Your rule id

            try
            {
                // Delete email to sms stripped string rule
                string result = apiInstance.SmsEmailSmsStrippedStringDelete(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsStrippedStringDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **int?**| Your rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsemailsmsstrippedstringget"></a>
# **SmsEmailSmsStrippedStringGet**
> string SmsEmailSmsStrippedStringGet (int? ruleId)

Get email to sms stripped string rule

Get email to sms stripped string rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsStrippedStringGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var ruleId = 56;  // int? | Your rule id

            try
            {
                // Get email to sms stripped string rule
                string result = apiInstance.SmsEmailSmsStrippedStringGet(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsStrippedStringGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ruleId** | **int?**| Your rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsemailsmsstrippedstringpost"></a>
# **SmsEmailSmsStrippedStringPost**
> string SmsEmailSmsStrippedStringPost (StrippedString strippedString)

Create email to sms stripped string rule

Create email to sms stripped string rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsStrippedStringPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var strippedString = new StrippedString(); // StrippedString | StrippedString model

            try
            {
                // Create email to sms stripped string rule
                string result = apiInstance.SmsEmailSmsStrippedStringPost(strippedString);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsStrippedStringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **strippedString** | [**StrippedString**](StrippedString.md)| StrippedString model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsemailsmsstrippedstringput"></a>
# **SmsEmailSmsStrippedStringPut**
> string SmsEmailSmsStrippedStringPut (StrippedString strippedString, int? ruleId)

Update email to sms stripped string rule

Update email to sms stripped string rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsStrippedStringPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var strippedString = new StrippedString(); // StrippedString | StrippedString model
            var ruleId = 56;  // int? | Your rule id

            try
            {
                // Update email to sms stripped string rule
                string result = apiInstance.SmsEmailSmsStrippedStringPut(strippedString, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsStrippedStringPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **strippedString** | [**StrippedString**](StrippedString.md)| StrippedString model | 
 **ruleId** | **int?**| Your rule id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smsemailsmsstrippedstringsget"></a>
# **SmsEmailSmsStrippedStringsGet**
> string SmsEmailSmsStrippedStringsGet (int? page = null, int? limit = null)

Get list of email to sms stripped string rules

Get list of email to sms stripped string rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SmsEmailSmsStrippedStringsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailToSmsApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of email to sms stripped string rules
                string result = apiInstance.SmsEmailSmsStrippedStringsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailToSmsApi.SmsEmailSmsStrippedStringsGet: " + e.Message );
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

