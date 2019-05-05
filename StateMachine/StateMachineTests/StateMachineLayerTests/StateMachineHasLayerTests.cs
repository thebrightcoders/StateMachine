using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineLayerTests
{
    [TestClass]
    public class StateMachineHasLayerTests
    {
        [TestMethod]
        public void HasLayerById()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsTrue(stateMachine.HasLayerById("DEFAULT"));
        }

        [TestMethod]
        public void HasLayerByIdWithInvalidId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.HasLayerById("ALidaf?>?\\@!$!$#"));
        }

        [TestMethod]
        public void HasLayerByIdWithNullId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasLayerById(null));
        }

        [TestMethod]
        public void HasLayerByLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.HasLayer(stateMachine.GetLayer(Layer.DEFAULT)));
        }

        [TestMethod]
        public void HasLayerByLayerWithNullLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentNullException>(() => stateMachine.HasLayer(null));
        }
    }
}