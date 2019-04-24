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

        [TestMethod]
        public void AddLayer2paramsDefaultWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("          DEFAULT           "));
        }

        [TestMethod]
        public void AddLayer2paramsDefaultNullStatesWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("     DEFAULT     ", null));
        }

        [TestMethod]
        public void AddLayer2paramsNullStatesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            Assert.ThrowsException<Exception>(() => stateMachine.AddLayer("ALi", null));
        }
    }
}