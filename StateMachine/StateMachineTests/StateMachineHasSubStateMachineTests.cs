using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineHasSubStateMachineTests
    {
        const string iD = "newState", subMachineName = "newSubMachine", invalidID = "!@#";
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithSubStateMachines();
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_SimplestFormOfParams()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_SimplestFormOfParams()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_SimplestFormOfParams()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsToLayerObject()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsToLayerObject()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsToLayerObject()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsToLayerObjectWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsToLayerObjectWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsToLayerObjectWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsToLayerObjectWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsToLayerObjectWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsToLayerObjectWithIsLoop()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException_ParamsToLayerObjectWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException_ParamsToLayerObjectWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException_ParamsToLayerObjectWithIsLoopWithStateTransitionType()
        {
            stateMachine.AddSubStateMachine(iD, subMachineName, true, StateTransitionType.Default);
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }
    }
}
