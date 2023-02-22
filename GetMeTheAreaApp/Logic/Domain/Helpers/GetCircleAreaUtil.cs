using GetMeTheAreaApp.Logic.Domain.Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Helpers
{
    public class GetCircleAreaUtil: ShapeBaseClass<double, int, double>
    {
        public GetCircleAreaUtil(int radio)
        {
            // Add PI Constant
            Dictionary<string, double> constants = new();
            constants.Add("pi", 3.14159);
            // Add Radio
            Dictionary<string, int> values = new();
            values.Add("radio", radio);
            
            // Set to abstract class
            base.Constants = constants;
            base.NumericValues = values;
        }
        public override double CalculateArea()
        {
            int radio = base.NumericValues["radio"];
            double pi = base.Constants["pi"];
            return radio * Math.Pow(pi,2);
        }
    }
}
