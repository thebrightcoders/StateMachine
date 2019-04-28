using StateMachinePack;
using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces
{
    public interface IStateMachineStateRemovers
    {
        void RemoveState(State state);
        void RemoveState(string iD, InListLocation stateSelection = InListLocation.First);
        void RemoveState(string iD, string layerID);
        void RemoveState(string iD, int layerIndex);
        void RemoveState(string iD, Layer layerToRemoveState);
        void RemoveStates(Predicate<State> stateCheckerMethod);
        void RemoveStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod);

    }
}