using GetMeTheAreaApp.Logic.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.BusinessLogic.Interface
{
    public interface IGetTheAreaLogic
    {
        public SimpleResult<double> GetCircleArea(int radio); 
        public SimpleResult<double> GetTriangleArea(int baseV, int height); 
    }
}
