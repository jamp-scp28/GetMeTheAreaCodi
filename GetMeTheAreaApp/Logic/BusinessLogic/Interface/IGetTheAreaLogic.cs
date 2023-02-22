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
        public SimpleResult<int> GetCircleArea(int radio); 
        public SimpleResult<int> GetTriangleArea(int baseV, int height); 
    }
}
