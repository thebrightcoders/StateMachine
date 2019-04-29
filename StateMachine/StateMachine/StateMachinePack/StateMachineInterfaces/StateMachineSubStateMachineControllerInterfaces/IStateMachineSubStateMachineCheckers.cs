using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineCheckers
    {
        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToFindSubStateMachine);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex);

        bool HasSubStateMachine(SubStateMachineSelection selectionWay, string text,
            InListLocation layerLocation = InListLocation.First);

        bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod);

        bool HasSubStateMachine(Predicate<SubStateMachine> stateCheckerMethod, Predicate<Layer> layerCheckerMethod);
    }
}
