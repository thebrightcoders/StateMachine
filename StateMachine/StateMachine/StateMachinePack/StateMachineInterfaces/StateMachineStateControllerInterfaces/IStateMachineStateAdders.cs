namespace StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces
{
    public interface IStateMachineStateAdders
    {
        State AddState(string iD, StateTransitionType stateTransitionType);
        State AddState(string iD, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default);
        State AddState(string iD, Layer layerToAddState, StateTransitionType stateTransitionType);
        State AddState(string iD, Layer layerToAddState, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default);
        State AddState(string iD, string layerID, StateTransitionType stateTransitionType);
        State AddState(string iD, string layerID, bool isLoop = false,StateTransitionType stateTransitionType = StateTransitionType.Default);
        State AddState(string iD, int layerIndex, StateTransitionType stateTransitionType);
        State AddState(string iD, int layerIndex, bool isLoop = false,StateTransitionType stateTransitionType = StateTransitionType.Default);

    }
}