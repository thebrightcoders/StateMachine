using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineTransitionTests
{
    [TestClass]
    public class StateMachineHasTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates().WithTransitions();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }
    }
}
