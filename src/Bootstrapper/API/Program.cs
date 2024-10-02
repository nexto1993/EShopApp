var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.
    AddCatalog(builder.Configuration).
    AddBasket(builder.Configuration).
    AddOrdering(builder.Configuration);

app.MapGet("/", () => "Hello World!");

app.UseCatalog().UseBasket().UseOrdering();
app.Run();
