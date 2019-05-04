using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineTransitionTests
{
    [TestClass]
    public class StateMachineAddTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }
    }
}
