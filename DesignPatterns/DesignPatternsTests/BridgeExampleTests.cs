using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCommon;
using Moq;

namespace BridgeDesignPattern.Tests
{
    [TestClass()]
    public class BridgeExampleTests
    {
        [TestMethod()]
        public void When_CorrectData_Expect_Success()
        {
            // Arrange
            var bridgeExample = new BridgeExample(); // TODO dependency injection? also moq

            // Act
            bridgeExample.RunExample();

            // Assert
            // TODO
        }
    }
}