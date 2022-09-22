# Solution for the service resolution problem:

A solution for the problem is to first register the implementation type alone with:
````csharp
    services.AddScoped<TestService>();
````

and then afterwards add the registration for the other types, which in their factory return the instance of the implementation type;
```csharp
    services.AddScoped<ITestService, TestService>(o => o.GetRequiredService<TestService>())`
    services.AddScoped<ITestService2, TestService>(o => o.GetRequiredService<TestService>())`
```