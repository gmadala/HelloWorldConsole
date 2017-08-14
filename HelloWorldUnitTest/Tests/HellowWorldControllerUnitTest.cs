using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using HelloWorldAPI.Controllers;

namespace HelloWorldUnitTest.Tests
{

    class HellowWorldControllerUnitTest
    {
        private Mock<IHelloWorldService> helloWorldMock;
        private HelloWorldController helloWorldController;
        [Test]
        public void HelloWorldSuccessUnitTestCase()
        {
            this.helloWorldMock = new Mock<IHelloWorldService>();
            var expectedResultData = GetHelloWorldData();

            this.helloWorldMock.Setup(x => x.GetHelloWorldData()).Returns(expectedResult);
            var result = this.helloWorldController.GetData();

            Assert.NotNull(result);
            Assert.AreEqual(result.Data, expectedResultData.Data);
        }

        internal interface IHelloWorldService
        {
        }

        public static HelloWorldData GetHelloWorldData()
        {
            return new HelloWorldData()
            {
                Data = "Hello World!"
            };
        }
    }
}
