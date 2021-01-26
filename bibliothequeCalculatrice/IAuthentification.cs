using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothequeCalculatrice
{
   public interface IAuthentification
    {
        bool verifierLogin(string login, string mdp);
    }
}
