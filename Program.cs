using OfficeOpenXml;
using System;
using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);
// Set the license context for EPPlus
//LicenseContext licenseContext = LicenseContext.NonCommercial;
ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
//LicenseManager.CurrentContext = licenseContext;

builder.Services.AddControllers();


// Add services and configuration here

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();


// Configure your application-specific middleware components here

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "excel",
        pattern: "excel/exporttoexcel",
        defaults: new { controller = "Excel", action = "ExportToExcel" }); // Add this route
});

app.Run();
