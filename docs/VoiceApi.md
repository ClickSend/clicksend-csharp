# IO.ClickSend.ClickSend.Api.VoiceApi

All URIs are relative to *https://rest.clicksend.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VoiceCancelAllPut**](VoiceApi.md#voicecancelallput) | **PUT** /voice/cancel-all | Update all voice messages as cancelled
[**VoiceCancelByMessageIdPut**](VoiceApi.md#voicecancelbymessageidput) | **PUT** /voice/{message_id}/cancel | Update voice message status as cancelled
[**VoiceHistoryExportGet**](VoiceApi.md#voicehistoryexportget) | **GET** /voice/history/export | Export voice history
[**VoiceHistoryGet**](VoiceApi.md#voicehistoryget) | **GET** /voice/history | Get all voice history
[**VoiceLangGet**](VoiceApi.md#voicelangget) | **GET** /voice/lang | Get all voice languages
[**VoicePricePost**](VoiceApi.md#voicepricepost) | **POST** /voice/price | Calculate voice price
[**VoiceReceiptsGet**](VoiceApi.md#voicereceiptsget) | **GET** /voice/receipts | Get all delivery receipts
[**VoiceReceiptsPost**](VoiceApi.md#voicereceiptspost) | **POST** /voice/receipts | Add a delivery receipt
[**VoiceReceiptsReadPut**](VoiceApi.md#voicereceiptsreadput) | **PUT** /voice/receipts-read | Mark delivery receipts as read
[**VoiceSendPost**](VoiceApi.md#voicesendpost) | **POST** /voice/send | Send voice message(s)


<a name="voicecancelallput"></a>
# **VoiceCancelAllPut**
> string VoiceCancelAllPut ()

Update all voice messages as cancelled

Update all voice messages as cancelled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceCancelAllPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();

            try
            {
                // Update all voice messages as cancelled
                string result = apiInstance.VoiceCancelAllPut();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceCancelAllPut: " + e.Message );
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

<a name="voicecancelbymessageidput"></a>
# **VoiceCancelByMessageIdPut**
> string VoiceCancelByMessageIdPut (string messageId)

Update voice message status as cancelled

Update voice message status as cancelled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceCancelByMessageIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var messageId = messageId_example;  // string | Your voice message id

            try
            {
                // Update voice message status as cancelled
                string result = apiInstance.VoiceCancelByMessageIdPut(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceCancelByMessageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Your voice message id | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voicehistoryexportget"></a>
# **VoiceHistoryExportGet**
> string VoiceHistoryExportGet (string filename)

Export voice history

Export voice history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceHistoryExportGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var filename = filename_example;  // string | Filename to export to

            try
            {
                // Export voice history
                string result = apiInstance.VoiceHistoryExportGet(filename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceHistoryExportGet: " + e.Message );
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

<a name="voicehistoryget"></a>
# **VoiceHistoryGet**
> string VoiceHistoryGet (int? dateFrom = null, int? dateTo = null, int? page = null, int? limit = null)

Get all voice history

Get all voice history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceHistoryGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var dateFrom = 56;  // int? | Timestamp (from) used to show records by date. (optional) 
            var dateTo = 56;  // int? | Timestamp (to) used to show records by date (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all voice history
                string result = apiInstance.VoiceHistoryGet(dateFrom, dateTo, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateFrom** | **int?**| Timestamp (from) used to show records by date. | [optional] 
 **dateTo** | **int?**| Timestamp (to) used to show records by date | [optional] 
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

<a name="voicelangget"></a>
# **VoiceLangGet**
> string VoiceLangGet ()

Get all voice languages

Get all voice languages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceLangGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();

            try
            {
                // Get all voice languages
                string result = apiInstance.VoiceLangGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceLangGet: " + e.Message );
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

<a name="voicepricepost"></a>
# **VoicePricePost**
> string VoicePricePost (VoiceMessageCollection voiceMessages)

Calculate voice price

Calculate voice price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoicePricePostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var voiceMessages = new VoiceMessageCollection(); // VoiceMessageCollection | VoiceMessageCollection model

            try
            {
                // Calculate voice price
                string result = apiInstance.VoicePricePost(voiceMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoicePricePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voiceMessages** | [**VoiceMessageCollection**](VoiceMessageCollection.md)| VoiceMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voicereceiptsget"></a>
# **VoiceReceiptsGet**
> string VoiceReceiptsGet (int? page = null, int? limit = null)

Get all delivery receipts

Get all delivery receipts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceReceiptsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var page = 56;  // int? | Page number (optional)  (default to 1)
            var limit = 56;  // int? | Number of records per page (optional)  (default to 10)

            try
            {
                // Get all delivery receipts
                string result = apiInstance.VoiceReceiptsGet(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceReceiptsGet: " + e.Message );
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

<a name="voicereceiptspost"></a>
# **VoiceReceiptsPost**
> string VoiceReceiptsPost (Url url)

Add a delivery receipt

Add a delivery receipt

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceReceiptsPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var url = new Url(); // Url | Url model

            try
            {
                // Add a delivery receipt
                string result = apiInstance.VoiceReceiptsPost(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceReceiptsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | [**Url**](Url.md)| Url model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voicereceiptsreadput"></a>
# **VoiceReceiptsReadPut**
> string VoiceReceiptsReadPut (DateBefore dateBefore = null)

Mark delivery receipts as read

Mark delivery receipts as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceReceiptsReadPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var dateBefore = new DateBefore(); // DateBefore | DateBefore model (optional) 

            try
            {
                // Mark delivery receipts as read
                string result = apiInstance.VoiceReceiptsReadPut(dateBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceReceiptsReadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dateBefore** | [**DateBefore**](DateBefore.md)| DateBefore model | [optional] 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="voicesendpost"></a>
# **VoiceSendPost**
> string VoiceSendPost (VoiceMessageCollection voiceMessages)

Send voice message(s)

Send a voice call

### Example
```csharp
using System;
using System.Diagnostics;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;

namespace Example
{
    public class VoiceSendPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VoiceApi();
            var voiceMessages = new VoiceMessageCollection(); // VoiceMessageCollection | VoiceMessageCollection model

            try
            {
                // Send voice message(s)
                string result = apiInstance.VoiceSendPost(voiceMessages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.VoiceSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voiceMessages** | [**VoiceMessageCollection**](VoiceMessageCollection.md)| VoiceMessageCollection model | 

### Return type

**string**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

