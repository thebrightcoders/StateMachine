using System;
using System.Collections.Generic;
using System.Linq;
using StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineStateMethods
    {
        public State AddState(string iD, StateTransitionType stateTransitionType)
        {
            return AddState(iD, false, stateTransitionType);
        }

        public State AddState(string iD, bool isLoop = false,
                              StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddState(iD, lastLayerAdded, isLoop, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, StateTransitionType stateTransitionType)
        {
            return AddState(iD, layerToAddState, false, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, bool isLoop = false,
                              StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return layerToAddState.AddState(iD, isLoop, stateTransitionType);
        }

        public State AddState(string iD, string layerID, StateTransitionType stateTransitionType)
        {
            return AddState(iD, GetLayer(iD), stateTransitionType);
        }

        public State AddState(string iD, string layerID, bool isLoop = false,
                              StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddState(iD, GetLayer(iD), isLoop, stateTransitionType);
        }

        public State AddState(string iD, int layerIndex, StateTransitionType stateTransitionType)
        {
            return AddState(iD, GetLayer(layerIndex), stateTransitionType);
        }

        public State AddState(string iD, int layerIndex, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddState(iD, GetLayer(layerIndex), isLoop, stateTransitionType);
        }

        public bool HasState(string iD, Layer layerToCheck)
        {
            return layerToCheck.HasState(iD);
        }

        public bool HasState(string iD)
        {
            return HasState(iD, lastLayerAdded);
        }

        public bool HasState(string iD, string layerID)
        {
            return HasState(iD, GetLayer(layerID));
        }

        public bool HasState(string iD, int layerIndex)
        {
            return HasState(iD, GetLayer(layerIndex));
        }

        public bool HasState(string iD, InListLocation layerLocation = InListLocation.First)
        {
            return HasState(iD, GetLayerListLocationIndex(layerLocation));
        }

        public bool HasState(Predicate<State> stateCheckerMethod)
        {
            return HasStateInLayers(stateCheckerMethod, layers.ToArray());
        }

        public bool HasState(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return HasStateInLayers(stateCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private bool HasStateInLayers(Predicate<State> stateCheckerMethod, Layer[] layers)
        {
            foreach (Layer layer in layers)
                foreach (State state in layer.states.Values)
                    if (stateCheckerMethod(state))
                        return true;

            return false;
        }

        public State GetState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            List<State> gotStates = new List<State>();
            foreach (Layer layer in layers)
            {
                State found = GetState(iD, layer);
                if (found != null)
                    gotStates.Add(found);
            }

            return gotStates[GetLayerListLocationIndex(stateSelection)];
        }

        public State GetState(string iD, Layer layerToGetState)
        {
            Validator.ValidateID(ref iD);
            return layerToGetState.GetState(iD);
        }

        public State GetState(string iD, string layerIDToGetState)
        {
            return GetState(iD, GetLayer(layerIDToGetState));
        }

        public State GetState(string iD, int layerIndexToGetState)
        {
            return GetState(iD, GetLayer(layerIndexToGetState));
        }

        public State[] GetStates(string iD)
        {
            List<State> gotStates = new List<State>();
            foreach (Layer layer in layers)
                if (layer.HasState(iD))
                    gotStates.Add(layer.GetState(iD));

            return gotStates.ToArray();
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod)
        {
            return GetStatesInLayers(stateCheckerMethod, layers.ToArray());
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return GetStatesInLayers(stateCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private State[] GetStatesInLayers(Predicate<State> stateCheckerMethod, Layer[] layers)
        {
            List<State> states = new List<State>();

            foreach (Layer layer in layers)
            {
                foreach (State state in layer.states.Values)
                {
                    if (stateCheckerMethod(state))
                    {
                        states.Add(state);
                    }
                }
            }

            return states.ToArray();
        }


        public void RemoveState(State state)
        {
            state.layer.RemoveState(state);
        }

        public void RemoveState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            RemoveState(GetStates(state => state.stateInfo.iD == iD)[GetLayerListLocationIndex(stateSelection)]);
        }

        public void RemoveState(string iD, string layerID)
        {
            RemoveState(iD, GetLayer(layerID));
        }

        public void RemoveState(string iD, int layerIndex)
        {
            RemoveState(iD, GetLayer(layerIndex));
        }

        public void RemoveState(string iD, Layer layerToRemoveState)
        {
            layerToRemoveState.RemoveState(GetState(iD));
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod)
        {
            foreach (Layer layer in layers)
            {
                foreach (State state in layer.states.Values)
                {
                    if (stateCheckerMethod(state))
                    {
                        RemoveState(state);
                    }
                }
            }
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            foreach (Layer layer in GetLayers(layerCheckerMethod))
            {
                foreach (State state in layer.states.Values)
                {
                    if (stateCheckerMethod(state))
                    {
                        RemoveState(state);
                    }
                }
            }
        }

    }
}