using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using IForce.WebFormsTest.Databases;
using IForce.WebFormsTest.Entities;
using IForce.WebFormsTest.Services;
using Microsoft.EntityFrameworkCore;

namespace IForce.WebFormsTest.Services.ProductServices
{
    public class ProductService(DataContext dataContext, IMapper mapper) : IAppService
    {
        public List<ProductResponse> Search(string keyword)
        {
            var query = dataContext.Product.AsNoTracking();
            var normalizedKeyword = (keyword ?? string.Empty).Trim();

            if (normalizedKeyword.Length > 0)
            {
                query = query.Where(x => x.ProductName.Contains(normalizedKeyword)
                || x.ProductId.ToString().Contains(normalizedKeyword));
            }

            return query
                .OrderBy(x => x.ProductId)
                .ProjectTo<ProductResponse>(mapper.ConfigurationProvider)
                .ToList();
        }

        public string ExportCsv(string keyword)
        {
            var products = Search(keyword);
            var csv = new StringBuilder();
            csv.AppendLine("Product Id,Product Name,Price");

            foreach (var product in products)
            {
                csv.Append(product.ProductId);
                csv.Append(',');
                csv.Append(EscapeCsv(product.ProductName));
                csv.Append(',');
                csv.AppendLine(product.Price.ToString("F2", CultureInfo.InvariantCulture));
            }

            return csv.ToString();
        }

        private static string EscapeCsv(string value)
        {
            var escapedValue = (value ?? string.Empty).Replace("\"", "\"\"");
            return $"\"{escapedValue}\"";
        }
    }
}
