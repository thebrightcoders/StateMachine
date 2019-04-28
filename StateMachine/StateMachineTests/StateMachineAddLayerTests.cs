using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineAddLayerTests
    {
        [TestMethod]
        public void AddLayer2paramsDefaultLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT"));
        }
        [TestMethod]
        public void AddLayer2paramsNullIDLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer(null));
        }
        [TestMethod]
        public void AddLayer2paramsDefaultWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           "));
        }
        [TestMethod]
        public void AddLayer2paramsWithInvalidIDLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }
        [TestMethod]
        public void AddLayer3paramsDefaultWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           ", 1, null));
        }
        [TestMethod]
        public void AddLayer3paramsDefaultLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT", 1, null));
        }

        [TestMethod]
        public void AddLayer3paramLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali2", 1, null));
        }
        [TestMethod]
        public void AddLayer3paramsWithInvalidIDLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf@!$!$#"));
        }
        [TestMethod]
        public void AddLayer3paramIndexOutOfRangeLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali3", 15, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.AddLayer("Ali2", InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithNullIdLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer(null, InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithDefaultIdIdLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT", InListLocation.Last, null));
        }
        [TestMethod]
        public void AddLayer3paramInListLocationWithInvalidIDLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALidaf?>?\\@!$!$#"));
        }
    }
}