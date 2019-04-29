using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineHasSubStateMachineTests
    {
        [TestMethod]
        public void AddSubMachineToLayer_LayerMustHaveIt()
        {
            StateMachine stateMachine = new StateMachine();
            stateMachine.AddSubStateMachine("newState", "newSubMachine", Layer.DEFAULT);
            Assert.IsTrue(stateMachine.HasState("newState", Layer.DEFAULT));
        }

        [TestMethod]
        public void AddSubMachineToLastAddedLayer_ThatLayerMustHaveIt()
        {
            StateMachine stateMachine = new StateMachine();
            stateMachine.AddLayer("newLayer");
            stateMachine.AddSubStateMachine("newState", "newSubMachine", "newLayer");
            Assert.IsTrue(stateMachine.HasState("newState", "newLayer"));
        }
    }
}
