using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonSyncDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSyncDesignPattern.Tests
{
    [TestClass()]
    public class SingletonExampleTests
    {
        [TestMethod()]
        public void When_CorrectData_Expect_Success()
        {
            // Arrange
            var singletonExample = new SingletonExample(); // TODO dependency injection? also moq

            // Act
            singletonExample.RunExample();

            // Assert
            // TODO
        }
    }
}