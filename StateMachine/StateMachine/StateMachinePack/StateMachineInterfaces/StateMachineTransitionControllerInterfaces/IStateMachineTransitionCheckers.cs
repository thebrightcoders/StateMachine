using StateMachinePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionCheckers
    {
        bool HasTransition(string iD);

        bool HasTransition(string iD, Layer layerToFindTransition);

        bool HasTransition(string iD, string layerID);

        bool HasTransition(string iD, int layerIndex);

        bool HasTransition(string iD, InListLocation layerLocation = InListLocation.First);

        bool HasTransition(Predicate<Transition> transitionCheckerMethod);

        bool HasTransition(Predicate<Transition> transitionCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}
