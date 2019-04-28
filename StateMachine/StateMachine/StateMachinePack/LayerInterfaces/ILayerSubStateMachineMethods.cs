namespace StateMachinePack.LayerInterfaces
{   internal interface ILayerSubStateMachineMethods
    {
        
        SubStateMachine AddSubStateMachine(string iD, string machineName, bool isLoop, StateTransitionType stateTransitionType);
        SubStateMachine GetSubStateMachine(SubStateMachineSelection nameOrID, string text);
        bool HasSubStateMachine(SubStateMachineSelection nameOrID, string text);
        void RemoveSubStateMachine(SubStateMachine subMachine);
    }
}