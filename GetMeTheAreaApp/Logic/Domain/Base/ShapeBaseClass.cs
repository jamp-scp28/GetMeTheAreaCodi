using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Obj
{
    public abstract class ShapeBaseClass<T, R>
    {
        /* I defined this common properties thinking that maybe
        * in the future there are going to be other shapes
        * that share virtual methods that wont be override.
        */
        public string ShapeName { get; set; }
        public List<T> Constants { get; set; }
        public List<R> NumericValues { get; set; }  

        public virtual int CalculateArea()
        {
            throw new NotImplementedException();
        }

        // 
    }
}
