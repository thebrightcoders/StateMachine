using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.BasicTests.BasicLayerTests
{
    [TestClass]
    public class BasicAddLayerTests
    {
        [TestMethod]
        public void AddLayer2paramsDefaultLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("DEFAULT"));
        }
        [TestMethod]
        public void AddLayer2paramsNullIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddLayer(null));
        }
        [TestMethod]
        public void AddLayer2paramsDefaultWithSpacesLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("          DEFAULT           "));
        }
        [TestMethod]
        public void AddLayer2paramsWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }

        [TestMethod]
        public void AddLayer3paramsWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }

        [TestMethod]
        public void AddLayer3paramInListLocationWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<ArgumentException>(() => stateMachine.AddLayer("ALidaf?>?\\@!$!$#"));
        }
    }
}