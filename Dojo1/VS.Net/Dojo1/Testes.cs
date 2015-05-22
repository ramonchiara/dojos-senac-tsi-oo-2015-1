using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo1
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestA()
        {
            string msg = "A";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("2", res);
        }

        [TestMethod]
        public void TestB()
        {
            string msg = "B";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("22", res);
        }

        [TestMethod]
        public void TestC()
        {
            string msg = "C";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("222", res);
        }

        [TestMethod]
        public void TestD()
        {
            string msg = "D";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("3", res);
        }

        [TestMethod]
        public void TestAA()
        {
            string msg = "AA";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("2_2", res);
        }

        [TestMethod]
        public void TestAB()
        {
            string msg = "AB";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("2_22", res);
        }

        [TestMethod]
        public void TestAC()
        {
            string msg = "AC";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("2_222", res);
        }

        [TestMethod]
        public void TestAD()
        {
            string msg = "AD";
            Editor e = new Editor();
            string res = e.Digitar(msg);

            Assert.AreEqual("23", res);
        }
    }
}
