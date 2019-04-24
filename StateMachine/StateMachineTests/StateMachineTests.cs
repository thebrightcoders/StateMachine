using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachinePack.Tests
{
    [TestClass()]
    public class StateMachineTests
    {
        [TestMethod()]
        public void AddLayer2paramsDefaultLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("DEFAULT"));
        }
        [TestMethod()]
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
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stateMachine.AddLayer("Ali3", 15, null));
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
        [TestMethod]
        public void HasLayerById()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsTrue(stateMachine.HasLayerById("DEFAULT"));
        }
        [TestMethod]
        public void HasLayerByIdWithInvalidId()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.HasLayerById("ALidaf?>?\\@!$!$#"));
        }
        [TestMethod]
        public void HasLayerByIdWithNullId()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.HasLayerById(null));
        }
        [TestMethod]
        public void HasLayerByLayer()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.IsNotNull(stateMachine.HasLayerByLayer(new Layer("DEFAULT")));
        }
        [TestMethod]
        public void HasLayerByLayerWithNullLayer()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.HasLayerByLayer(null));
        }
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
            Assert.ThrowsException<Exception>(() => stateMachine.GetLayer(null));
        }
        [TestMethod]
        public void GetLayerWithInvalidId()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.GetLayer("!#$!#$"));
        }

    }
}