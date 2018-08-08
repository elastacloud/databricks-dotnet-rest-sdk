# DataBricks REST SDK for .NET

![](doc/assets/databricks-small.png)

Unofficial .NET wrapper for for [DataBricks REST API](https://docs.azuredatabricks.net/api/index.html).

Note that calls are implemented based on current demand, this SDK doesn't cover **all** of them. Please raise a PR if you need to add more.

## Obtaining Authentication Token

On DataBricks portal go to *User -> User Settings*

![](doc/assets/user-usersettings.png)

Create new token and copy before closing the dialog:

![](doc/assets/create-token.gif)

## Using the SDK

Create an instance of rest client:

```csharp
DataBricksRestClient _restClient = new DataBricksRestClient("https://northeurope.azuredatabricks.net", "token");
```

Ready to call an api, for instance to get the list of job runs:

```csharp
Run[] runs = await _restClient.Jobs.GetRunsAsync();
```


## Credits

[Refit](https://github.com/reactiveui/refit) is a library to ease a pain of rest client development developed by a genius. Hail!