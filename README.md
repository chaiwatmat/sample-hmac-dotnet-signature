# Sample HMAC hash generator for dotnet

## Example usage

### Get signature from response header

```cs
var responseSignature = ""; //get signature response from response header
```

### Verify response json from server

```cs
var sampleJsonResponse = "{\"responseUid\":\"9c07234b-90cb-4c15-a1b6-d277ddda8aca\", \"data\": [{\"id\":\"10000\"},{\"id\":\"10001\"}]}";

var auditor = new Hmac512Generator();
var result = auditor.GetSignature(sampleJsonResponse);

//verify
if(result != responseSignature){
    //response body is not valid
}
```
