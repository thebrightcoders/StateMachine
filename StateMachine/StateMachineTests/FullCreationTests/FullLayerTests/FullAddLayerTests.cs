using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.FullCreationTests.FullLayerTests
{
    [TestClass]
    public class FullAddLayerTests
    {
        private StateMachine stateMachine;
        [TestInitialize]
        public void SetUp() => stateMachine = StateMachineBuilder.Build();

        [TestMethod]
        public void LayerNullName_Returns_NullException()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddLayer(null));
        }

        [TestMethod]
        public void LayerEmptyName_Returns_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer(""));
        }

        [TestMethod]
        public void LayerNonValidName_Returns_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("!"));
        }

        [TestMethod]
        public void LayerValidExistantName_Returns_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer(Layer.DEFAULTID));
        }

        [TestMethod]
        public void LayerValidNonExistantName_Returns_LayerCountOf2()
        {
            Layer newLayer = stateMachine.AddLayer("newLayer");
            Assert.AreEqual(stateMachine.GetLayersListCount(), 2);
            Assert.AreEqual(stateMachine.GetLayer("newLayer"), newLayer);
        }

        [TestMethod]
        public void LayerValidNameWithWhiteSpace_Returns_LayerCountOf2WithNameWithoutWhiteSpaces()
        {
            Layer newLayer = stateMachine.AddLayer("    new   Layer     ");
            Assert.AreEqual(stateMachine.GetLayersListCount(), 2);
            Assert.AreEqual(stateMachine.GetLayer("new   Layer"), newLayer);
        }


    }
}
