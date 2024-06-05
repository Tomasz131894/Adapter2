using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class StaraBibliotekaRejestrowania : IStaraBibliotekaRejestrowania
    {
        public void Log(string message)
        {
            // Logika rejestrowania w starej bibliotece
        }
    }
}
