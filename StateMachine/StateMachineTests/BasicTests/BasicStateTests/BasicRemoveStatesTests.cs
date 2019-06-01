using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicStateTests
{
    [TestClass]
    public class BasicRemoveStatesTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates();

            //---------------------------
            stateMachine.AddLayer("LayerA");

            stateMachine.AddState("e");
            stateMachine.AddState("f");
            stateMachine.AddState("g");
            stateMachine.AddState("h");
            stateMachine.AddState("i");
            stateMachine.AddState("j");
            //---------------------------
            stateMachine.AddLayer("LayerB");
            stateMachine.AddState("a15445");
            stateMachine.AddState("b");
            stateMachine.AddState("c");
            stateMachine.AddState("d");
            stateMachine.AddState("k");
            stateMachine.AddState("l");
            stateMachine.AddState("m");
        }
        [TestMethod]
        public void StateMachineRemoveStateWithNullId()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveState(null));
        }
        [TestMethod]
        public void StateMachineRemoveStateDefaultStateFromDefaultLayer()
        {
            stateMachine.RemoveState(Layer.DEFAULTSTARTSTATEID, Layer.DEFAULTID);
            Assert.IsFalse(stateMachine.HasState(Layer.DEFAULTSTARTSTATEID, Layer.DEFAULTID));
        }
        [TestMethod]
        public void StateMachineRemoveStatea15445FromLayerA()
        {
            Assert.ThrowsException<NullReferenceException>(
                () => stateMachine.RemoveState("a15445", "LayerA"));
        }
        [TestMethod]
        public void StateMachineRemoveStateAFromLayerB()
        {
            stateMachine.RemoveState("a15445", "LayerB");
            Assert.IsFalse(stateMachine.HasState("a15445", "LayerB"));
        }

    }
}
