using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace GenerateExcelFiles
{
    public class ExcelController : Controller
    {
        public IActionResult ExportToExcel()
        {
            // Sample data (you can replace this with your data retrieval logic)
            List<Product> products = GetSampleProducts();

            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Add a worksheet
                var worksheet = package.Workbook.Worksheets.Add("Products");

                // Add headers
                worksheet.Cells["A1"].Value = "ID";
                worksheet.Cells["B1"].Value = "Name";
                worksheet.Cells["C1"].Value = "Price";

                // Add data
                int row = 2;
                foreach (var product in products)
                {
                    worksheet.Cells["A" + row].Value = product.Id;
                    worksheet.Cells["B" + row].Value = product.Name;
                    worksheet.Cells["C" + row].Value = product.Price;
                    row++;
                }

                // Set the content type and return the Excel file as a stream
                var stream = new MemoryStream(package.GetAsByteArray());
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "products.xlsx");
            }
        }

        private List<Product> GetSampleProducts()
        {
            // Replace this with your data retrieval logic (e.g., from a database)
            return new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99m },
            new Product { Id = 2, Name = "Product B", Price = 19.99m },
            new Product { Id = 3, Name = "Product C", Price = 5.99m }
        };
        }
    }
}
