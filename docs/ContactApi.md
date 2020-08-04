# IO.ClickSend.ClickSend.Api.ContactApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListsContactsByListIdAndContactIdDelete**](ContactApi.md#listscontactsbylistidandcontactiddelete) | **DELETE** /lists/{list_id}/contacts/{contact_id} | Delete a contact
[**ListsContactsByListIdAndContactIdGet**](ContactApi.md#listscontactsbylistidandcontactidget) | **GET** /lists/{list_id}/contacts/{contact_id} | Get a specific contact
[**ListsContactsByListIdAndContactIdPut**](ContactApi.md#listscontactsbylistidandcontactidput) | **PUT** /lists/{list_id}/contacts/{contact_id} | Update specific contact
[**ListsContactsByListIdGet**](ContactApi.md#listscontactsbylistidget) | **GET** /lists/{list_id}/contacts | Get all contacts in a list
[**ListsContactsByListIdPost**](ContactApi.md#listscontactsbylistidpost) | **POST** /lists/{list_id}/contacts | Create new contact
[**ListsCopyContactPut**](ContactApi.md#listscopycontactput) | **PUT** /lists/{from_list_id}/contacts/{contact_id}/copy/{to_list_id} | Copy contact to another list
[**ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut**](ContactApi.md#listsremoveoptedoutcontactsbylistidandoptoutlistidput) | **PUT** /lists/{list_id}/remove-opted-out-contacts/{opt_out_list_id} | Remove all opted out contacts
[**ListsTransferContactPut**](ContactApi.md#liststransfercontactput) | **PUT** /lists/{from_list_id}/contacts/{contact_id}/transfer/{to_list_id} | Transfer contact to another list


<a name="listscontactsbylistidandcontactiddelete"></a>
# **ListsContactsByListIdAndContactIdDelete**
> string ListsContactsByListIdAndContactIdDelete (int? listId, int? contactId)

Delete a contact

Delete a contact

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsContactsByListIdAndContactIdDeleteExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var listId = 56;  // int? | List ID
            var contactId = 56;  // int? | Contact ID

            try
            {
                // Delete a contact
                string result = apiInstance.ListsContactsByListIdAndContactIdDelete(listId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsContactsByListIdAndContactIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| List ID | 
 **contactId** | **int?**| Contact ID | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listscontactsbylistidandcontactidget"></a>
# **ListsContactsByListIdAndContactIdGet**
> string ListsContactsByListIdAndContactIdGet (int? listId, int? contactId)

Get a specific contact

Get a specific contact

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsContactsByListIdAndContactIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var listId = 56;  // int? | Your contact list id you want to access.
            var contactId = 56;  // int? | Your contact id you want to access.

            try
            {
                // Get a specific contact
                string result = apiInstance.ListsContactsByListIdAndContactIdGet(listId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsContactsByListIdAndContactIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Your contact list id you want to access. | 
 **contactId** | **int?**| Your contact id you want to access. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listscontactsbylistidandcontactidput"></a>
# **ListsContactsByListIdAndContactIdPut**
> string ListsContactsByListIdAndContactIdPut (int? listId, int? contactId, Contact contact)

Update specific contact

Update specific contact

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsContactsByListIdAndContactIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var listId = 56;  // int? | Contact list id
            var contactId = 56;  // int? | Contact ID
            var contact = new Contact(); // Contact | Contact model

            try
            {
                // Update specific contact
                string result = apiInstance.ListsContactsByListIdAndContactIdPut(listId, contactId, contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsContactsByListIdAndContactIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Contact list id | 
 **contactId** | **int?**| Contact ID | 
 **contact** | [**Contact**](Contact.md)| Contact model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listscontactsbylistidget"></a>
# **ListsContactsByListIdGet**
> string ListsContactsByListIdGet (int? listId, int? page = null, int? limit = null)

Get all contacts in a list

Get all contacts in a list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsContactsByListIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var listId = 56;  // int? | Contact list ID
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all contacts in a list
                string result = apiInstance.ListsContactsByListIdGet(listId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsContactsByListIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Contact list ID | 
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

<a name="listscontactsbylistidpost"></a>
# **ListsContactsByListIdPost**
> string ListsContactsByListIdPost (Contact contact, int? listId)

Create new contact

Create new contact

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsContactsByListIdPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var contact = new Contact(); // Contact | Contact model
            var listId = 56;  // int? | List id

            try
            {
                // Create new contact
                string result = apiInstance.ListsContactsByListIdPost(contact, listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsContactsByListIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contact** | [**Contact**](Contact.md)| Contact model | 
 **listId** | **int?**| List id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listscopycontactput"></a>
# **ListsCopyContactPut**
> string ListsCopyContactPut (int? fromListId, int? contactId, int? toListId)

Copy contact to another list

Copy contact to another list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsCopyContactPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var fromListId = 56;  // int? | List ID for list that contains contact.
            var contactId = 56;  // int? | Contact ID
            var toListId = 56;  // int? | List ID for list you want to copy the contact to.

            try
            {
                // Copy contact to another list
                string result = apiInstance.ListsCopyContactPut(fromListId, contactId, toListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsCopyContactPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromListId** | **int?**| List ID for list that contains contact. | 
 **contactId** | **int?**| Contact ID | 
 **toListId** | **int?**| List ID for list you want to copy the contact to. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsremoveoptedoutcontactsbylistidandoptoutlistidput"></a>
# **ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut**
> string ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut (int? listId, int? optOutListId)

Remove all opted out contacts

Remove all opted out contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsRemoveOptedOutContactsByListIdAndOptOutListIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var listId = 56;  // int? | Your list id
            var optOutListId = 56;  // int? | Your opt out list id

            try
            {
                // Remove all opted out contacts
                string result = apiInstance.ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut(listId, optOutListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| Your list id | 
 **optOutListId** | **int?**| Your opt out list id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststransfercontactput"></a>
# **ListsTransferContactPut**
> string ListsTransferContactPut (int? fromListId, int? contactId, int? toListId)

Transfer contact to another list

Transfer contact to another list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class ListsTransferContactPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactApi();
            var fromListId = 56;  // int? | List ID for list that contains contact.
            var contactId = 56;  // int? | Contact ID
            var toListId = 56;  // int? | List ID for list you want to transfer contact to.

            try
            {
                // Transfer contact to another list
                string result = apiInstance.ListsTransferContactPut(fromListId, contactId, toListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactApi.ListsTransferContactPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromListId** | **int?**| List ID for list that contains contact. | 
 **contactId** | **int?**| Contact ID | 
 **toListId** | **int?**| List ID for list you want to transfer contact to. | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

