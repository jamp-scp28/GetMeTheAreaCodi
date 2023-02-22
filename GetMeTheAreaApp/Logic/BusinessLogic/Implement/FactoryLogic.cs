using GetMeTheAreaApp.Logic.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.BusinessLogic.Implement
{
    public class FactoryLogic : IFactoryLogic
    {
        public IGetTheAreaLogic Area { get; private set; }
        public FactoryLogic()
        {
            Area = new GetTheAreaLogic();
        }
    }
}
