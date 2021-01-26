using bibliothequeCalculatrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCalculatrice
{
    
        public class FakeAuthentification : IAuthentification
        {
            public bool verifierLogin(string login, string mdp)
            {
                return true;
            }
        
    }
}
