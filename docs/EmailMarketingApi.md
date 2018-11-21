# IO.ClickSend.ClickSend.Api.EmailMarketingApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AllowedEmailAddressGet**](EmailMarketingApi.md#allowedemailaddressget) | **GET** /email/addresses | Get all email addresses
[**AllowedEmailAddressPost**](EmailMarketingApi.md#allowedemailaddresspost) | **POST** /email/addresses | Create allowed Email Address
[**CancelEmailCampaignPut**](EmailMarketingApi.md#cancelemailcampaignput) | **PUT** /email-campaigns/{email_campaign_id}/cancel | Cancel email campaign
[**EmailCampaignGet**](EmailMarketingApi.md#emailcampaignget) | **GET** /email-campaigns/{email_campaign_id} | Get specific email campaign
[**EmailCampaignHistoryExportGet**](EmailMarketingApi.md#emailcampaignhistoryexportget) | **GET** /email-campaigns/{email_campaign_id}/history/export | Export specific email campaign history
[**EmailCampaignHistoryGet**](EmailMarketingApi.md#emailcampaignhistoryget) | **GET** /email-campaigns/{email_campaign_id}/history | Get specific email campaign history
[**EmailCampaignPost**](EmailMarketingApi.md#emailcampaignpost) | **POST** /email-campaigns/send | Send email campaign
[**EmailCampaignPricePost**](EmailMarketingApi.md#emailcampaignpricepost) | **POST** /email-campaigns/price | Calculate email campaign price
[**EmailCampaignPut**](EmailMarketingApi.md#emailcampaignput) | **PUT** /email-campaigns/{email_campaign_id} | Edit email campaign
[**EmailCampaignsGet**](EmailMarketingApi.md#emailcampaignsget) | **GET** /email-campaigns | Get all email campaigns
[**SendVerificationTokenGet**](EmailMarketingApi.md#sendverificationtokenget) | **PUT** /email/address-verify/{email_address_id}/send | Send verification token
[**SpecificAllowedEmailAddressDelete**](EmailMarketingApi.md#specificallowedemailaddressdelete) | **DELETE** /email/addresses/{email_address_id} | Delete specific email address
[**SpecificAllowedEmailAddressGet**](EmailMarketingApi.md#specificallowedemailaddressget) | **GET** /email/addresses/{email_address_id} | Get specific email address
[**VerifyAllowedEmailAddressGet**](EmailMarketingApi.md#verifyallowedemailaddressget) | **PUT** /email/address-verify/{email_address_id}/verify/{activation_token} | Verify email address using verification token


<a name="allowedemailaddressget"></a>
# **AllowedEmailAddressGet**
> string AllowedEmailAddressGet (int? page = null, int? limit = null)

Get all email addresses

Get all email addresses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AllowedEmailAddressGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all email addresses
                string result = apiInstance.AllowedEmailAddressGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.AllowedEmailAddressGet: " + e.Message );
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

<a name="allowedemailaddresspost"></a>
# **AllowedEmailAddressPost**
> string AllowedEmailAddressPost (EmailAddress emailAddress = null)

Create allowed Email Address

Create allowed Email Address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class AllowedEmailAddressPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailAddress = new EmailAddress(); // EmailAddress |  (optional) 

            try
            {
                // Create allowed Email Address
                string result = apiInstance.AllowedEmailAddressPost(emailAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.AllowedEmailAddressPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | [**EmailAddress**](EmailAddress.md)|  | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelemailcampaignput"></a>
# **CancelEmailCampaignPut**
> string CancelEmailCampaignPut (int? emailCampaignId)

Cancel email campaign

Cancel email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class CancelEmailCampaignPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaignId = 56;  // int? | Allowed email campaign id

            try
            {
                // Cancel email campaign
                string result = apiInstance.CancelEmailCampaignPut(emailCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.CancelEmailCampaignPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignId** | **int?**| Allowed email campaign id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignget"></a>
# **EmailCampaignGet**
> string EmailCampaignGet (int? emailCampaignId)

Get specific email campaign

Get specific email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaignId = 56;  // int? | Allowed email campaign id

            try
            {
                // Get specific email campaign
                string result = apiInstance.EmailCampaignGet(emailCampaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignId** | **int?**| Allowed email campaign id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignhistoryexportget"></a>
# **EmailCampaignHistoryExportGet**
> string EmailCampaignHistoryExportGet (int? emailCampaignId, int? dateFrom = null, int? dateTo = null)

Export specific email campaign history

Export specific email campaign history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignHistoryExportGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaignId = 56;  // int? | Allowed email campaign id
            var dateFrom = 56;  // int? | Start date (optional) 
            var dateTo = 56;  // int? | End date (optional) 

            try
            {
                // Export specific email campaign history
                string result = apiInstance.EmailCampaignHistoryExportGet(emailCampaignId, dateFrom, dateTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignHistoryExportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignId** | **int?**| Allowed email campaign id | 
 **dateFrom** | **int?**| Start date | [optional] 
 **dateTo** | **int?**| End date | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignhistoryget"></a>
# **EmailCampaignHistoryGet**
> string EmailCampaignHistoryGet (int? emailCampaignId, int? dateFrom = null, int? dateTo = null, int? page = null, int? limit = null)

Get specific email campaign history

Get specific email campaign history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaignId = 56;  // int? | Allowed email campaign id
            var dateFrom = 56;  // int? | Start date (optional) 
            var dateTo = 56;  // int? | End date (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get specific email campaign history
                string result = apiInstance.EmailCampaignHistoryGet(emailCampaignId, dateFrom, dateTo, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignId** | **int?**| Allowed email campaign id | 
 **dateFrom** | **int?**| Start date | [optional] 
 **dateTo** | **int?**| End date | [optional] 
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

<a name="emailcampaignpost"></a>
# **EmailCampaignPost**
> string EmailCampaignPost (EmailCampaign emailCampaign)

Send email campaign

Send email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaign = new EmailCampaign(); // EmailCampaign | Email model

            try
            {
                // Send email campaign
                string result = apiInstance.EmailCampaignPost(emailCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignpricepost"></a>
# **EmailCampaignPricePost**
> string EmailCampaignPricePost (EmailCampaign emailCampaign)

Calculate email campaign price

Calculate email campaign price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaign = new EmailCampaign(); // EmailCampaign | Email model

            try
            {
                // Calculate email campaign price
                string result = apiInstance.EmailCampaignPricePost(emailCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignput"></a>
# **EmailCampaignPut**
> string EmailCampaignPut (int? emailCampaignId, EmailCampaign emailCampaign)

Edit email campaign

Edit email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailCampaignId = 56;  // int? | Allowed email campaign id
            var emailCampaign = new EmailCampaign(); // EmailCampaign | Email model

            try
            {
                // Edit email campaign
                string result = apiInstance.EmailCampaignPut(emailCampaignId, emailCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignId** | **int?**| Allowed email campaign id | 
 **emailCampaign** | [**EmailCampaign**](EmailCampaign.md)| Email model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailcampaignsget"></a>
# **EmailCampaignsGet**
> string EmailCampaignsGet (int? page = null, int? limit = null)

Get all email campaigns

Get all email campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailCampaignsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all email campaigns
                string result = apiInstance.EmailCampaignsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.EmailCampaignsGet: " + e.Message );
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

<a name="sendverificationtokenget"></a>
# **SendVerificationTokenGet**
> string SendVerificationTokenGet (int? emailAddressId)

Send verification token

Send verification token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SendVerificationTokenGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailAddressId = 56;  // int? | Allowed email address id

            try
            {
                // Send verification token
                string result = apiInstance.SendVerificationTokenGet(emailAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.SendVerificationTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddressId** | **int?**| Allowed email address id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specificallowedemailaddressdelete"></a>
# **SpecificAllowedEmailAddressDelete**
> string SpecificAllowedEmailAddressDelete (int? emailAddressId)

Delete specific email address

Delete specific email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SpecificAllowedEmailAddressDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailAddressId = 56;  // int? | Allowed email address id

            try
            {
                // Delete specific email address
                string result = apiInstance.SpecificAllowedEmailAddressDelete(emailAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.SpecificAllowedEmailAddressDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddressId** | **int?**| Allowed email address id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="specificallowedemailaddressget"></a>
# **SpecificAllowedEmailAddressGet**
> string SpecificAllowedEmailAddressGet (int? emailAddressId)

Get specific email address

Get specific email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class SpecificAllowedEmailAddressGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailAddressId = 56;  // int? | Allowed email address id

            try
            {
                // Get specific email address
                string result = apiInstance.SpecificAllowedEmailAddressGet(emailAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.SpecificAllowedEmailAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddressId** | **int?**| Allowed email address id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyallowedemailaddressget"></a>
# **VerifyAllowedEmailAddressGet**
> string VerifyAllowedEmailAddressGet (int? emailAddressId, string activationToken)

Verify email address using verification token

Verify email address using verification token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VerifyAllowedEmailAddressGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EmailMarketingApi();
            var emailAddressId = 56;  // int? | Allowed email address id
            var activationToken = activationToken_example;  // string | Your activation token.

            try
            {
                // Verify email address using verification token
                string result = apiInstance.VerifyAllowedEmailAddressGet(emailAddressId, activationToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailMarketingApi.VerifyAllowedEmailAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddressId** | **int?**| Allowed email address id | 
 **activationToken** | **string**| Your activation token. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

