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
            try
            {
                stateMachine.AddLayer("DEFAULT");
                Assert.Fail();
            }
            catch (Exception e)
            {
            }
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
            catch (Exception e)
            {
            }
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
            catch (Exception e)
            {
            }
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