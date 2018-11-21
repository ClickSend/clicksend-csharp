# IO.ClickSend.ClickSend.Api.UserEmailTemplatesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailTemplateDelete**](UserEmailTemplatesApi.md#emailtemplatedelete) | **DELETE** /email/templates/{template_id} | Delete user email template
[**EmailTemplateGet**](UserEmailTemplatesApi.md#emailtemplateget) | **GET** /email/templates/{template_id} | Get specific user email template
[**EmailTemplatePost**](UserEmailTemplatesApi.md#emailtemplatepost) | **POST** /email/templates | Create email template
[**EmailTemplatePut**](UserEmailTemplatesApi.md#emailtemplateput) | **PUT** /email/templates/{template_id} | Update email template
[**EmailTemplatesGet**](UserEmailTemplatesApi.md#emailtemplatesget) | **GET** /email/templates | Get all user email templates


<a name="emailtemplatedelete"></a>
# **EmailTemplateDelete**
> string EmailTemplateDelete (int? templateId)

Delete user email template

Delete user email template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailTemplateDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserEmailTemplatesApi();
            var templateId = 56;  // int? | Email template id

            try
            {
                // Delete user email template
                string result = apiInstance.EmailTemplateDelete(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserEmailTemplatesApi.EmailTemplateDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **int?**| Email template id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplateget"></a>
# **EmailTemplateGet**
> string EmailTemplateGet (int? templateId)

Get specific user email template

Get specific user email templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailTemplateGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserEmailTemplatesApi();
            var templateId = 56;  // int? | Email template id

            try
            {
                // Get specific user email template
                string result = apiInstance.EmailTemplateGet(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserEmailTemplatesApi.EmailTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **int?**| Email template id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatepost"></a>
# **EmailTemplatePost**
> string EmailTemplatePost (EmailTemplateNew emailTemplate)

Create email template

Create email template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailTemplatePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserEmailTemplatesApi();
            var emailTemplate = new EmailTemplateNew(); // EmailTemplateNew | Email template model

            try
            {
                // Create email template
                string result = apiInstance.EmailTemplatePost(emailTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserEmailTemplatesApi.EmailTemplatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplate** | [**EmailTemplateNew**](EmailTemplateNew.md)| Email template model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplateput"></a>
# **EmailTemplatePut**
> string EmailTemplatePut (int? templateId, EmailTemplateUpdate emailTemplate)

Update email template

Update email template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailTemplatePutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserEmailTemplatesApi();
            var templateId = 56;  // int? | Email template id
            var emailTemplate = new EmailTemplateUpdate(); // EmailTemplateUpdate | Email template model

            try
            {
                // Update email template
                string result = apiInstance.EmailTemplatePut(templateId, emailTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserEmailTemplatesApi.EmailTemplatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **int?**| Email template id | 
 **emailTemplate** | [**EmailTemplateUpdate**](EmailTemplateUpdate.md)| Email template model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatesget"></a>
# **EmailTemplatesGet**
> string EmailTemplatesGet (int? page = null, int? limit = null)

Get all user email templates

Get all user email templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class EmailTemplatesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UserEmailTemplatesApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all user email templates
                string result = apiInstance.EmailTemplatesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserEmailTemplatesApi.EmailTemplatesGet: " + e.Message );
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

