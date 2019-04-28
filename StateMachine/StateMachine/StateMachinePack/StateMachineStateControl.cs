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
            if (this.lastLayerAdded == null)
                throw new Exception("The last added Layer is removed!");
            return this.lastLayerAdded.AddState(iD, isLoop, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, StateTransitionType stateTransitionType)
        {
            return AddState(iD, layerToAddState, false, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            if (layerToAddState == null)
                throw new Exception("The layerToAddState is 'null'");
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

        public bool HasState(string iD)
        {
            if (this.lastLayerAdded == null)
                throw new Exception("The last added Layer is removed!");
            Validator.ValidateID(ref iD);

            return this.lastLayerAdded.states.ContainsKey(iD);
        }

        public bool HasState(string iD, string layerID)
        {
            Validator.ValidateID(ref iD);

            return GetLayer(layerID).states.ContainsKey(iD);
        }

        public bool HasState(string iD, int layerIndex)
        {
            Validator.ValidateID(ref iD);

            return GetLayer(layerIndex).states.ContainsKey(iD);
        }

        public bool HasState(string iD, InListLocation layerLocation = InListLocation.First)
        {
            return HasState(iD, layerLocation == InListLocation.First ? 0 : InListLocation.Last);
        }

        public bool HasState(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            List<Layer> layers = new List<Layer>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(this.layers[i]))
                {
                    layers.Add(this.layers[i]);
                }
            }

            if (layers.Count < 0)
                return false;

            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    if (stateCheckerMethod(tempStates[i]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public State GetState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            Validator.ValidateID(ref iD);
            List<State> gotStates = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                gotStates.AddRange(
                    layers[i].states.Values.ToList()
                        .FindAll(state => state.stateInfo.iD == iD));
            }

            return stateSelection == InListLocation.First ? gotStates[0] : gotStates[gotStates.Count - 1];
        }

        public State GetState(string iD, Layer layerToGetState)
        {
            Validator.ValidateID(ref iD);
            State state;
            layerToGetState.states.TryGetValue(iD, out state);
            return state;
        }

        public State GetState(string iD, string layerIDToGetState)
        {
            return GetState(iD, GetLayer(layerIDToGetState));
        }

        public State GetState(string iD, int layerIndexToGetState)
        {
            return GetState(iD, GetLayer(layerIndexToGetState));
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod)
        {
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is 'null'");
            List<State> gotStates = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                gotStates.AddRange(
                    layers[i].states.Values.ToList()
                        .FindAll(stateCheckerMethod));
            }

            return gotStates.ToArray();
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is null");
            if (layerCheckerMethod == null)
                throw new Exception("The layerCheckerMethod is null");
            List<Layer> layers = new List<Layer>();
            List<State> states = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(this.layers[i]))
                {
                    layers.Add(this.layers[i]);
                }
            }

            if (layers.Count < 0)
                return null;
            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    if (stateCheckerMethod(tempStates[i]))
                    {
                        states.Add(tempStates[i]);
                    }
                }
            }

            return states.ToArray();
        }

        public void RemoveState(State state)
        {
            if (state == null)
                throw new Exception("The state is 'null'");
            Layer layer = state.layer;
            if (layer == null)
                throw new Exception("The state's layer is 'null'");
            layer.RemoveState(state);
        }

        public void RemoveState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            Validator.ValidateID(ref iD);
            List<State> gotStates = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                gotStates.AddRange(
                    layers[i].states.Values.ToList()
                        .FindAll(state => state.stateInfo.iD == iD));
            }

            State toDeleteState = gotStates[stateSelection == InListLocation.First ? 0 : gotStates.Count - 1];
            Layer layer = toDeleteState.layer;
            if (layer == null)
                throw new Exception("The state's layer is 'null'");
            layer.RemoveState(toDeleteState);
        }

        public void RemoveState(string iD, string layerID)
        {
            GetLayer(layerID).RemoveState(GetState(iD));
        }

        public void RemoveState(string iD, int layerIndex)
        {
            GetLayer(layerIndex).RemoveState(GetState(iD));
        }

        public void RemoveState(string iD, Layer layerToRemoveState)
        {
            layerToRemoveState.RemoveState(GetState(iD));
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod)
        {
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is null");

            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    State state = tempStates[i];
                    if (stateCheckerMethod(state))
                    {
                        Layer layer = state.layer;
                        if (layer == null)
                            throw new Exception("The state's layer is 'null'");
                        layer.RemoveState(state);
                    }
                }
            }
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is null");
            if (layerCheckerMethod == null)
                throw new Exception("The layerCheckerMethod is null");
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is null");
            if (layerCheckerMethod == null)
                throw new Exception("The layerCheckerMethod is null");
            List<Layer> layers = new List<Layer>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(this.layers[i]))
                {
                    layers.Add(this.layers[i]);
                }
            }

            if (layers.Count < 0)
                return;

            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    State state = tempStates[i];
                    if (stateCheckerMethod(tempStates[i]))
                    {
                        Layer layer = state.layer;
                        if (layer == null)
                            throw new Exception("The state's layer is 'null'");
                        layer.RemoveState(state);
                    }
                }
            }
        }
    }
}