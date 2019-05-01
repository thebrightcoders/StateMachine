using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineGetLayerTests
    {
        [TestMethod]
        public void GetLayer()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.GetLayer("DEFAULT"));
        }

        [TestMethod]
        public void GetLayerWithNullId()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.GetLayer(null));
        }

        [TestMethod]
        public void GetLayerWithInvalidId()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.GetLayer("!#$!#$"));
        }

        [TestMethod]
        public void GetLayerByIndexOutOfRange()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stateMachine.GetLayer(324));
        }
        [TestMethod]
        public void GetLastLayer()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.GetLastLayer());
        }
        [TestMethod]
        public void GetFirstLayer()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.GetFirstLayer());
        }
    }
}