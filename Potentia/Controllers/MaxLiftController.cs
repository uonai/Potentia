using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PotentiaLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Potentia.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MaxLiftController : ControllerBase
    {
        private readonly ILogger<MaxLiftController> _logger;

        public MaxLiftController(ILogger<MaxLiftController> logger)
        {
            _logger = logger;
        }

        // POST api/<MaxLiftController>/customary
        [HttpPost]
        // [Route("customary")]
        public object Post(UserInfo userInfo)
        {
            string missingInformation = "Accepted metric values: pounds, kilograms";

            decimal calculatedKilograms;
            decimal calculatedPounds;

            if (userInfo.Metric == "kilograms") {
                decimal weightInPounds = Conversions.KilogramsToPounds(userInfo.Weight);

                calculatedKilograms = Calculations.BrzyckiFormula(userInfo.Repetitions, userInfo.Weight); 
                calculatedPounds = Calculations.BrzyckiFormula(userInfo.Repetitions, weightInPounds);
            }

            else if (userInfo.Metric == "pounds")
            {
                decimal weightInKilograms = Conversions.PoundsToKilograms(userInfo.Weight);

                calculatedPounds = Calculations.BrzyckiFormula(userInfo.Repetitions, userInfo.Weight);
                calculatedKilograms = Calculations.BrzyckiFormula(userInfo.Repetitions, weightInKilograms);
            }

           else return missingInformation;

            return new Lift
            {
                Kilograms = calculatedKilograms,
                Pounds = calculatedPounds
            };
        }
    }
}
