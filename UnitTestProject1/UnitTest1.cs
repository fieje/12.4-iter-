using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeleteNodesAfter()
        {
            CircularLinkedList myList = new CircularLinkedList();
            myList.AddNode(1);
            myList.AddNode(2);
            myList.AddNode(3);
            myList.AddNode(4);
            myList.AddNode(5);

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            myList.DeleteNodesAfter(3);
            string expectedOutput = "Deleted the element with value 4\r\nDeleted the element with value 5\r\n";

            Assert.AreEqual(expectedOutput, sw.ToString());

            sw.Dispose();
        }
    }
}
