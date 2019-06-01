using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateMachinePack;

namespace StateMachineTests.FullCreationTests
{
    [TestClass]
    public class FullMachineCreateTests
    {
        [TestMethod]
        public void StateMachineEmptyName_Returns_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new StateMachine(""));
        }

        [TestMethod]
        public void StateMachineNonValidName_Returns_ArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new StateMachine("!"));
        }

        [TestMethod]
        public void StateMachineValidName_Returns_DefaultLayer_DefaultStateAsStartup()
        {
            StateMachine stateMachine = new StateMachine("newMachine");

            Assert.IsTrue(stateMachine.name == "newMachine");
            Assert.IsTrue(stateMachine.HasLayer(Layer.DEFAULTID));
            Assert.IsTrue(stateMachine.HasState(Layer.DEFAULTSTARTSTATEID));
            Assert.IsTrue(stateMachine.GetLayer(Layer.DEFAULTID).IsStartupState(Layer.DEFAULTSTARTSTATEID));
        }

        [TestMethod]
        public void StateMachineValidNameWithSpaces_Returns_MachineWithNameWithoutExtraSpaces()
        {
            StateMachine stateMachine = new StateMachine("      new   Machine       ");

            Assert.IsTrue(stateMachine.name == "new   Machine");
        }
    }

}