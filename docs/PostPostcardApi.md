# IO.ClickSend.ClickSend.Api.PostPostcardApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostPostcardsHistoryExportGet**](PostPostcardApi.md#postpostcardshistoryexportget) | **GET** /post/postcards/history/export | Export postcard history to a CSV file
[**PostPostcardsHistoryGet**](PostPostcardApi.md#postpostcardshistoryget) | **GET** /post/postcards/history | Retrieve the history of postcards sent or scheduled
[**PostPostcardsPricePost**](PostPostcardApi.md#postpostcardspricepost) | **POST** /post/postcards/price | Calculate price for sending one or more postcards
[**PostPostcardsSendPost**](PostPostcardApi.md#postpostcardssendpost) | **POST** /post/postcards/send | Send one or more postcards


<a name="postpostcardshistoryexportget"></a>
# **PostPostcardsHistoryExportGet**
> string PostPostcardsHistoryExportGet (string filename)

Export postcard history to a CSV file

Export postcard history to a CSV file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostPostcardsHistoryExportGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostPostcardApi();
            var filename = filename_example;  // string | Filename to export to

            try
            {
                // Export postcard history to a CSV file
                string result = apiInstance.PostPostcardsHistoryExportGet(filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostPostcardApi.PostPostcardsHistoryExportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| Filename to export to | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpostcardshistoryget"></a>
# **PostPostcardsHistoryGet**
> string PostPostcardsHistoryGet (int? page = null, int? limit = null)

Retrieve the history of postcards sent or scheduled

Retrieve the history of postcards sent or scheduled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostPostcardsHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostPostcardApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Retrieve the history of postcards sent or scheduled
                string result = apiInstance.PostPostcardsHistoryGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostPostcardApi.PostPostcardsHistoryGet: " + e.Message );
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

<a name="postpostcardspricepost"></a>
# **PostPostcardsPricePost**
> string PostPostcardsPricePost (PostPostcard postPostcards)

Calculate price for sending one or more postcards

Calculate price for sending one or more postcards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostPostcardsPricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostPostcardApi();
            var postPostcards = new PostPostcard(); // PostPostcard | PostPostcard model

            try
            {
                // Calculate price for sending one or more postcards
                string result = apiInstance.PostPostcardsPricePost(postPostcards);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostPostcardApi.PostPostcardsPricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postPostcards** | [**PostPostcard**](PostPostcard.md)| PostPostcard model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpostcardssendpost"></a>
# **PostPostcardsSendPost**
> string PostPostcardsSendPost (PostPostcard postPostcards)

Send one or more postcards

Send one or more postcards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostPostcardsSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostPostcardApi();
            var postPostcards = new PostPostcard(); // PostPostcard | PostPostcard model

            try
            {
                // Send one or more postcards
                string result = apiInstance.PostPostcardsSendPost(postPostcards);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostPostcardApi.PostPostcardsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postPostcards** | [**PostPostcard**](PostPostcard.md)| PostPostcard model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

