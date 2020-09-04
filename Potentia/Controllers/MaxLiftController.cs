using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        // GET: api/<MaxLiftController>
        [HttpGet]
        public Lift Get()
        {
            return new Lift
            {
                Kilograms = 0,
                Pounds = 1
            };
        }

        // GET api/<MaxLiftController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MaxLiftController>
        [HttpPost]
        public Lift Post(UserInfo userInfo)
        {
            decimal calculatedKilograms = (decimal)0.00;
            decimal calculatedPounds = (decimal)0.00;
            var _weight = Convert.ToDecimal(userInfo.Weight);
            if (userInfo.Metric == "kilograms") {
              decimal weightInPounds = Conversions.KilogramsToPounds(_weight);
              calculatedKilograms = Conversions.CalculateOneRepMax(userInfo.Reps, _weight); 
              calculatedPounds = Conversions.CalculateOneRepMax(userInfo.Reps, weightInPounds);
            }

            else if (userInfo.Metric == "pounds")
            {
                decimal weightInKilograms = Conversions.PoundsToKilograms(_weight);
                calculatedPounds = Conversions.CalculateOneRepMax(userInfo.Reps, _weight);
                calculatedKilograms = Conversions.CalculateOneRepMax(userInfo.Reps, weightInKilograms);
            } 
            return new Lift
            {
                Kilograms = calculatedKilograms,
                Pounds = calculatedPounds
            };
        }

        // PUT api/<MaxLiftController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MaxLiftController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
