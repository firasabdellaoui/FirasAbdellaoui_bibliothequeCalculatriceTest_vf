using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothequeCalculatrice
{
    public class CalculSimple
    {
        
        public double _op1;
        public double _op2;
        public double _result;


        private IAuthentification _auth;
        public IAuthentification Auth { get => _auth; set => _auth = value; }
        public CalculSimple(IAuthentification auth)
        {
            this._auth = auth;
            
        }
        public double AdditionSimple(double x, double y )
        {

            _result = x + y;

            return _result;
        }
        public double SoustractionSimple(double x, double y)
        {
            _result = x - y;
            return _result;
        }
        public double MultiplicationSimple(double x, double y)
        {
            _result = x * y;
            return _result;
        }

        public double DivisionSimple(double x, double y)
        {
            _result = x / y;
            return _result;
        }


    }
}
