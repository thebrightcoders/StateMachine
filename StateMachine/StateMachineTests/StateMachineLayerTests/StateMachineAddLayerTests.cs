using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.StateMachineLayerTests
{
    [TestClass]
    public class StateMachineAddLayerTests
    {
        [TestMethod]
        public void AddLayer2paramsDefaultLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT"));
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
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           "));
        }
        [TestMethod]
        public void AddLayer2paramsWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }
        [TestMethod]
        public void AddLayer3paramsDefaultWithSpacesLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           ", 1, null));
        }
        [TestMethod]
        public void AddLayer3paramsDefaultLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT", 1, null));
        }

        [TestMethod]
        public void AddLayer3paramLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali2", 1, null));
        }
        [TestMethod]
        public void AddLayer3paramsWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }
        [TestMethod]
        public void AddLayer3paramIndexOutOfRangeLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali3", 15, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali2", InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithNullIdLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.AddLayer(null, InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithDefaultIdIdLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT", InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithInvalidIDLayerTest()
        {
            StateMachinePack.StateMachine stateMachine = new StateMachinePack.StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf?>?\\@!$!$#"));
        }
    }
}