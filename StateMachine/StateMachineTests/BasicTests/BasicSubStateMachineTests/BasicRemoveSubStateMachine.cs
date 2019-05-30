using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicSubStateMachineTests
{
    [TestClass]
    public class BasicRemoveSubStateMachine
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
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithEnum));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "SubStateIDToLayerByIDStateTransition");
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithEnum));
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
                "SubMachineNameLayerByIDIsLoop", StateMachineBuilder.layerWithEnum));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "SubMachineNameLayerByIDIsLoop");
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineNameLayerByIDIsLoop", StateMachineBuilder.layerWithEnum));
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
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithID));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "SubStateIDToLayerByIDStateTransition",
                InListLocation.Last);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithID));
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
                "SubMachineToLayerByIDName", StateMachineBuilder.layerWithID));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "SubMachineToLayerByIDName",
                InListLocation.Last);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineToLayerByIDName", StateMachineBuilder.layerWithID));
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
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithIndex));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "SubStateIDToLayerByIDStateTransition",
                StateMachineBuilder.layerWithIndex);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByIDStateTransition", StateMachineBuilder.layerWithIndex));
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
                "SubMachineToLayerByIDName", StateMachineBuilder.layerWithIndex));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "SubMachineToLayerByIDName",
                StateMachineBuilder.layerWithIndex);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineToLayerByIDName", StateMachineBuilder.layerWithIndex));
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
                "SubStateIDToLayerByIndex", Layer.DEFAULT));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.ID, "SubStateIDToLayerByIndex", 1);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByIndex", Layer.DEFAULT));
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
                "SubMachineToLayerByIndexName", 1));
            stateMachine.RemoveSubStateMachine(SubStateMachineSelection.Name, "SubMachineToLayerByIndexName", 1);
            Assert.IsFalse(stateMachine.HasSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineToLayerByIndexName", 1));
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
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 0);
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
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "SubMachineToLayerByIDName").Length == 4);
            stateMachine.RemoveSubStateMachines(SubStateMachineSelection.Name, "SubMachineToLayerByIDName");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "SubMachineToLayerByIDName").Length == 0);
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
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "SubStateIDToLayerByID");
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 0);
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
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 4);
            stateMachine.RemoveSubStateMachines((subStateMachine) => subStateMachine.GetID() == "SubStateIDToLayerByID",
                layer => layer.iD == StateMachineBuilder.layerWithIndex);
            Assert.IsTrue(
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByID").Length == 3);
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
