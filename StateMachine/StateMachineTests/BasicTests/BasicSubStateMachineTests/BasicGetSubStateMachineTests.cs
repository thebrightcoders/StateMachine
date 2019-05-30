using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicSubStateMachineTests
{
    [TestClass]
    public class BasicGetSubStateMachineTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithSubStateMachines();
        }

        [TestMethod]
        public void GetSubMachineIDExistant_ReturnsNotNullAndFromFirstLayer()
        {
            SubStateMachine subStateMachine =
                stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "SubStateIDToLastAddedLayer");
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithEnum);
        }

        [TestMethod]
        public void GetSubMachineIDNonExistant_ReturnsNullAndFromFirstLayer()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "Something"));
        }

        [TestMethod]
        public void GetSubMachineNameExistant_ReturnsNotNullAndFromFirstLayer()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineNameToLayerByObjectIsLoop");
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithEnum);
        }

        [TestMethod]
        public void GetSubMachineNameNonExistant_ReturnsNullAndFromFirstLayer()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "Something"));
        }

        [TestMethod]
        public void GetSubMachineIDExistant_ReturnsNotNullAndFromLastLayer()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByObject", InListLocation.Last);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithID);
        }

        [TestMethod]
        public void GetSubMachineIDNonExistant_ReturnsNullAndFromLastLayer()
        {
            Assert.IsNull(
                stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "Something", InListLocation.Last));
        }

        [TestMethod]
        public void GetSubMachineNameExistant_ReturnsNotNullAndFromLastLayer()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineNameToLayerByObjectIsLoop", InListLocation.Last);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithID);
        }

        [TestMethod]
        public void GetSubMachineNameNonExistant_ReturnsNullAndFromLastLayer()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "Something",
                InListLocation.Last));
        }

        [TestMethod]
        public void GetSubMachineIDExistant_ReturnsNotNullAndFromLayerID()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLastAddedLayer", StateMachineBuilder.layerWithEnum);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithEnum);
        }

        [TestMethod]
        public void GetSubMachineIDNonExistant_ReturnsNullAndFromLayerID()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "Something",
                StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void GetSubMachineNameExistant_ReturnsNotNullAndFromLayerID()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineNameToLayerByObjectIsLoop", StateMachineBuilder.layerWithEnum);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithEnum);
        }

        [TestMethod]
        public void GetSubMachineNameNonExistant_ReturnsNullAndFromLayerID()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "Something",
                StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void GetSubMachineIDExistant_ReturnsNotNullAndFromLayerIndex()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.ID,
                "SubStateIDToLayerByObject", 3);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithID);
        }

        [TestMethod]
        public void GetSubMachineIDNonExistant_ReturnsNullAndFromLayerIndex()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "Something", 3));
        }

        [TestMethod]
        public void GetSubMachineNameExistant_ReturnsNotNullAndFromLayerIndex()
        {
            SubStateMachine subStateMachine = stateMachine.GetSubStateMachine(SubStateMachineSelection.Name,
                "SubMachineNameToLayerByObjectIsLoop", 3);
            Assert.IsNotNull(subStateMachine);
            Assert.AreEqual(subStateMachine.GetParentLayer().iD, StateMachineBuilder.layerWithID);
        }

        [TestMethod]
        public void GetSubMachineNameNonExistant_ReturnsNullAndFromLayerIndex()
        {
            Assert.IsNull(stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "Something", 3));
        }

        [TestMethod]
        public void GetSubMachineIDExistant_ReturnsFromNewlyAddedLayer()
        {
            Layer layer = stateMachine.AddLayer("NewLayer");
            SubStateMachine subStateMachine =
                stateMachine.AddSubStateMachine("NewSubState", "NewSubStateMachine", layer);
            Assert.IsNotNull(
                stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "NewSubState", layer));
            Assert.AreEqual(
                stateMachine.GetSubStateMachine(SubStateMachineSelection.ID, "NewSubState", layer).GetParentLayer().iD,
                "NewLayer");
        }

        [TestMethod]
        public void GetSubMachineNameExistant_ReturnsFromNewlyAddedLayer()
        {
            Layer layer = stateMachine.AddLayer("NewLayer");
            SubStateMachine subStateMachine =
                stateMachine.AddSubStateMachine("NewSubState", "NewSubStateMachine", layer);
            Assert.IsNotNull(
                stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "NewSubStateMachine", layer));
            Assert.AreEqual(
                stateMachine.GetSubStateMachine(SubStateMachineSelection.Name, "NewSubStateMachine", layer).GetParentLayer().iD,
                "NewLayer");
        }

        [TestMethod]
        public void GetAllSubStateMachineIDExistant_Returns4OfThem()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(SubStateMachineSelection.ID, "SubStateIDToLayerByIDBoth");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 4);
        }

        [TestMethod]
        public void GetAllSubStateMachineIDNonExistant_Returns0AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 0);
        }

        [TestMethod]
        public void GetAllSubStateMachineNameExistant_Returns4OfThem()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "SubMachineToLayerByIndexName");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 4);
        }

        [TestMethod]
        public void GetAllSubStateMachineNameNonExistant_Returns0AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(SubStateMachineSelection.Name, "Something");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 0);
        }

        [TestMethod]
        public void GetPredicateSubStateMachineExistant_Returns4AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(subMachine => subMachine.GetID() == "SubStateIDToLayerByIDIsLoop");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 4);
        }

        [TestMethod]
        public void GetPredicateSubStateMachineNonExistant_Returns0AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(subMachine => subMachine.GetID() == "Something");
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 0);
        }

        [TestMethod]
        public void GetPredicatesSubStateMachineExistant_Returns4AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(subMachine => subMachine.GetID() == "SubStateIDToLayerByIDIsLoop",
                    layer => layer.iD == StateMachineBuilder.layerWithID);
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 1);
        }

        [TestMethod]
        public void GetPredicatesSubStateMachineNonExistant_Returns0AndNotNull()
        {
            SubStateMachine[] subStateMachines =
                stateMachine.GetSubStateMachines(subMachine => subMachine.GetID() == "Something",
                    layer => layer.iD == StateMachineBuilder.layerWithID);
            Assert.IsNotNull(subStateMachines);
            Assert.IsTrue(subStateMachines.Length == 0);
        }

    }
}
