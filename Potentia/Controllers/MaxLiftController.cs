using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Schema;
using PotentiaLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Potentia.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MaxLiftController : ControllerBase
    {
        
        [HttpPost]
        public object Post(UserInfo userInfo)
        {
            Lift calculatedMetrics = Conversions.AssignMetrics(userInfo);
            decimal calculatedKilograms;
            decimal calculatedPounds;

            if (userInfo.Formula == "brzycki")
            {
                calculatedKilograms = Calculations.BrzyckiFormula(userInfo.Repetitions, calculatedMetrics.Kilograms);
                calculatedPounds = Calculations.BrzyckiFormula(userInfo.Repetitions, calculatedMetrics.Pounds);
            } 
            else if (userInfo.Formula == "epley")
            {
                calculatedKilograms = Calculations.EpleyFormula(userInfo.Repetitions, calculatedMetrics.Kilograms);
                calculatedPounds = Calculations.EpleyFormula(userInfo.Repetitions, calculatedMetrics.Pounds);
            }
            else if (userInfo.Formula == "lander")
            {
                calculatedKilograms = Calculations.LanderFormula(userInfo.Repetitions, calculatedMetrics.Kilograms);
                calculatedPounds = Calculations.LanderFormula(userInfo.Repetitions, calculatedMetrics.Pounds);
            }
            else if (userInfo.Formula == "lombardi")
            {
                calculatedKilograms = Calculations.LombardiFormula(userInfo.Repetitions, calculatedMetrics.Kilograms);
                calculatedPounds = Calculations.LombardiFormula(userInfo.Repetitions, calculatedMetrics.Pounds);
            }
            else if (userInfo.Formula == "oconner")
            {
                calculatedKilograms = Calculations.OConnerFormula(userInfo.Repetitions, calculatedMetrics.Kilograms);
                calculatedPounds = Calculations.OConnerFormula(userInfo.Repetitions, calculatedMetrics.Pounds);
            }
            else { calculatedKilograms = 0; calculatedPounds = 0; }
            return new Lift
            {
                Kilograms = calculatedKilograms,
                Pounds = calculatedPounds
            };
        }
    }
}
