using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Obj
{
    public abstract class ShapeBaseClass<T, V, RModel>
    {
        /* I defined this common properties thinking that maybe
        * in the future there are going to be other shapes
        * that share virtual methods that wont be override.
        */
        public string ShapeName { get; set; }
        public Dictionary<string, T> Constants { get; set; }
        public Dictionary<string, V> NumericValues { get; set; }  

        public virtual RModel CalculateArea()
        {
            throw new NotImplementedException();
        }

        //Other virtual methods That are not going to be override 
    }
}
