using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicTransitionTests
{
    [TestClass]
    public class BasicGetTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates().WithTransitions();
        }

        [TestMethod]
        public void GetTransitionIDExistant_ReturnsNotNull()
        {
            Assert.IsNotNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDByLayerIDToStateIDs));
        }

        [TestMethod]
        public void GetTransitionIDNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransition("Something"));
        }

        [TestMethod]
        public void GetTransitionIDAndStateSelectionExistant_ReturnsNotNull()
        {
            Assert.IsNotNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDByLayerIDToStateIDs, InListLocation.Last));
        }

        [TestMethod]
        public void GetTransitionIDAndStateSelectionNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransition("Something", InListLocation.Last));
        }


        [TestMethod]
        public void GetTransitionIDWithLayerObjExistent_ReturnsNotNull()
        {
            Assert.IsNotNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                stateMachine.GetLayer(StateMachineBuilder.layerWithEnum)));
        }

        [TestMethod]
        public void GetTransitionIDWithLayerObjNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransition("Something",
                stateMachine.GetLayer(StateMachineBuilder.layerWithEnum)));
            Assert.IsNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                stateMachine.GetLayer(StateMachineBuilder.layerWithIndex)));
        }


        [TestMethod]
        public void GetTransitionIDWithLayerIDExistent_ReturnsNotNull()
        {
            Assert.IsNotNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void GetTransitionIDWithLayerIDNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransition("Something", StateMachineBuilder.layerWithEnum));
            Assert.IsNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void GetTransitionIDWithLayerIndexExistent_ReturnsNotNull()
        {
            Assert.IsNotNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, StateMachineBuilder.layerWithEnum));
        }

        [TestMethod]
        public void GetTransitionIDWithLayerIndexNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransition("Something", 0));
            Assert.IsNull(stateMachine.GetTransition(StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs, 1));
        }

        [TestMethod]
        public void GetTransitionsExistant_ReturnsCount4()
        {
            Assert.IsTrue(stateMachine.GetTransitions(StateMachineBuilder.TransitionIDByLayerIDToStateIDs).Length == 4);
        }

        [TestMethod]
        public void GetTransitionsNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransitions("Something"));
        }

        [TestMethod]
        public void GetTransitionPredicateExistant_ReturnsCount4()
        {
            Assert.IsTrue(stateMachine.GetTransitions(state => state.getID() == StateMachineBuilder.TransitionIDByLayerIDToStateIDs).Length == 4);
        }

        [TestMethod]
        public void GetTransitionPredicateNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransitions(state => state.getID() == "Something"));
        }

        [TestMethod]
        public void GetTransitionPredicatesExistant_ReturnsCount1()
        {
            Assert.IsTrue(stateMachine
                              .GetTransitions(
                                  state => state.getID() == StateMachineBuilder.TransitionIDByLayerIDToStateIDs,
                                  layer => layer.iD == StateMachineBuilder.layerWithIndex).Length == 1);
        }

        [TestMethod]
        public void GetTransitionPredicatesNonExistant_ReturnsNull()
        {
            Assert.IsNull(stateMachine.GetTransitions(
                                  state => state.getID() == StateMachineBuilder.TransitionIDToLastAddedLayerToStateIDs,
                                  layer => layer.iD == StateMachineBuilder.layerWithIndex));

            Assert.IsNull(stateMachine.GetTransitions(state => state.getID() == "Something",
                layer => layer.iD == StateMachineBuilder.layerWithIndex));
        }
    }
}
