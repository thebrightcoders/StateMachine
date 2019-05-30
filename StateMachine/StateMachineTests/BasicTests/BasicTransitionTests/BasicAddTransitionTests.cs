using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicTransitionTests
{
    [TestClass]
    public class BasicAddTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates();
        }

        [TestMethod]
        public void AddTransition3ParamsWithNullIDWithStateObjects()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.AddTransition(null,
                                           stateMachine.GetState("StateIDToLastAddedLayer"),
                                           stateMachine.GetState("StateIDToLastAddedLayerBoth")));
        }

        [TestMethod]
        public void AddTransition3ParamsWithNullIDWithStateIDs()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.AddTransition(null,
                                           "StateIDToLastAddedLayer",
                                           "StateIDToLastAddedLayerBoth"));
        }

        [TestMethod]
        public void AddTransition3ParamsWithNullIDWithStateIDAndObject1()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.AddTransition(null,
                                           stateMachine.GetState("StateIDToLastAddedLayer"),
                                           "StateIDToLastAddedLayerBoth"));
        }

        [TestMethod]
        public void AddTransition3ParamsWithNullIDWithStateIDAndObject2()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.AddTransition(null,
                                           "StateIDToLastAddedLayerBoth",
                                           stateMachine.GetState("StateIDToLastAddedLayer")));
        }
    }
}
