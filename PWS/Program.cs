using PWS.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailService, EmailService>();
//builder.Host.UseSerilog();

//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Information()
//    .WriteTo.File("logs/logs-.txt")
//    .WriteTo.Logger(lc => lc
//        .Filter.ByIncludingOnly(evt => evt.Level == LogEventLevel.Information)
//        .WriteTo.File("logs/requests-.txt",outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss}  {Message:lj} {Properties:j}{NewLine}{Exception}")
//    )
//    .CreateLogger();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseSerilogRequestLogging();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
