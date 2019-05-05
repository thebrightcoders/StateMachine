using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineStateTests
{
    [TestClass]
    public class StateMachineGetStateTests
    {
        private StateMachine stateMachine; 
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates();
        }

        [TestMethod]
        public void StateMachineGetStateDefault()
        {


        }

    }
}
