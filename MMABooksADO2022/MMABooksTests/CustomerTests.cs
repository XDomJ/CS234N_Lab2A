using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer def;
        private Customer c;

        [SetUp]

        public void Setup()
        {
            def = new Customer();
            c = new Customer(1, "Donald, Duck", "101 Main Street","Orlando", "FL", "10001");
        }
        
        [Test]
        public void TestConstructor()
        {
            Assert.IsNotNull(def);
            Assert.AreEqual(null, def.Name);
            Assert.AreEqual(null, def.Address);
            Assert.AreEqual(null, def.City);
            Assert.AreEqual(null, def.State);
            Assert.AreEqual(null, def.ZipCode);

            Assert.IsNotNull(c);
            Assert.AreNotEqual(null, c.Name);
            Assert.AreEqual("Donald, Duck", c.Name);
            Assert.AreNotEqual(null, c.Address);
            Assert.AreNotEqual(null, c.City);
            Assert.AreNotEqual(null, c.State);
            Assert.AreNotEqual(null, c.ZipCode);
        }

        [Test]
        public void TestNameSetter()
        {
            c.Name = "Daisy, Duck";
            Assert.AreNotEqual("Donald, Duck", c.Name);
            Assert.AreEqual("Daisy, Duck", c.Name);
        }
        [Test]

        public void TestSettersNameTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            c.Name = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
        }

        [Test]
        public void TestAddressSetter()
        {
            c.Address = "123 Fake Street";
            Assert.AreNotEqual("101 Main Street", c.Address);
            Assert.AreEqual("123 Fake Street", c.Address);
        }
        
        [Test]
        public void TestAddressSetterInvalidThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.Address = "");
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            c.Address = "100000000020000000003000000000400000000050000000001");
        }

        [Test]
        public void TestCitySetter()
        {
            c.City = "Minnetonka";
            Assert.AreNotEqual("Orlando", c.City);
            Assert.AreEqual("Minnetonka", c.City);
        }
        [Test]
        public void TestCitySetterRangeThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.City = "");
            Assert.Throws<ArgumentOutOfRangeException>(() => c.City = "102030405060708090100");
        }

        [Test]
        public void TestStateSetter()
        {
            c.State = "ND";
            Assert.AreNotEqual("FL", c.State);
            Assert.AreEqual("ND", c.State);
        }
        [Test]
        public void TestStateSetterRangeThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "X");
            Assert.Throws<ArgumentOutOfRangeException>(() => c.State = "TNT");
        }

        [Test]
        public void TestZipSetter()
        {
            c.ZipCode = "98990";
            Assert.AreNotEqual("10001", c.ZipCode);
            Assert.AreEqual("98990", c.ZipCode);
        }
        [Test]
        public void TestZipSetterThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "1234");
            Assert.Throws<ArgumentOutOfRangeException>(() => c.ZipCode = "102030405060708090100");
        }
        [Test]
        public void TestCustomerIDSetter()
        {
            c.CustomerID = 5;
            Assert.AreNotEqual(1, c.CustomerID);
            Assert.AreEqual(5,c.CustomerID);
        }
        [Test]
        public void TestCustomerIDThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => c.CustomerID = -34);
        }
        [Test]
        public void TestCustomerToString()
        {
            Assert.AreEqual(
                c.ToString(), "ID: 1 Name: Donald, Duck  Address: 101 Main Street  City: Orlando  State: FL  ZipCode: 10001");
        }
        

    }
}
