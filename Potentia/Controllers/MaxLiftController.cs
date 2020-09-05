using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Schema;
using PotentiaLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Potentia.Controllers
{
  
    [ApiController]
    public class MaxLiftController : ControllerBase
    {
       [Route("api/[controller]")]
        [HttpPost]
        public object Post(UserInfo userInfo)
        {
            Lift calculatedMetrics = Conversions.AssignMetrics(userInfo);
            decimal calculatedKilograms;
            decimal calculatedPounds;

            if (userInfo.Formula == "" || userInfo.Metric == "" || userInfo.Repetitions == 0 || userInfo.Weight == 0)
            {
                throw new ArgumentException("Provide string values for Formula and Weight. Provide nonzero values for Repetitions and Weight");
            }

            else if (userInfo.Metric != "kilograms" && userInfo.Metric != "pounds")
            {
                throw new ArgumentException("Provide string values for Weight (kilograms or pounds)");
            }

            else if (userInfo.Formula == "brzycki")
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
            else { throw new ArgumentException("Provide a formula (brzycki, epley, lander, lombardi, oconner)."); }
            return new Lift
            {
                Kilograms = calculatedKilograms,
                Pounds = calculatedPounds
            };
        }
    }
}
