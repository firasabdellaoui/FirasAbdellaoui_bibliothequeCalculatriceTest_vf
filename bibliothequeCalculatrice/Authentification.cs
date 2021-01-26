using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothequeCalculatrice
{
    public class Authentification : IAuthentification
    {
        string _login;
        string _mdp;

        public Authentification(string login, string mdp)
        {
            this._login = login;
            this._mdp = mdp;
        }

        public string Login { get => _login; set => _login = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }



        public bool verifierLogin(string login, string mdp)

        {
            if ((this._login.Equals(login)) && (this._mdp.Equals(mdp)))
                return true;
            else

                return false;
        }
    }
}
