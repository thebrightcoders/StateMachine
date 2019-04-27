// StateMachine -> StateMachineTests -> StateMachineHasLayerTests.cs
// Author:  Dell
// Created In: // 
// Company: The Bright Coders

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StateMachinePack.Tests
{
    [TestClass]
    public class StateMachineHasLayerTests
    {
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
    }
}