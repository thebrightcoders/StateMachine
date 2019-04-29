﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineAddSubStateMachineTests
    {
        const string iD = "newState", subMachineName = "newSubMachine", layerName = "newLayer", invalidID = "!@#";

        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers();
        }

        [TestMethod]
        public void AddSubMachine_ReturnsSomething()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName));
        }

        [TestMethod]
        public void AddSubMachineWithNullStringParams_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, subMachineName));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(iD, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, null));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParams_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", subMachineName));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", ""));
        }

        [TestMethod]
        public void AddSubMachineToLayer_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, Layer.DEFAULT));
        }

        [TestMethod]
        public void AddSubMachineWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithStateTransitionType_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", subMachineName, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, "", StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, Layer.DEFAULT, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithIsLoop_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, true));
        }

        [TestMethod]
        public void AddSubMachineWithNullParamsWithIsLoop_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, subMachineName, true));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(iD, null, true));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddSubStateMachine(null, null, true));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithIsLoop_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", subMachineName, true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, "", true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", true));

        }

        [TestMethod]
        public void AddSubMachineToLayerWithIsLoop_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, Layer.DEFAULT, true));
        }

        [TestMethod]
        public void AddSubMachineToLayerWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, Layer.DEFAULT, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByObjectWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            Layer layer = stateMachine.AddLayer(layerName);
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, layer, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByObjectWithStateTransitionType_ReturnsSubMachine()
        {
            Layer layer = stateMachine.AddLayer(layerName);
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, layer, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByObjectWithIsLoop_ReturnsSubMachine()
        {
            Layer layer = stateMachine.AddLayer(layerName);
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, layer, true));
        }

        [TestMethod]
        public void AddSubMachineToLayerByObject_ReturnsSubMachine()
        {
            Layer layer = stateMachine.AddLayer(layerName);
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, layer));
        }

        [TestMethod]
        public void AddSubMachineWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithEmptyParamsWithIsLoopWithStateTransitionType_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", subMachineName, true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, "", true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine("", "", true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndex_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, 0));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, 0, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithIsLoop_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, 0, true));
        }

        [TestMethod]
        public void AddSubMachineToLayerByIndexWithIsLoopWithStateTransitionType_ReturnsSubMachine()
        {
            Assert.IsNotNull(stateMachine.AddSubStateMachine(iD, subMachineName, 0, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithInvalidNameAndID_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, subMachineName));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, invalidID));
        }

        [TestMethod]
        public void AddSubMachineWithInvalidNameAndIDWithIsLoop_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, invalidID, true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, subMachineName, true));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, invalidID, true));
        }

        [TestMethod]
        public void AddSubMachineWithInvalidNameAndIDWithIsLoopWithStateTransitionType_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, invalidID, true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, subMachineName, true, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, invalidID, true, StateTransitionType.Default));
        }

        [TestMethod]
        public void AddSubMachineWithInvalidNameAndIDWithStateTransitionType_ThrowsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(iD, invalidID, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, subMachineName, StateTransitionType.Default));
            Assert.ThrowsException<Exception>(() => stateMachine.AddSubStateMachine(invalidID, invalidID, StateTransitionType.Default));
        }
    }
}
