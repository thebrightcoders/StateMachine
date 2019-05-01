using StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    partial class StateMachine : IStateMachineSubStateMachineMethods
    {
        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, StateTransitionType stateTransitionType)
        {
            return AddSubStateMachine(iD, subMachineName, lastLayerAdded, stateTransitionType);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddSubStateMachine(iD, subMachineName, lastLayerAdded, isLoop, stateTransitionType);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState,
                                                  StateTransitionType stateTransitionType)
        {
            return AddSubStateMachine(iD, subMachineName, layerToAddState, false, stateTransitionType);
        }


        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState,
                                                  bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return layerToAddState.AddSubStateMachine(iD, subMachineName, isLoop, stateTransitionType);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID, StateTransitionType stateTransitionType)
        {
            return AddSubStateMachine(iD, subMachineName, GetLayer(layerID), stateTransitionType);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID, bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddSubStateMachine(iD, subMachineName, GetLayer(layerID), isLoop, stateTransitionType);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex, StateTransitionType stateTransitionType)
        {
            return AddSubStateMachine(iD, subMachineName, GetLayer(layerIndex), StateTransitionType.Default);
        }

        public SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex, bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddSubStateMachine(iD, subMachineName, GetLayer(layerIndex), isLoop, StateTransitionType.Default);
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
            foreach (Layer layer in layers)
                if (HasSubStateMachine(selectionWay, text, layer))
                    return true;

            return false;
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID)
        {
            return HasSubStateMachine(selectionWay, text, GetLayer(layerID));
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToFindSubStateMachine)
        {
            return layerToFindSubStateMachine.HasSubStateMachine(selectionWay, text);
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex)
        {
            return HasSubStateMachine(selectionWay, text, GetLayer(layerIndex));
        }

        public bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, InListLocation layerLocation = InListLocation.First)
        {
            return HasSubStateMachine(selectionWay, text, GetLayer(layerLocation));
        }

        public bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod)
        {
            return GetSubStateMachinesInLayers(stateCheckerMethod, layers);
        }

        public bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return GetSubStateMachinesInLayers(stateCheckerMethod, new List<Layer>(GetLayers(layerCheckerMethod)));
        }

        private bool GetSubStateMachinesInLayers(Predicate<SubStateMachine> stateCheckerMethod, List<Layer> layers)
        {
            foreach (Layer layer in layers)
                foreach (SubStateMachine subStateMachine in layer.subMachines.Values)
                    if (stateCheckerMethod(subStateMachine))
                        return true;

            return false;
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
