using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachinePack;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionAdders
    {
        Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, Layer layerToAddTransition,
            params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, int layerIndex,
            params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, string layerID,
            params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState,
            InListLocation layerLocation = InListLocation.First, params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, Predicate<Layer> layerCheckerMethod,
            params Condition[] conditions);
    }
}
