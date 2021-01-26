using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothequeCalculatrice
{
    public class Mail : IMail
    {
        string _body;

        public string Body { get => _body; set => _body = value; }
        public Mail(string body)
        {
           
           
            _body = body;
           
        }

        public bool sendMail(string r)
        {
            Console.WriteLine ( Body );
            return true;
        }
    }
}
