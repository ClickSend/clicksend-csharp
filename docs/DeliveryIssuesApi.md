# IO.ClickSend.ClickSend.Api.DeliveryIssuesApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeliveryIssuesGet**](DeliveryIssuesApi.md#deliveryissuesget) | **GET** /delivery-issues | Get all delivery issues
[**DeliveryIssuesPost**](DeliveryIssuesApi.md#deliveryissuespost) | **POST** /delivery-issues | Create delivery Issue


<a name="deliveryissuesget"></a>
# **DeliveryIssuesGet**
> string DeliveryIssuesGet (int? page = null, int? limit = null)

Get all delivery issues

Get all delivery issues

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class DeliveryIssuesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryIssuesApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all delivery issues
                string result = apiInstance.DeliveryIssuesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryIssuesApi.DeliveryIssuesGet: " + e.Message );
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

<a name="deliveryissuespost"></a>
# **DeliveryIssuesPost**
> string DeliveryIssuesPost (DeliveryIssue deliveryIssue)

Create delivery Issue

Create delivery Issue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class DeliveryIssuesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryIssuesApi();
            var deliveryIssue = new DeliveryIssue(); // DeliveryIssue | DeliveryIssue model

            try
            {
                // Create delivery Issue
                string result = apiInstance.DeliveryIssuesPost(deliveryIssue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryIssuesApi.DeliveryIssuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryIssue** | [**DeliveryIssue**](DeliveryIssue.md)| DeliveryIssue model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

