# IO.ClickSend.ClickSend.Api.ContactListApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListsByListIdDelete**](ContactListApi.md#listsbylistiddelete) | **DELETE** /lists/{list_id} | ListsByListIdDelete
[**ListsByListIdGet**](ContactListApi.md#listsbylistidget) | **GET** /lists/{list_id} | Get specific contact list
[**ListsByListIdPut**](ContactListApi.md#listsbylistidput) | **PUT** /lists/{list_id} | Update specific contact list
[**ListsGet**](ContactListApi.md#listsget) | **GET** /lists | Get all contact lists
[**ListsImportByListIdPost**](ContactListApi.md#listsimportbylistidpost) | **POST** /lists/{list_id}/import | Import contacts to list
[**ListsPost**](ContactListApi.md#listspost) | **POST** /lists | Create new contact list
[**ListsRemoveDuplicatesByListIdPut**](ContactListApi.md#listsremoveduplicatesbylistidput) | **PUT** /lists/{list_id}/remove-duplicates | Remove duplicate contacts


<a name="listsbylistiddelete"></a>
# **ListsByListIdDelete**
> string ListsByListIdDelete (int? listId)

ListsByListIdDelete

Delete a specific contact list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsByListIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var listId = 56;  // int? | List ID

            try
            {
                // ListsByListIdDelete
                string result = apiInstance.ListsByListIdDelete(listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsByListIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| List ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbylistidget"></a>
# **ListsByListIdGet**
> string ListsByListIdGet (int? listId)

Get specific contact list

Get specific contact list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsByListIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var listId = 56;  // int? | List ID

            try
            {
                // Get specific contact list
                string result = apiInstance.ListsByListIdGet(listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsByListIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| List ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsbylistidput"></a>
# **ListsByListIdPut**
> string ListsByListIdPut (int? listId, ContactList contactList)

Update specific contact list

Update specific contact list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsByListIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var listId = 56;  // int? | Your list id
            var contactList = new ContactList(); // ContactList | Contact list model

            try
            {
                // Update specific contact list
                string result = apiInstance.ListsByListIdPut(listId, contactList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsByListIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Your list id | 
 **contactList** | [**ContactList**](ContactList.md)| Contact list model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsget"></a>
# **ListsGet**
> string ListsGet (int? page = null, int? limit = null)

Get all contact lists

Get all contact lists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all contact lists
                string result = apiInstance.ListsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsGet: " + e.Message );
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

<a name="listsimportbylistidpost"></a>
# **ListsImportByListIdPost**
> string ListsImportByListIdPost (int? listId, ContactListImport _file)

Import contacts to list

Import contacts to list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsImportByListIdPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var listId = 56;  // int? | Your contact list id you want to access.
            var _file = new ContactListImport(); // ContactListImport | ContactListImport model

            try
            {
                // Import contacts to list
                string result = apiInstance.ListsImportByListIdPost(listId, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsImportByListIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Your contact list id you want to access. | 
 **_file** | [**ContactListImport**](ContactListImport.md)| ContactListImport model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspost"></a>
# **ListsPost**
> string ListsPost (ContactList contactList)

Create new contact list

Create new contact list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var contactList = new ContactList(); // ContactList | Contact list model

            try
            {
                // Create new contact list
                string result = apiInstance.ListsPost(contactList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactList** | [**ContactList**](ContactList.md)| Contact list model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsremoveduplicatesbylistidput"></a>
# **ListsRemoveDuplicatesByListIdPut**
> string ListsRemoveDuplicatesByListIdPut (int? listId, Fields fields)

Remove duplicate contacts

Remove duplicate contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsRemoveDuplicatesByListIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactListApi();
            var listId = 56;  // int? | Your list id
            var fields = new Fields(); // Fields | Fields model

            try
            {
                // Remove duplicate contacts
                string result = apiInstance.ListsRemoveDuplicatesByListIdPut(listId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactListApi.ListsRemoveDuplicatesByListIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Your list id | 
 **fields** | [**Fields**](Fields.md)| Fields model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

