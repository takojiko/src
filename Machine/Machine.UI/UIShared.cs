using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.UI
{
    internal static class UIShared
    {
        static UIShared()
        {
            if (1 == 1)
            {
                MachineFacade = new DummyMachineFacade();
            }
            else
            {
                MachineFacade = new MachineFacade();
            }
        }

        internal static IMachinFacade MachineFacade { get; }
    }
}
