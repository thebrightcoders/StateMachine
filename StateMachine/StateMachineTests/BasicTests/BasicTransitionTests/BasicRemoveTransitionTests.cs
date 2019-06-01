using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicTransitionTests
{
    [TestClass]
    public class BasicRemoveTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates().WithTransitions();
        }

        [TestMethod]
        public void RemoveByObj()
        {
            Transition t = stateMachine.AddTransition("newTransition",
                StateMachineBuilder.StateIDToLayerByIDStateTransition, StateMachineBuilder.StateIDToLayerByIDBoth,
                StateMachineBuilder.layerWithID);
            stateMachine.RemoveTransition(t);
            Assert.IsFalse(stateMachine.HasTransition("newTransition", StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemovePredicate()
        {
            stateMachine.RemoveTransitions(transition => transition.iD == StateMachineBuilder.TransitionIDByLayerIDToStateIDs);
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDByLayerIDToStateIDs, StateMachineBuilder.layerWithID));
        }

        [TestMethod]
        public void RemovePredicates()
        {
            stateMachine.RemoveTransitions(
                transition => transition.iD == StateMachineBuilder.TransitionIDByLayerIDToStateIDs, layer => layer.iD == StateMachineBuilder.layerWithID);
            Assert.IsFalse(stateMachine.HasTransition(StateMachineBuilder.TransitionIDByLayerIDToStateIDs, StateMachineBuilder.layerWithID));
        }
    }
}
