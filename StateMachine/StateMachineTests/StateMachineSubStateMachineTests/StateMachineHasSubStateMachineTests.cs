using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;
using StateMachineTests.StateMachineLayerTests;

namespace StateMachineTests.StateMachineSubStateMachineTests
{
    [TestClass]
    public class StateMachineHasSubStateMachineTests
    {
        const string invalidID = "!@#";
        private StateMachinePack.StateMachine stateMachine;

        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithSubStateMachines();
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

        [TestMethod]
        public void SearchWithIDExistant_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByObject"));
        }

        [TestMethod]
        public void SearchWithIDNonExistant_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "Something"));
        }

        [TestMethod]
        public void SearchWithNameExistant_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "subMachineNameToLayerByObject"));
        }

        [TestMethod]
        public void SearchWithNameNonExistant_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "Something"));
        }

        [TestMethod]
        public void SearchWithIDExistantInLastAddLayer_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLastAddedLayer", stateMachine.GetLayer(StateMachineBuilder.layerWithEnum)));
        }

        [TestMethod]
        public void SearchWithIDNonExistantInLastAddLayer_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "Something", stateMachine.GetLayer(StateMachineBuilder.layerWithEnum)));
        }

        [TestMethod]
        public void SearchWithIDExistantInFirstLayer_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLastAddedLayer", InListLocation.First));
        }

        [TestMethod]
        public void SearchWithIDNonExistantInLastLayer_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLastAddedLayer", InListLocation.Last));
        }

        [TestMethod]
        public void SearchWithIDExistantInLayerIndex2_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIDBoth", 2));
        }

        [TestMethod]
        public void SearchWithIDNonExistantInLayerIndex2_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLastAddedLayer", 2));
        }

        [TestMethod]
        public void SearchWithIDExistantInLayerID_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIDBoth", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void SearchWithIDNonExistantInLayerIndexID_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLastAddedLayer", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void SearchWithPredicateSingleExistant_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine((subMachine) => subMachine.GetID() == "subStateIDToLastAddedLayer"));
        }

        [TestMethod]
        public void SearchWithPredicateSingleNonExistant_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine((subMachine) => subMachine.GetID() == "Something"));
        }

        [TestMethod]
        public void SearchWithPredicateBothExistant_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(
                (subMachine) => subMachine.GetID() == "subStateIDToLastAddedLayer",
                (layer) => layer.iD == StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void SearchWithPredicateBothNonExistant_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasSubStateMachine(
                (subMachine) => subMachine.GetID() == "subStateIDToLastAddedLayer",
                (layer) => layer.iD == StateMachineBuilder.layerWithID));
        }
    }
}
