using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionGetters
    {
        Transition GetTransition(string iD, InListLocation transitionSelection = InListLocation.First);

        Transition GetTransition(string iD, Layer layerToGetTransition);

        Transition GetTransition(string iD, int layerIndex);

        Transition GetTransition(string iD, string layerID);

        Transition[] GetTransitions(string iD);

        Transition[] GetTransitions(Predicate<Transition> transitionCheckerMethod);

        Transition[] GetTransitions(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}
