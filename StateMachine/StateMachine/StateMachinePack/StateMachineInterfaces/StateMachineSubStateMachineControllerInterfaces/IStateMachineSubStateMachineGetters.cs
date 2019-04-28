using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineGetters
    {

        SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text,
            InListLocation stateSelection = InListLocation.First);

        SubStateMachine GetSubStateMachine(string iD, string subMachineName,
            InListLocation stateSelection = InListLocation.First);

        SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text, Layer layerToGetState);

        SubStateMachine GetSubStateMachine(string iD, string subMachineName, Layer layerToGetState);

        SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text,
            string layerIDToGetState);

        SubStateMachine GetSubStateMachine(string iD, string subMachineName, string layerIDToGetState);

        SubStateMachine GetSubStateMachine(SubStateMachineSelection selectionWay, string text,
            int layerIndexToGetState);

        SubStateMachine GetSubStateMachine(string iD, string subMachineName, int layerIndexToGetState);

        SubStateMachine[] GetSubStateMachines(SubStateMachineSelection selectionWay, string text);

        SubStateMachine[] GetSubStateMachines(string iD, string machineName);

        SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod);

        SubStateMachine[] GetSubStateMachines(Predicate<SubStateMachine> subStateMachineCheckerMethod,
            Predicate<Layer> layerCheckerMethod);
    }
}
