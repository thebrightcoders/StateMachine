using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineAddSubStateMachineTests
    {
        [TestMethod]
        public void AddSubMachine_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine"));
        }

        [TestMethod]
        public void AddSubMachineWithNullParams_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, "newSubMachine"));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine("newState", null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, null));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParams_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "newSubMachine"));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("newState", ""));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", ""));

        }

        [TestMethod]
        public void AddSubMachineToLayer_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", Layer.DEFAULT));
        }

        [TestMethod]
        public void AddSubMachineWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithStateTransitionType_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "newSubMachine", StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("newState", "", StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", Layer.DEFAULT, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithIsLoop_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", true));
        }

        [TestMethod]
        public void AddSubMachineWithNullParamsWithIsLoop_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, "newSubMachine", true));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine("newState", null, true));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, null, true));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithIsLoop_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "newSubMachine", true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("newState", "", true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", true));

        }

        [TestMethod]
        public void AddSubMachineToLayerWithIsLoop_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", Layer.DEFAULT, true));
        }

        [TestMethod]
        public void AddSubMachineToLayerWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", Layer.DEFAULT, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithIsLoopWithStateTransitionType_ThrowsException()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "newSubMachine", true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("newState", "", true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndex_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", 0));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", 0, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithIsLoop_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", 0, true));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddSubStateMachine("newState", "newSubMachine", 0, true, StateTransitionType.Default));
        }
    }
}
