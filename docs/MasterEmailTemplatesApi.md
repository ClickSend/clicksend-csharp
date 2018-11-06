# IO.ClickSend.ClickSend.Api.MasterEmailTemplatesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MasterEmailTemplateCategoriesGet**](MasterEmailTemplatesApi.md#masteremailtemplatecategoriesget) | **GET** /email/master-templates-categories | Get all master email template categories
[**MasterEmailTemplateCategoryGet**](MasterEmailTemplatesApi.md#masteremailtemplatecategoryget) | **GET** /email/master-templates-categories/{category_id} | Get specific master email template category
[**MasterEmailTemplateGet**](MasterEmailTemplatesApi.md#masteremailtemplateget) | **GET** /email/master-templates/{template_id} | Get specific master email template
[**MasterEmailTemplatesGet**](MasterEmailTemplatesApi.md#masteremailtemplatesget) | **GET** /email/master-templates | Get all master email templates
[**MasterEmailTemplatesInCategoryGet**](MasterEmailTemplatesApi.md#masteremailtemplatesincategoryget) | **GET** /email/master-templates-categories/{category_id}/master-templates | Get all master email templates in a category


<a name="masteremailtemplatecategoriesget"></a>
# **MasterEmailTemplateCategoriesGet**
> string MasterEmailTemplateCategoriesGet (int? page = null, int? limit = null)

Get all master email template categories

Get all master email template categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MasterEmailTemplateCategoriesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MasterEmailTemplatesApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all master email template categories
                string result = apiInstance.MasterEmailTemplateCategoriesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterEmailTemplatesApi.MasterEmailTemplateCategoriesGet: " + e.Message );
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

<a name="masteremailtemplatecategoryget"></a>
# **MasterEmailTemplateCategoryGet**
> string MasterEmailTemplateCategoryGet (int? categoryId)

Get specific master email template category

Get specific master email template category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MasterEmailTemplateCategoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MasterEmailTemplatesApi();
            var categoryId = 56;  // int? | Email category id

            try
            {
                // Get specific master email template category
                string result = apiInstance.MasterEmailTemplateCategoryGet(categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterEmailTemplatesApi.MasterEmailTemplateCategoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| Email category id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masteremailtemplateget"></a>
# **MasterEmailTemplateGet**
> string MasterEmailTemplateGet (int? templateId)

Get specific master email template

Get specific master email template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MasterEmailTemplateGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MasterEmailTemplatesApi();
            var templateId = 56;  // int? | Email template id

            try
            {
                // Get specific master email template
                string result = apiInstance.MasterEmailTemplateGet(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterEmailTemplatesApi.MasterEmailTemplateGet: " + e.Message );
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

<a name="masteremailtemplatesget"></a>
# **MasterEmailTemplatesGet**
> string MasterEmailTemplatesGet (int? page = null, int? limit = null)

Get all master email templates

Get all master email templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MasterEmailTemplatesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MasterEmailTemplatesApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all master email templates
                string result = apiInstance.MasterEmailTemplatesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterEmailTemplatesApi.MasterEmailTemplatesGet: " + e.Message );
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

<a name="masteremailtemplatesincategoryget"></a>
# **MasterEmailTemplatesInCategoryGet**
> string MasterEmailTemplatesInCategoryGet (int? categoryId, int? page = null, int? limit = null)

Get all master email templates in a category

Get all master email templates in a category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class MasterEmailTemplatesInCategoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MasterEmailTemplatesApi();
            var categoryId = 56;  // int? | Email category id
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all master email templates in a category
                string result = apiInstance.MasterEmailTemplatesInCategoryGet(categoryId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterEmailTemplatesApi.MasterEmailTemplatesInCategoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| Email category id | 
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

