using GetMeTheAreaApp.Logic.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Helpers
{
    public static class ParseInput
    {

        public static SimpleResult<int> TryParse(string value)
        {
            try {
                return SimpleResult<int>.GetResult("",Int32.Parse(value)); 
            }catch(Exception ex)
            {
                // Do something with exception
                return SimpleResult<int>.GetError("Ohh no, please enter a valid value", 0);
            }
        }
    }
}
