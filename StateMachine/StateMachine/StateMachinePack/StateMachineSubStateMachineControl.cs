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
            List<Layer> foundLayers = new List<Layer>(GetLayers(layer => layer.HasSubStateMachine(selectionWay, text)));

            return GetSubStateMachine(selectionWay, text, GetLayer(GetListLocationIndex(stateSelection, foundLayers)));
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToGetState)
        {
            return layerToGetState.GetSubStateMachine(selectionWay, text);
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerIDToGetState)
        {
            return GetSubStateMachine(selectionWay, text, GetLayer(layerIDToGetState));
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndexToGetState)
        {
            return GetSubStateMachine(selectionWay, text, GetLayer(layerIndexToGetState));
        }

        public SubStateMachine[] GetSubStateMachines(SubStateMachineSelection selectionWay, string text)
        {
            List<SubStateMachine> gotSubStateMachines = new List<SubStateMachine>();
            foreach (Layer layer in layers)
                if (layer.HasSubStateMachine(selectionWay, text))
                    gotSubStateMachines.Add(layer.GetSubStateMachine(selectionWay, text));

            return gotSubStateMachines.ToArray();
        }

        public SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod)
        {
            return GetSubStateMachinesInLayers(subStateMachineCheckerMethod, layers.ToArray());
        }

        public SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return GetSubStateMachinesInLayers(subStateMachineCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private SubStateMachine[] GetSubStateMachinesInLayers(Predicate<SubStateMachine> stateCheckerMethod, Layer[] layers)
        {
            List<SubStateMachine> subStateMachines = new List<SubStateMachine>();
            foreach (Layer layer in layers)
                foreach (SubStateMachine subStateMachine in layer.subMachines.Values)
                    if (stateCheckerMethod(subStateMachine))
                        subStateMachines.Add(subStateMachine);

            return subStateMachines.ToArray();
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
            return HasSubStateMachinesInLayers(stateCheckerMethod, layers);
        }

        public bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return HasSubStateMachinesInLayers(stateCheckerMethod, new List<Layer>(GetLayers(layerCheckerMethod)));
        }

        private bool HasSubStateMachinesInLayers(Predicate<SubStateMachine> stateCheckerMethod, List<Layer> layers)
        {
            foreach (Layer layer in layers)
                foreach (SubStateMachine subStateMachine in layer.subMachines.Values)
                    if (stateCheckerMethod(subStateMachine))
                        return true;

            return false;
        }

        public void RemoveSubStateMachine(SubStateMachine subMachine)
        {
            subMachine.GetLayer().RemoveSubStateMachine(subMachine);
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, InListLocation stateSelection = InListLocation.First)
        {
            RemoveSubStateMachine(GetSubStateMachine(selectionWay, text, stateSelection));
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID)
        {
            RemoveSubStateMachine(GetSubStateMachine(selectionWay, text, GetLayer(layerID)));
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex)
        {
            RemoveSubStateMachine(GetSubStateMachine(selectionWay, text, GetLayer(layerIndex)));
        }

        public void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToRemoveState)
        {
            RemoveSubStateMachine(layerToRemoveState.GetSubStateMachine(selectionWay, text));
        }

        public void RemoveSubStateMachines(SubStateMachineSelection selectionWay, string text)
        {
            foreach (Layer layer in layers)
                if (layer.HasSubStateMachine(selectionWay, text))
                    layer.RemoveSubStateMachine(GetSubStateMachine(selectionWay, text, layer));
        }

        public void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod)
        {
            RemoveSubStateMachinesInLayers(subStateMachineCheckerMethod, layers.ToArray());
        }

        public void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            RemoveSubStateMachinesInLayers(subStateMachineCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private void RemoveSubStateMachinesInLayers(Predicate<SubStateMachine> subStateMachineCheckerMethod, Layer[] layers)
        {
            List<SubStateMachine> subStateMachines = new List<SubStateMachine>();
            foreach (Layer layer in layers)
                foreach (SubStateMachine subStateMachine in layer.subMachines.Values)
                    if (subStateMachineCheckerMethod(subStateMachine))
                        subStateMachines.Add(subStateMachine);

            foreach (SubStateMachine subStateMachine in subStateMachines)
                RemoveSubStateMachine(subStateMachine);
        }
    }
}
