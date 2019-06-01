using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicStateTests
{
    [TestClass]
    public class BasicHasStateTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers();
            stateMachine.AddState("abc");
        }

        [TestMethod]
        public void StateMachineHasState()
        {
            Assert.IsTrue(stateMachine.HasState("abc"));
        }
        [TestMethod]
        public void StateMachineHasStateWithWrongId()
        {
            Assert.IsFalse(stateMachine.HasState("Vfv"));
        }
        [TestMethod]
        public void StateMachineHasStateWithWrongLayer()
        {
            Assert.IsFalse(stateMachine.HasState("abc", stateMachine.AddLayer("adf")));
        }
        [TestMethod]
        public void StateMachineHasStateWithWrongLayerId()
        {
            Assert.IsFalse(stateMachine.HasState("abc", Layer.DEFAULTID));
        }
        [TestMethod]
        public void StateMachineHasStateWithWrongLayerIndex()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stateMachine.HasState("abc", 12));
        }
        [TestMethod]
        public void StateMachineHasStateDefault()
        {
            Assert.IsTrue(stateMachine.HasState(Layer.DEFAULTSTARTSTATEID, Layer.DEFAULTID));
        }
        [TestMethod]
        public void StateMachineHasStatePredicate()
        {
            Assert.IsTrue(stateMachine.HasState(state => state.iD == "abc"));
        }
        [TestMethod]
        public void StateMachineHasStatePredicateWrongID()
        {
            Assert.IsFalse(stateMachine.HasState(state => state.iD == "abadfafc"));
        }
        [TestMethod]
        public void StateMachineHasStatePredicates()
        {
            Assert.IsTrue(stateMachine.HasState(state => state.iD == "abc", layer => layer.iD == StateMachineBuilder.layerWithEnum));
        }
        [TestMethod]
        public void StateMachineHasStatePredicatesWithWrongId()
        {
            Assert.IsFalse(stateMachine.HasState(state => state.iD == "abadfadfadfc", layer => layer.iD == StateMachineBuilder.layerWithEnum));
        }
        [TestMethod]
        public void StateMachineHasStatePredicatesWithWrongLayer()
        {
            Assert.IsFalse(stateMachine.HasState(state => state.iD == "abc", layer => layer.iD == Layer.DEFAULTID));
        }
    }
}
