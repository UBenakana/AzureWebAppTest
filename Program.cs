var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var info = new {
        Message = "Hello from Azure Web App!",
        AspNetCoreVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
        OperatingSystem = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
        MachineName = System.Environment.MachineName,
        RuntimeVersion = System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier
    };
    return Results.Json(info);
});

app.Run();
