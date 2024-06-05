using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class Adapter : IStaraBibliotekaRejestrowania
    {
        private readonly INowaBibliotekaRejestrowania _nowaBiblioteka;

        public Adapter(INowaBibliotekaRejestrowania nowaBiblioteka)
        {
            _nowaBiblioteka = nowaBiblioteka;
        }

        public void Log(string message)
        {
            _nowaBiblioteka.WriteLog(message);
        }
    }
}
