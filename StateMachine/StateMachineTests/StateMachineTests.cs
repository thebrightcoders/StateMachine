﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void AddLayer3paramsDefaultWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           ",1,null));
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
        public void AddLayer3paramIndexOutOfRangeLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stateMachine.AddLayer("Ali3", 15, null));
        }
    }
}