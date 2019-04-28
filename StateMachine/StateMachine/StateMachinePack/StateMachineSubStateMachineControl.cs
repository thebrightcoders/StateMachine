using StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces;
using System;

namespace StateMachinePack
{
    partial class StateMachine : IStateMachineSubStateMachineMethods
    {
        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(string iD, string subMachineName, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(string iD, string subMachineName, Layer layerToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerIDToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(string iD, string subMachineName, string layerIDToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndexToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine GetSubStateMachine(string iD, string subMachineName, int layerIndexToGetState)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine[] GetSubStateMachines(SubStateMachineSelection selectionWay, string text)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine[] GetSubStateMachines(string iD, string machineName)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(string iD, string machineName)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToFindSubStateMachine)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(string iD, string machineName, string layerID)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(string iD, string machineName, Layer layerToFindSubStateMachine)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, InListLocation layerLocation = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(string iD, string machineName, InListLocation layerLocation = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachine subMachine)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(string iD, string subMachineName, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(string iD, string subMachineName, string layerID)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(string iD, string subMachineName, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToRemoveState)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(string iD, string subMachineName, Layer layerToRemoveState)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachines(SubStateMachineSelection selectionWay, string text)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachines(string iD, string machineName)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }
    }
}
