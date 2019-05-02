using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineRemovers
    {
        void RemoveSubStateMachine(SubStateMachine subMachine);

        void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text,
            InListLocation stateSelection = InListLocation.First);

        void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, string layerID);

        void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, int layerIndex);

        void RemoveSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToRemoveState);

        void RemoveSubStateMachines(SubStateMachineSelection selectionWay, string text);

        void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod);

        void RemoveSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod,
            Predicate<Layer> layerCheckerMethod);
    }
}
