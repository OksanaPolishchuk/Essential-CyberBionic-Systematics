using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookApp.Tests
{
    [TestClass]
    public class BookAppTest
    {
        [TestClass]
        public class BookApp
        {
            private BookApp _document;

            [TestInitialize]
            public void Init()
            {
                _document = new BookApp();
            }

            [TestMethod]
            public string BookApp_2and5and7_257returnedTest()
            {
                string actual = _document.InitializeDocument();
                Assert.AreEqual(257,actual);
            }

            private string InitializeDocument()
            {
                throw new NotImplementedException();
            }
        }
    }
}
