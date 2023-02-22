using GetMeTheAreaApp.Logic.Domain.Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Helpers
{
    public class GetCircleArea: ShapeBaseClass<double, int>
    {
        public GetCircleArea(int radio)
        {
            // Add PI Constant
            List<double> constants = new();
            constants.Add(3.14159);
            // Add Radio
            List<int> values = new();
            values.Add(radio);
            
            // Set to abstract class
            base.Constants = constants;
            base.NumericValues = values;
        }
        public override int CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
