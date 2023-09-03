# Generate Excel files in Asp.Net Core with EPPlus library
To generate Excel files in an ASP.NET Core application, you can use a library like EPPlus, which is a popular open-source library for working with Excel files in .NET. Here are the steps to generate Excel files in ASP.NET Core using EPPlus:
## 1.	Create a new ASP.NET Core project or use an existing one.
## 2.	Install the EPPlus NuGet package. You can do this via the Package Manager Console or by adding the package reference to your project file:
   ![image](https://github.com/fsmaili77/GenerateExcelFiles/assets/65200251/ea5b6aab-695f-405d-885a-7f7229961d44)

## 3.	Create a model to represent your data. For example, let's assume you want to generate an Excel file containing a list of products:
   ![image](https://github.com/fsmaili77/GenerateExcelFiles/assets/65200251/3c8fc1c7-95a7-44ae-ae76-9e163e05ef6a)

## 4.	Create a controller action that generates the Excel file. Here's an example controller action:
   ![image](https://github.com/fsmaili77/GenerateExcelFiles/assets/65200251/96c59c4e-a772-4a46-879d-594bec4fc830)

## 5.	Add a route in your Startup.cs to map the controller action to a URL:
   ![image](https://github.com/fsmaili77/GenerateExcelFiles/assets/65200251/04b6cefd-62d1-4122-b5a0-85ccd1d588ea)

## 6.	Now, when you navigate to a URL like /excel/exporttoexcel, it will trigger the ExportToExcel action in your ExcelController and return an Excel file for download.
