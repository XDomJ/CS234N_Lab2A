using MMABooksBusinessClasses;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksTests
{
    [TestFixture]
    public class ProductTests
    {        

        private Product p;
        private Product def;

        [SetUp]

        public void Setup()
        {
            def = new Product();
            p = new Product("MNHD", "Test description" , 33.80, 500);
        }

        [Test]
        public void TestProductConstructors()
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null,def.ProductCode);
            Assert.AreEqual(null,def.Description);
            Assert.AreEqual(null, def.UnitPrice);
            Assert.AreEqual(null,def.OnHandQuantity);

            Assert.IsNotNull(p);
            Assert.AreNotEqual(null, p.ProductCode);
            Assert.AreEqual("MNHD", p.ProductCode);
            Assert.AreNotEqual(null, p.Description);
            Assert.AreNotEqual(null, p.UnitPrice);
            Assert.AreNotEqual(null, p.OnHandQuantity);
        }

        [Test]
        public void TestProductCodeSetters()
        {
            p.ProductCode = "OMMP";
            Assert.AreNotEqual("MNHD", p.ProductCode);
            Assert.AreEqual("OMMP", p.ProductCode);
        }
        [Test]
        public void TestProductCodeSettersThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.ProductCode = "");
            Assert.Throws<ArgumentOutOfRangeException>(() => p.ProductCode = "12345678910");

        }

        [Test]
        public void TestProductDescriptionSetters()
        {
            p.Description = "Silly stuff";
            Assert.AreNotEqual("Test description", p.Description );
            Assert.AreEqual("Silly stuff", p.Description);
        }
        [Test]
        public void TestProductDescriptionSettersThrow() 
        {
            Assert.Throws<ArgumentOutOfRangeException>(() 
                => p.Description = "112334567892123345678931233456789412334567895123345678961233456789");
        }
        [Test]
        public void TestProductUnitPriceSetters()
        {
            p.UnitPrice = 666.02;
            Assert.AreNotEqual(33.80, p.UnitPrice);
            Assert.AreEqual(666.02, p.UnitPrice);
        }
        [Test]
        public void TestProductUnitPriceThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.UnitPrice = -30);
            Assert.Throws<ArgumentOutOfRangeException>(() => p.UnitPrice = 100000000000);
        }
        [Test]
        public void TestOnHandQuantitySetters()
        {
            p.OnHandQuantity = 1;
            Assert.AreNotEqual (500, p.OnHandQuantity);
            Assert.AreEqual(1, p.OnHandQuantity);
        }
        [Test]
        public void TestOnHandQuantityThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => p.OnHandQuantity = -60);
        }
    }
}
