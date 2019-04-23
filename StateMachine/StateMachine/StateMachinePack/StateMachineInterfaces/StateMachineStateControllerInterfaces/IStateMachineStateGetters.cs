using StateMachinePack;
using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces
{
    public interface IStateMachineStateGetters
    {
        State GetState(string iD, InListLocation stateSelection = InListLocation.First);
        State GetState(string iD, Layer layerToGetState);
        State GetState(string iD, string layerIDToGetState);
        State GetState(string iD, int layerIndexToGetState);
        State[] GetStates(Predicate<State> stateCheckerMethod);
        State[] GetStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod);


    }
}