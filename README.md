# AwareGroup.ProjectWorks
The [Refit](https://github.com/reactiveui/refit) API definitions and models were automatically generated using a PowerShell script and committed into this repository. The script will continue to be run as further updates are pushed out for the [ProjectWorks](https://projectworks.io) API services.

## Example
```csharp
//get api client
var pw = ProjectWorksApiFactory.GetApiClient<IProjectWorksV1Api>(apiBaseUrl, apiUsername, apiPassword);

//test api
var tasks = await pw.GetTasksAsync();
tasks.ForEach(t => Console.WriteLine(t.TaskName));
```
