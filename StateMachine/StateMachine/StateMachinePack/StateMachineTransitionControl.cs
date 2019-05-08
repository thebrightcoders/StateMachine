using StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineTransitionMethods
    {
        public Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, targetState, lastLayerAdded, conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, lastLayerAdded), targetState, conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, GetState(targetStateID, lastLayerAdded), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, lastLayerAdded), GetState(targetStateID, lastLayerAdded),
                conditions);
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, Layer layerToAddTransition, params Condition[] conditions)
        {
            return layerToAddTransition.AddTransition(iD, sourceState, targetState, conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, Layer layerToAddTransition, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerToAddTransition),
                GetState(targetStateID, layerToAddTransition), layerToAddTransition, conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, Layer layerToAddTransition, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerToAddTransition), targetState, layerToAddTransition,
                conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, Layer layerToAddTransition, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, GetState(targetStateID, layerToAddTransition),
                layerToAddTransition, conditions);
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, int layerIndex, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, targetState, GetLayer(layerIndex), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, int layerIndex, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerIndex), targetState, GetLayer(layerIndex), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, int layerIndex, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, GetState(targetStateID, layerIndex), GetLayer(layerIndex), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, int layerIndex, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerIndex), GetState(targetStateID, layerIndex), GetLayer(layerIndex), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, string layerID, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, targetState, GetLayer(layerID), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, string layerID, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerID), targetState, GetLayer(layerID), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, string layerID, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, GetState(targetStateID, layerID), GetLayer(layerID), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, string layerID, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerID), GetState(targetStateID, layerID), GetLayer(layerID), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, InListLocation layerLocation = InListLocation.First, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, targetState, GetLayer(layerLocation), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, InListLocation layerLocation = InListLocation.First, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerLocation), targetState, GetLayer(layerLocation), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, InListLocation layerLocation = InListLocation.First, params Condition[] conditions)
        {
            return AddTransition(iD, sourceState, GetState(targetStateID, layerLocation), GetLayer(layerLocation), conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, InListLocation layerLocation = InListLocation.First, params Condition[] conditions)
        {
            return AddTransition(iD, GetState(sourceStateID, layerLocation), GetState(targetStateID, layerLocation),
                GetLayer(layerLocation), conditions);
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, Predicate<Layer> layerCheckerMethod, params Condition[] conditions)
        {
            Layer layer = GetLayers(layerCheckerMethod)[0];
            return AddTransition(iD, sourceState, targetState, layer, conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, State targetState, Predicate<Layer> layerCheckerMethod, params Condition[] conditions)
        {
            Layer layer = GetLayers(layerCheckerMethod)[0];
            return AddTransition(iD, GetState(sourceStateID, layer), targetState, layer, conditions);
        }

        public Transition AddTransition(string iD, State sourceState, string targetStateID, Predicate<Layer> layerCheckerMethod, params Condition[] conditions)
        {
            Layer layer = GetLayers(layerCheckerMethod)[0];
            return AddTransition(iD, sourceState, GetState(targetStateID, layer), layer, conditions);
        }

        public Transition AddTransition(string iD, string sourceStateID, string targetStateID, Predicate<Layer> layerCheckerMethod, params Condition[] conditions)
        {
            Layer layer = GetLayers(layerCheckerMethod)[0];
            return AddTransition(iD, GetState(sourceStateID, layer), GetState(targetStateID, layer), layer, conditions);
        }

        public Transition AddTransition(string iD, Predicate<State> sourceStateCheckerMethod, Predicate<State> targetStateCheckerMethod, Predicate<Layer> layerCheckerMethod, params Condition[] conditions)
        {
            throw new NotImplementedException();
        }

        public Transition AddTransition(string iD, State state, StateTransitionType transitionType, params Condition[] conditions)
        {
            throw new NotImplementedException();
        }

        public Transition AddTransition(string iD, string stateID, StateTransitionType transitionType, params Condition[] conditions)
        {
            throw new NotImplementedException();
        }

        public Transition AddTransition(string iD, Predicate<State> stateCheckerMethod, StateTransitionType transitionType, params Condition[] conditions)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(string iD, InListLocation transitionSelection = InListLocation.First)
        {
            List<Transition> gotTransitions = new List<Transition>();
            foreach (Layer layer in layers)
                if(HasTransition(iD, layer))
                    gotTransitions.Add(GetTransition(iD, layer));
            if (gotTransitions.Count == 0)
                return null;
            return gotTransitions[GetListLocationIndex(transitionSelection, gotTransitions)];
        }

        public Transition GetTransition(string iD, Layer layerToGetTransition)
        {
            return layerToGetTransition.GetTransition(iD);
        }

        public Transition GetTransition(string iD, int layerIndex)
        {
            return GetTransition(iD, GetLayer(layerIndex));
        }

        public Transition GetTransition(string iD, string layerID)
        {
            return GetTransition(iD, GetLayer(layerID));
        }

        public Transition[] GetTransitions(string iD)
        {
            return GetTransitions(state => state.iD == iD);
        }

        public Transition[] GetTransitions(Predicate<Transition> transitionCheckerMethod)
        {
            return GetTransitionInLayers(transitionCheckerMethod, layers.ToArray());
        }

        public Transition[] GetTransitions(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return GetTransitionInLayers(transitionCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private Transition[] GetTransitionInLayers(Predicate<Transition> transitionCheckerMethod, Layer[] layers)
        {
            List<Transition> gotTransitions = new List<Transition>();
            foreach (Layer layer in layers)
                foreach (Transition transition in layer.transitions.Values)
                    if (transitionCheckerMethod(transition))
                        gotTransitions.Add(transition);
            if (gotTransitions.Count == 0)
                return null;
            return gotTransitions.ToArray();
        }

        public bool HasTransition(string iD)
        {
            foreach (Layer layer in layers)
                if (HasTransition(iD, layer))
                    return true;

            return false;
        }

        public bool HasTransition(string iD, Layer layerToFindTransition)
        {
            return layerToFindTransition.HasTransition(iD);
        }

        public bool HasTransition(string iD, string layerID)
        {
            return HasTransition(iD, GetLayer(layerID));
        }

        public bool HasTransition(string iD, int layerIndex)
        {
            return HasTransition(iD, GetLayer(layerIndex));
        }

        public bool HasTransition(string iD, InListLocation layerLocation = InListLocation.First)
        {
            return HasTransition(iD, GetLayer(GetLayerListLocationIndex(layerLocation)));
        }

        public bool HasTransition(Predicate<Transition> transitionCheckerMethod)
        {
            return HasTransitionInLayers(transitionCheckerMethod, layers.ToArray());
        }

        public bool HasTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            return HasTransitionInLayers(transitionCheckerMethod, GetLayers(layerCheckerMethod));
        }

        private bool HasTransitionInLayers(Predicate<Transition> transitionCheckerMethod, Layer[] layers)
        {
            foreach (Layer layer in layers)
                foreach (Transition transition in layer.transitions.Values)                
                    if (transitionCheckerMethod(transition))
                        return true;

            return false;
        }

        public void RemoveTransition(Transition transition)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(string iD, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(string iD, Layer layerToRemoveTransition)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(string iD, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(string iD, string layerID)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(Predicate<Transition> transitionCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }
    }
}