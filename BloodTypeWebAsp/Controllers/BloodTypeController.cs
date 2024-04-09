using BloodTypeWeb.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BloodTypeWeb.Models;

namespace BloodTypeWeb.Controllers
{
    public class BloodTypeController : Controller
    {
        private readonly IBloodTypeCalculator _bloodTypeCalculator;
        private readonly ICalculateRhFactor _rhFactorCalculator;

        public BloodTypeController(IBloodTypeCalculator bloodTypeCalculator, ICalculateRhFactor rhFactorCalculator)
        {
            _bloodTypeCalculator = bloodTypeCalculator;
            _rhFactorCalculator = rhFactorCalculator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(BloodTypeRhFactorModel model)
        {
            var bloodTypeResults = _bloodTypeCalculator.CalculateChildBloodType(model.MotherBloodType, model.FatherBloodType);
            var rhFactorResults = _rhFactorCalculator.CalculateChildRhFactor(model.MotherRhFactor, model.FatherRhFactor);

            var resultModel = new ChildBloodTypeRhFactorResultModel
            {
                ChildBloodTypePercentages = bloodTypeResults ?? new Dictionary<string, int>(), 
                ChildRhFactorPercentages = rhFactorResults ?? new Dictionary<string, int>() 
            };
          
            return View("Result", resultModel);
        }
    }

}
