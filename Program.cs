var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls($"http://0.0.0.0:{Environment.GetEnvironmentVariable("PORT") ?? "8080"}");

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();

app.Run();