using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task2
{
    class Tests
    {
        [Test]

        public void CanCreateComputer()
        {
            var x = new Computer(399, 1, "Huber");
            Assert.IsTrue(x.Gerätepreis == 399);
            Assert.IsTrue(x.Anzahl == 1);
        }

        [Test]
        public void CanCreateDrucker()
        {
            var x = new Drucker(89, 2, "Huber");
            Assert.IsTrue(x.Gerätepreis == 89);
            Assert.IsTrue(x.Anzahl == 2);
        }

        [Test]

        public void CannotCreateComputerWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Computer(-100, 1, "Huber");
            });
        }

        [Test]

        public void CannotCreateComputerWithNegativeAnzahl()
        {
            Assert.Catch(() =>
            {
                var x = new Computer(100, -1, "Huber");
            });
        }

        [Test]

        public void CannotCreateDruckerWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Computer(-100, 1, "Huber");
            });
        }

        [Test]

        public void CannotCreateDruckerWithNegativeAnzahl()
        {
            Assert.Catch(() =>
            {
                var x = new Computer(100, -1, "Huber");
            });
        }


        [Test]
        public void CanChangeNameOfComputer()
        {
            var x = new Computer(399,1, "Hans");
            x.Besitzerändern("Huber");
            Assert.IsTrue(x.Besitzername == "Huber");
            
        }

        [Test]
        public void CanChangeNameOfDrucker()
        {
            var x = new Drucker(89, 1, "Huber");
            x.Besitzerändern("Mueller");
            Assert.IsTrue(x.Besitzername == "Mueller");

        }

        [Test]
        public void CanCalculateEndpreisOfComputer()
        {
            var x = new Computer(399, 1,"Huber");
            
            Assert.IsTrue(x.Endpreis()==(399*1));

        }

        [Test]
        public void CanCalculateEndpreisOfDrucker()
        {
            var x = new Drucker(89, 2, "Huber");

            Assert.IsTrue(x.Endpreis() == (89 * 2));

        }

    }
}
