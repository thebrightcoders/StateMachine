using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicStateTests
{
    [TestClass]
    public class BasicGetStateTests
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
            Assert.IsNotNull(stateMachine.GetState(Layer.DEFAULTSTARTSTATEID));
        }
        [TestMethod]
        public void StateMachineGetStateWithNullID()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.GetState(null));
        }
        [TestMethod]
        public void StateMachineGetStateWithWrongLayerIndex()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                stateMachine.GetState(Layer.DEFAULTSTARTSTATEID, -123));
        }
        [TestMethod]
        public void StateMachineGetStatesWithId()
        {
            Assert.IsTrue(stateMachine.GetStates(Layer.DEFAULTSTARTSTATEID).Length >= 0);
        }
        [TestMethod]
        public void StateMachineGetStatesWithPredicate()
        {
            Assert.IsTrue(
                stateMachine.GetStates(
                    state => state.iD == Layer.DEFAULTSTARTSTATEID).Length >= 0);
        }
        [TestMethod]
        public void StateMachineGetStatesWithPredicateStateAndLayer()
        {
            Assert.IsTrue(
                stateMachine.GetStates(
                    state => state.iD == Layer.DEFAULTSTARTSTATEID,
                    layer => layer.iD == Layer.DEFAULTID).Length == 1);
        }
    }
}
