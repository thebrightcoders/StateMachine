using StateMachinePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineCheckers
    {
        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text);

        bool HasSubStateMachine(string iD, string machineName);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToFindSubStateMachine);

        bool HasSubStateMachine(string iD, string machineName, string layerID);

        bool HasSubStateMachine(string iD, string machineName, Layer layerToFindSubStateMachine);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text,
            InListLocation layerLocation = InListLocation.First);

        bool HasSubStateMachine(string iD, string machineName, InListLocation layerLocation = InListLocation.First);

        bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod);

        bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}
