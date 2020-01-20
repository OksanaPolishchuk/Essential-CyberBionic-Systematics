using BookApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTests
{
    [TestClass]
    public class BookAppTests
    { 
        private Document _document;

        [TestInitialize]
        public void Init()
        { 
            _document = new Document("Title", "Author", "Body");
        }

        [TestMethod]
        public void Document_AttributesConcatenatedTest()
        {
            string actual = _document.Concatenate();
            Assert.AreEqual("Title\nAuthor\nBody", actual);
        }

    }

}
