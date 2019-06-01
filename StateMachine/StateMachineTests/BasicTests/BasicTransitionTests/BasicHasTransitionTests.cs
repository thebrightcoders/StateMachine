using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicTransitionTests
{
    [TestClass]
    public class BasicHasTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates().WithTransitions();
        }

        [TestMethod]
        public void HasTransitionWithIDExistent_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDByLayerObjectToStateIDs));
        }

        [TestMethod]
        public void HasTransitionWithIDNonExistent_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition("Something"));
        }

        [TestMethod]
        public void HasTransitionWithIDExistentByLayerLocation_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDByLayerObjectToStateIDs, InListLocation.First));
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDByLayerObjectToStateIDs, InListLocation.Last));
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, InListLocation.First));
        }

        [TestMethod]
        public void HasTransitionWithIDNonExistentByLayerLocation_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition("Something", InListLocation.First));
            Assert.IsFalse(stateMachine.HasTransition("Something", InListLocation.Last));
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, InListLocation.Last));
        }

        [TestMethod]
        public void HasTransitionWithIDExistentByLayerID_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void HasTransitionWithIDNonExistentByLayerID_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition("Something", StateMachineBuilder.layerWithEnum));
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void HasTransitionWithIDExistentByLayerIndex_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, 0));
        }

        [TestMethod]
        public void HasTransitionWithIDNonExistentByLayerIndex_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition("Something", StateMachineBuilder.layerWithEnum));
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, 1));
        }

        [TestMethod]
        public void HasTransitionWithIDExistentByLayerObj_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                stateMachine.GetLayer(StateMachineBuilder.layerWithEnum)));
        }

        [TestMethod]
        public void HasTransitionWithIDNonExistentByLayerObj_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition("Something", StateMachineBuilder.layerWithEnum));
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                stateMachine.GetLayer(StateMachineBuilder.layerWithIndex)));
        }

        [TestMethod]
        public void HasTransitionPredicateExistent_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(state =>
                state.iD == StateMachineBuilder.TransitionIDByLayerObjectToStateIDs));
        }

        [TestMethod]
        public void HasTransitionPredicateNonExistent_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition(state =>
                state.iD == "Something"));
        }

        [TestMethod]
        public void HasTransitionPredicatesExistent_ReturnsTrue()
        {
            Assert.IsTrue(stateMachine.HasTransition(
                state => state.iD == StateMachineBuilder.TransitionIDByLayerObjectToStateIDs,
                layer => layer.iD == StateMachineBuilder.layerWithIndex));
        }

        [TestMethod]
        public void HasTransitionPredicatesNonExistent_ReturnsFalse()
        {
            Assert.IsFalse(stateMachine.HasTransition(state => state.iD == "Something",
                layer => layer.iD == StateMachineBuilder.layerWithIndex));

            Assert.IsFalse(stateMachine.HasTransition(
                state => state.iD == StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                layer => layer.iD == "SomethingElse"));

        }
    }
}
