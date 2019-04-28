using StateMachinePack;
using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces
{
    public interface IStateMachineStateCheckers
    {
        bool HasState(string iD);
        bool HasState(string iD, string layerID);
        bool HasState(string iD, int layerIndex);
        bool HasState(string iD, Layer layerToCheck);
        bool HasState(string iD, InListLocation layerLocation = InListLocation.First);
        bool HasState(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}