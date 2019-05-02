using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;
using StateMachineTests.StateMachineLayerTests;

namespace StateMachineTests.StateMachineSubStateMachineTests
{
    [TestClass]
    public class StateMachineRemoveSubStateMachine
    {
        private StateMachinePack.StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithSubStateMachines();
        }

        [TestMethod]
        public void RemoveNewSubMachineAddedToLastLayer()
        {
            SubStateMachine subStateMachine = stateMachine.AddSubStateMachine("newSubState", "newSubMachine");
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "newSubState",
                StateMachineBuilder.layerWithEnum));
            stateMachine.RemoveSubStateMachine(subStateMachine);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "newSubState",
                StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void RemoveNullSubMachine_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>((() => stateMachine.RemoveSubStateMachine(null)));
        }

        [TestMethod]
        public void RemoveSubMachineWithID()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithEnum));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIDStateTransition");
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDNonExistant_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
              stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID,
                  "Something"));
        }

        [TestMethod]
        public void RemoveSubMachineWithName()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineNameLayerByIDIsLoop", StateMachineBuilder.layerWithEnum));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "subMachineNameLayerByIDIsLoop");
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineNameLayerByIDIsLoop", StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameNonExistant_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name,
                    "Something"));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDFromLast()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithID));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIDStateTransition",
                InListLocation.Last);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDNonExistantFromLast_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID,
                    "Something", InListLocation.Last));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameFromLast()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIDName", StateMachineBuilder.layerWithID));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "subMachineToLayerByIDName",
                InListLocation.Last);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIDName", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameNonExistantFromLast_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name,
                    "Something", InListLocation.Last));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDFromLayerByID()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithIndex));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIDStateTransition",
                StateMachineBuilder.layerWithIndex);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithIndex));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDNonExistantFromLayerByID_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID,
                    "Something", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameFromLayerByID()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIDName", StateMachineBuilder.layerWithIndex));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "subMachineToLayerByIDName",
                StateMachineBuilder.layerWithIndex);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIDName", StateMachineBuilder.layerWithIndex));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameNonExistantFromLayerByID_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name,
                    "Something", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDFromLayerByIndex()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIndex", Layer.DEFAULT));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "subStateIDToLayerByIndex", 1);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "subStateIDToLayerByIndex", Layer.DEFAULT));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDNonExistantFromLayerByIndex_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID,
                    "Something", 1));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameFromLayerByIndex()
        {
            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIndexName", 1));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "subMachineToLayerByIndexName", 1);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "subMachineToLayerByIndexName", 1));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameNonExistantFromLayerByIndex_ThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name,
                    "Something", 1));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDFromLayerByObj()
        {
            Layer layer = stateMachine.AddLayer("newLayer");
            stateMachine.AddSubStateMachine("newSubState", "newSubMachine");

            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "newSubState", layer));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "newSubState", layer);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "newSubState", layer));
        }

        [TestMethod]
        public void RemoveSubMachineWithIDNonExistantFromLayerByObj_ThrowsException()
        {
            Layer layer = stateMachine.AddLayer("newLayer");
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "Something", layer));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameFromLayerByObj()
        {
            Layer layer = stateMachine.AddLayer("newLayer");
            stateMachine.AddSubStateMachine("newSubState", "newSubMachine");

            Assert.IsTrue(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "newSubMachine", layer));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "newSubMachine", layer);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "newSubMachine", layer));
        }

        [TestMethod]
        public void RemoveSubMachineWithNameNonExistantFromLayerByObj_ThrowsException()
        {
            Layer layer = stateMachine.AddLayer("newLayer");
            Assert.ThrowsException<NullReferenceException>(() =>
                stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name,
                    "Something", layer));
        }

        [TestMethod]
        public void RemoveAllSubMachinesWithIDExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 0);
        }

        [TestMethod]
        public void RemoveAllSubMachinesWithIDNonExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something").Length == 0);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.Name, "Something");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something").Length == 0);
        }

        [TestMethod]
        public void RemoveAllSubMachinesWithNameExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "subMachineToLayerByIDName").Length == 4);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.Name, "subMachineToLayerByIDName");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "subMachineToLayerByIDName").Length == 0);
        }

        [TestMethod]
        public void RemoveAllSubMachinesWithNameNonExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something").Length == 0);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.Name, "Something");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something").Length == 0);
        }


        [TestMethod]
        public void RemoveAllSubMachinesPredicateExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "subStateIDToLayerByID");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 0);
        }

        [TestMethod]
        public void RemoveAllSubMachinesPredicateNonExistant()
        {

            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SomeThing").Length == 0);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "SomeThing");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SomeThing").Length == 0);
        }

        [TestMethod]
        public void RemoveAllSubMachinesPredicatesExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "subStateIDToLayerByID",
                layer => layer.iD == StateMachineBuilder.layerWithIndex);
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "subStateIDToLayerByID").Length == 3);
        }

        [TestMethod]
        public void RemoveAllSubMachinesPredicatesNonExistant()
        {
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "Something").Length == 0);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "Something",
                layer => layer.iD == StateMachineBuilder.layerWithIndex);
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "Something").Length == 0);
        }

    }
}
