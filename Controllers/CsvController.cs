using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Controllers
{
    public class CsvController : Controller
    {
        private readonly AppDbContext _context;

        public CsvController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var csvData = _context.CsvDatas.ToList();
            return View(csvData);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                using var reader = new StreamReader(file.OpenReadStream());
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HeaderValidated = null,  // Ignore header validation
                    MissingFieldFound = null  // Ignore missing fields
                };
                using var csv = new CsvReader(reader, config);
                var records = csv.GetRecords<CsvData>().ToList();

                foreach (var record in records)
                {
                    _context.CsvDatas.Add(record);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Index", _context.CsvDatas.ToList());
        }
    }
}
