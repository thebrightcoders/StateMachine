using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineTransitionTests
{
    [TestClass]
    public class StateMachineRemoveTransitionTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithStates().WithTransitions();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
