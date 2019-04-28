using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachinePack;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionGetters
    {
        Transition GetTransition(string iD, InListLocation stateSelection = InListLocation.First);

        Transition GetTransition(string iD, Layer layerToGetTransition);

        Transition GetTransition(string iD, int layerIndex);

        Transition GetTransition(string iD, string layerID);

        Transition GetTransition(Predicate<Transition> transitionCheckerMethod);

        Transition GetTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}
