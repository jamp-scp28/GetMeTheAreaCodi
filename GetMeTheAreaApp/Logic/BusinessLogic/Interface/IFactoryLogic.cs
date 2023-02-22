using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeTheAreaApp.Logic.BusinessLogic.Interface
{
    public interface IFactoryLogic
    {
        IGetTheAreaLogic Area { get; }
    }
}
