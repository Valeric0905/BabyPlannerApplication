
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using BloodTypeWeb.Data;
using BloodTypeWeb.Models;

namespace BloodTypeWeb.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly BloodTypeDbContext _context;

        public DatabaseController(BloodTypeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string motherBloodType, string motherRhFactor, string fatherBloodType, string fatherRhFactor)
        {
            var queryResult = await _context.ParentCombinationsRh
                .Where(pc => pc.MotherBloodTypeID == motherBloodType &&
                             pc.FatherBloodTypeID == fatherBloodType &&
                             pc.MotherRhFactorID == _context.RhFactors.FirstOrDefault(rf => rf.RhFactorType == motherRhFactor).RhFactorID &&
                             pc.FatherRhFactorID == _context.RhFactors.FirstOrDefault(rf => rf.RhFactorType == fatherRhFactor).RhFactorID)
                .Include(pc => pc.ChildOutcomes)
                    .ThenInclude(co => co.ChildBloodType)
                .Include(pc => pc.ChildOutcomes)
                    .ThenInclude(co => co.ChildRhFactor)
                .ToListAsync();

            return View("Result", queryResult);
        }
    }
}
