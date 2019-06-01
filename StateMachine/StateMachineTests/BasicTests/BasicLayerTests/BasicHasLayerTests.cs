using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicLayerTests
{
    [TestClass]
    public class BasicHasLayerTests
    {
        [TestMethod]
        public void HasLayerById()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsTrue(stateMachine.HasLayer("DEFAULT"));
        }

        [TestMethod]
        public void HasLayerByIdWithInvalidId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.HasLayer("ALidaf?>?\\@!$!$#"));
        }

        [TestMethod]
        public void HasLayerByIdWithNullId()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasLayer((string) null));
        }

        [TestMethod]
        public void HasLayerByLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.HasLayer(stateMachine.GetLayer(Layer.DEFAULTID)));
        }

        [TestMethod]
        public void HasLayerByLayerWithNullLayer()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentNullException>(() => stateMachine.HasLayer((Layer) null));
        }
    }
}