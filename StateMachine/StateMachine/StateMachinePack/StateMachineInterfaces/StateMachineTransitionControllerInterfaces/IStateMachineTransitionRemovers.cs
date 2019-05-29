using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionRemovers
    {
        void RemoveTransition(Transition transition);

        void RemoveTransition(string iD, InListLocation stateSelection = InListLocation.First);

        void RemoveTransition(string iD, Layer layerToRemoveTransition);

        void RemoveTransition(string iD, int layerIndex);

        void RemoveTransition(string iD, string layerID);

        void RemoveTransitions(Predicate<Transition> transitionCheckerMethod);

        void RemoveTransitions(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod);

    }
}
