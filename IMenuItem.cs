using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLogic
{
    /// <summary>
    /// Interface for Menu Items
    /// </summary>
    public interface IMenuItem
    {
        string Render(string userAccess);

        string Render();
    }
}
