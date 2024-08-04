using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenTelemetry().WithMetrics((options) =>
{
    options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("Store.Cart"))
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddRuntimeInstrumentation()
        .AddProcessInstrumentation()
        .AddConsoleExporter()
        .AddOtlpExporter(otel =>
        {
            otel.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
            otel.Endpoint = new Uri(builder.Configuration["OtlpExporter:Endpoint"]!);
        });

});


builder.Services.AddOpenTelemetry().WithTracing((options) =>
{
    options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("Store.Cart"))
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddConsoleExporter()
        .AddOtlpExporter(otel =>
        {
            otel.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
            otel.Endpoint = new Uri(builder.Configuration["OtlpExporter:Endpoint"]!);
        });
});

builder.Logging.AddOpenTelemetry(options =>
{
    options.IncludeScopes = true;
    options.AddConsoleExporter()
    .AddOtlpExporter(otel =>
    {
        otel.Endpoint = new Uri(builder.Configuration["OtlpExporter:Endpoint"]!);
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
