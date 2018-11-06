# IO.ClickSend.ClickSend.Api.PostReturnAddressApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostReturnAddressesByReturnAddressIdDelete**](PostReturnAddressApi.md#postreturnaddressesbyreturnaddressiddelete) | **DELETE** /post/return-addresses/{return_address_id} | Delete specific post return address
[**PostReturnAddressesByReturnAddressIdGet**](PostReturnAddressApi.md#postreturnaddressesbyreturnaddressidget) | **GET** /post/return-addresses/{return_address_id} | Get specific post return address
[**PostReturnAddressesByReturnAddressIdPut**](PostReturnAddressApi.md#postreturnaddressesbyreturnaddressidput) | **PUT** /post/return-addresses/{return_address_id} | Update post return address
[**PostReturnAddressesGet**](PostReturnAddressApi.md#postreturnaddressesget) | **GET** /post/return-addresses | Get list of post return addresses
[**PostReturnAddressesPost**](PostReturnAddressApi.md#postreturnaddressespost) | **POST** /post/return-addresses | Create post return address


<a name="postreturnaddressesbyreturnaddressiddelete"></a>
# **PostReturnAddressesByReturnAddressIdDelete**
> string PostReturnAddressesByReturnAddressIdDelete (int? returnAddressId)

Delete specific post return address

Delete specific post return address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostReturnAddressesByReturnAddressIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostReturnAddressApi();
            var returnAddressId = 56;  // int? | Return address ID

            try
            {
                // Delete specific post return address
                string result = apiInstance.PostReturnAddressesByReturnAddressIdDelete(returnAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostReturnAddressApi.PostReturnAddressesByReturnAddressIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnAddressId** | **int?**| Return address ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postreturnaddressesbyreturnaddressidget"></a>
# **PostReturnAddressesByReturnAddressIdGet**
> string PostReturnAddressesByReturnAddressIdGet (int? returnAddressId)

Get specific post return address

Get specific post return address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostReturnAddressesByReturnAddressIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostReturnAddressApi();
            var returnAddressId = 56;  // int? | Return address ID

            try
            {
                // Get specific post return address
                string result = apiInstance.PostReturnAddressesByReturnAddressIdGet(returnAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostReturnAddressApi.PostReturnAddressesByReturnAddressIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnAddressId** | **int?**| Return address ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postreturnaddressesbyreturnaddressidput"></a>
# **PostReturnAddressesByReturnAddressIdPut**
> string PostReturnAddressesByReturnAddressIdPut (int? returnAddressId, Address returnAddress)

Update post return address

Update post return address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostReturnAddressesByReturnAddressIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostReturnAddressApi();
            var returnAddressId = 56;  // int? | Return address ID
            var returnAddress = new Address(); // Address | Address model

            try
            {
                // Update post return address
                string result = apiInstance.PostReturnAddressesByReturnAddressIdPut(returnAddressId, returnAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostReturnAddressApi.PostReturnAddressesByReturnAddressIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnAddressId** | **int?**| Return address ID | 
 **returnAddress** | [**Address**](Address.md)| Address model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postreturnaddressesget"></a>
# **PostReturnAddressesGet**
> string PostReturnAddressesGet (int? page = null, int? limit = null)

Get list of post return addresses

Get list of post return addresses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostReturnAddressesGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostReturnAddressApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get list of post return addresses
                string result = apiInstance.PostReturnAddressesGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostReturnAddressApi.PostReturnAddressesGet: " + e.Message );
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

<a name="postreturnaddressespost"></a>
# **PostReturnAddressesPost**
> string PostReturnAddressesPost (Address returnAddress)

Create post return address

Create post return address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class PostReturnAddressesPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PostReturnAddressApi();
            var returnAddress = new Address(); // Address | Address model

            try
            {
                // Create post return address
                string result = apiInstance.PostReturnAddressesPost(returnAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostReturnAddressApi.PostReturnAddressesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnAddress** | [**Address**](Address.md)| Address model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

