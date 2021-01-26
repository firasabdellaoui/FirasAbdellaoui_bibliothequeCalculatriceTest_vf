using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using bibliothequeCalculatrice;
using NSubstitute;

namespace UnitTestCalculatrice
{
    [TestFixture]
   public class UnitTest1
    {
       // FakeMail _mookMail;
        FakeAuthentification stubAuthentification = new FakeAuthentification();

      

        //addition
        [Test]
        public void addition_argumentzero_zero()
        {
            //arrange
            CalculSimple cs = new CalculSimple(stubAuthentification);

            //act
            var Result = cs.AdditionSimple(0, 0);

            //assert
            Assert.AreEqual(0, Result);
        }
        
        [Test]
        public void Addition_ParametersPostive_Positive()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.AdditionSimple(2, 3);
            Assert.AreEqual(5, Result);

        }
       
        [Test]
        public void Addition_ParametersPostive_negative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.AdditionSimple(2,-3);
            Assert.AreEqual(-1, Result);

        }
        [Test]
        public void Addition_ParametersLong()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.AdditionSimple(11.11d,11.11d);
            Assert.AreEqual(22.22d, Result);
          
        }
        [Test]
        public void Addition_ParametersNegative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.AdditionSimple(-8, -4);
            Assert.AreEqual(-12, Result);

        }


        //soustraction

        [Test]
        public void Soustraction_parametre_positive_positive()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.SoustractionSimple(5,4);
            Assert.AreEqual(1, Result);

        }
        
        [Test]
        public void Soustraction_parametre_negative_negative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.SoustractionSimple(-5,-4);
            Assert.AreEqual(-1, Result);

        }
        [Test]
        public void Soustraction_parametre_postivee_negative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.SoustractionSimple(5, -4);
            Assert.AreEqual(9, Result);

        }

        //division
        [Test]
        public void Division_Parameters_Positive_positive()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.DivisionSimple(5, 5);
            Assert.AreEqual(1, Result);
        }
        [Test]
        public void Division_ParametersNegative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.DivisionSimple(-8, -2);
            Assert.AreEqual(4, Result);
        }
        [Test]

        //multuplication
        public void Multiplication_parametre_positive_positve()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.MultiplicationSimple(5,5);
            Assert.AreEqual(25, Result);
        }
        [Test]
        public void Multiplication_parametre_positive_null()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.MultiplicationSimple(5, 0);
            Assert.AreEqual(0, Result);
        }
        [Test]
        public void Multiplication_parametre_negative_negative()
        {
            CalculSimple cs = new CalculSimple(stubAuthentification);
            var Result = cs.MultiplicationSimple(-5, -5);
            Assert.AreEqual(25, Result);
        }

        [Test]
        public void Mail_test_addition()
        {
            IAuthentification stubAuthentification = Substitute.For<IAuthentification>();


            IMail _mookMail = Substitute.For<IMail>();


            _mookMail.When(x => x.sendMail("okay"))
              .Do(x =>_mookMail._body=x.Arg<int>());

            CalculSimple cs = new CalculSimple(stubAuthentification);

            //act
            var Result = cs.AdditionSimple(0, 0);

            //assert
            Assert.AreEqual(0, Result);


        }



    }
}





