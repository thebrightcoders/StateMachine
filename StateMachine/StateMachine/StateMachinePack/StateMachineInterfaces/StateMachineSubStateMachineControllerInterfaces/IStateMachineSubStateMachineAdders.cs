using StateMachinePack;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineAdders
    {
        SubStateMachine AddSubStateMachine(string iD, string subMachineName, StateTransitionType stateTransitionType);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState,
            StateTransitionType stateTransitionType);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, Layer layerToAddState, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID,
            StateTransitionType stateTransitionType);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, string layerID, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex,
            StateTransitionType stateTransitionType);

        SubStateMachine AddSubStateMachine(string iD, string subMachineName, int layerIndex, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default);
    }
}
