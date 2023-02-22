using GetMeTheAreaApp.Logic.BusinessLogic.Interface;
using GetMeTheAreaApp.Logic.Domain.Dto;
using GetMeTheAreaApp.Logic.Domain.Obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.BusinessLogic
{
    public class GetTheAreaLogic : IGetTheAreaLogic
    {
        public SimpleResult<int> GetCircleArea(int radio)
        {
            throw new NotImplementedException();
        }

        public SimpleResult<int> GetTriangleArea(int baseV, int height)
        {
            throw new NotImplementedException();
        }
    }
}
