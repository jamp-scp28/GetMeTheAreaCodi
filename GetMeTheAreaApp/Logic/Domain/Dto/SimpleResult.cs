using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.Domain.Dto
{
    public class SimpleResult<TModel>
    {
        public static SimpleResult<TModel> GetError(string message, TModel result)
        {
            return new SimpleResult<TModel>
            {
                Result = result,
                ExcMessage = message
            };
        }
        public static SimpleResult<TModel> GetResult(string message, TModel result)
        {
            return new SimpleResult<TModel>
            { 
                Result = result,
                ExcMessage = message
            }; 
        }
        public TModel Result { get; set; }
        public string ExcMessage  { get; set; }
    }
}
