using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachineTests.BasicTests.BasicLayerTests
{
    [TestClass]
    public class BasicGetLayerTests
    {
        [TestMethod]
        public void GetLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.GetLayer("DEFAULT"));
        }

        [TestMethod]
        public void GetLayerWithNullId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.GetLayer(null));
        }

        [TestMethod]
        public void GetLayerWithInvalidId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.GetLayer("!#$!#$"));
        }

        [TestMethod]
        public void GetLayerByIndexOutOfRange()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stateMachine.GetLayer(324));
        }
        [TestMethod]
        public void GetLastLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.GetLastLayer());
        }
        [TestMethod]
        public void GetFirstLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.GetFirstLayer());
        }
    }
}