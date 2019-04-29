using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineHasSubStateMachineTests
    {
        const string invalidID = "!@#";
        private StateMachine stateMachine;

        [TestInitialize]
        public void SetUp()
        {
            stateMachine = StateMachineBuilder.Build().WithLayers().WithSubStateMachines();
        }

        [TestMethod]
        public void SearchWithIDNull_ThorwsException()
        {
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasState(null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, null));
            Assert.ThrowsException<NullReferenceException>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, null));
        }

        [TestMethod]
        public void SearchWithIDInvalid_ThorwsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, invalidID));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, invalidID));
        }

        [TestMethod]
        public void SearchWithIDEmpty_ThorwsException()
        {
            Assert.ThrowsException<Exception>(() => stateMachine.HasState(""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, ""));
            Assert.ThrowsException<Exception>(() => stateMachine.HasState("     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.ID, "     "));
            Assert.ThrowsException<Exception>(() => stateMachine.HasSubStateMachine(SubStateMachineSelection.Name, "     "));
        }

    }
}
