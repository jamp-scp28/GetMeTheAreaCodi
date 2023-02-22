using GetMeTheAreaApp.Logic.Domain.Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Helpers
{
    public class GetTriangleAreaUtil: ShapeBaseClass<double, int, double>
    {
        public GetTriangleAreaUtil(int baseV, int height)
        {
            // Add Values
            Dictionary<string, int> values = new();
            values.Add("base", baseV);
            values.Add("height", height);
            
            // Set to abstract class
            base.NumericValues = values;
        }
        public override double CalculateArea()
        {
            int baseV = base.NumericValues["base"];
            int height = base.NumericValues["height"];
            return baseV*height;
        }
    }
}
