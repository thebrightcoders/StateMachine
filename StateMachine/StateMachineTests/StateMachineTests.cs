using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests
{
    [TestClass]
    public class StateMachineTests
    {
        [TestMethod()]
        public void AddLayer2paramsDefaultLayerTest()
        {

            StateMachine stateMachine = new StateMachine();
            try
            {
                stateMachine.AddLayer("DEFAULT");
                Assert.Fail();
            }
            catch (Exception e) { }
        }
        [TestMethod]
        public void AddLayer2paramsDefaultWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            try
            {
                Assert.IsNull(stateMachine.AddLayer("        DEFAULT       "));
                Assert.Fail();
            }
            catch (Exception e) { }
        }

        [TestMethod]
        public void AddLayer2paramsDefaultNullStatesWithSpacesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            try
            {
                Assert.IsNull(stateMachine.AddLayer("        DEFAULT       ", null));
                Assert.Fail();
            }
            catch (Exception e) { }
        }
        [TestMethod]
        public void AddLayer2paramsNullStatesLayerTest()
        {
            StateMachine stateMachine = new StateMachine();
            try
            {
                Assert.IsNull(stateMachine.AddLayer("ALi", null));
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
        }
    }
}
