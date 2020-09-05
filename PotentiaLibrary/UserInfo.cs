using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Potentia
{
    public class UserInfo
    {
        private string formattedMetric;
        private decimal formattedWeight;
        private string formattedFormula;

        public decimal Weight
        {
            get
            {
                return this.formattedWeight;
            }
            set
            {
                decimal decimalValue = Convert.ToDecimal(value);
                this.formattedWeight = decimalValue;
            }
        }
        public int Repetitions { get; set; }
        public string Metric { 
            get {
                return this.formattedMetric; 
            } 
            set {
                this.formattedMetric = value.ToLower(); 
            } 
        }
        public string Formula
        {
            get { return this.formattedFormula; }
            set
            {
                this.formattedFormula = value.ToLower();
            }
        }
    }
}
