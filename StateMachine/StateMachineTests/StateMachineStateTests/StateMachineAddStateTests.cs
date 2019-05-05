using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineStateTests
{
    [TestClass]
    public class StateMachineAddStateTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers();
        }

        [TestMethod]
        public void StateMachineAddStateCore4ParamsWithNullId()
        {
            Layer layer = stateMachine.AddLayer("ab");
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddState(null, layer, false, StateTransitionType.Default));
        }
        [TestMethod]
        public void StateMachineAddState2ParamsWithNullId()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddState(null, StateTransitionType.Default));
        }
        [TestMethod]
        public void StateMachineAddState3ParamsWithNullId()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddState(null,false, StateTransitionType.Default));
        }
        [TestMethod]
        public void StateMachineAddState3ParamsWithJustNullId()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddState(null));
        }
        [TestMethod]
        public void StateMachineAddState3ParamsWithNullIdIsLoop()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddState(null,false));
        }
    }
}
