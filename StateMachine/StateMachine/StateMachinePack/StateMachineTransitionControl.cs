using StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces;
using System;

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

        public Transition GetTransition(string iD, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(string iD, Layer layerToGetTransition)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(string iD, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(string iD, string layerID)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(Predicate<Transition> transitionCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD, Layer layerToFindTransition)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD, string layerID)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD, InListLocation layerLocation = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(Predicate<Transition> transitionCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
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