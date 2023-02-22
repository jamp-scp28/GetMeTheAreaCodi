using GetMeTheAreaApp.Logic.BusinessLogic.Interface;
using GetMeTheAreaApp.Logic.Domain.Dto;
using GetMeTheAreaApp.Logic.Domain.Helpers;
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
        public SimpleResult<double> GetCircleArea(int radio)
        {
            try
            {
                GetCircleAreaUtil circleUtility = new GetCircleAreaUtil(radio);
                return SimpleResult<double>.GetResult("NA", circleUtility.CalculateArea());
            }catch(Exception ex)
            {
                return SimpleResult<double>.GetError(ex.Message, 0);
            }
        }

        public SimpleResult<double> GetTriangleArea(int baseV, int height)
        {
            try
            {
                GetTriangleAreaUtil triangleUtility = new GetTriangleAreaUtil(baseV, height);
                return SimpleResult<double>.GetResult("NA", triangleUtility.CalculateArea());
            }
            catch (Exception ex)
            {
                return SimpleResult<double>.GetError(ex.Message, 0);
            }
        }
    }
}
