var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(confService =>
{
    confService.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title= "CatalogAPI",
        Description="E-Commerce - Catalog API Service",
        Version= "v1",

    });
}

);

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
