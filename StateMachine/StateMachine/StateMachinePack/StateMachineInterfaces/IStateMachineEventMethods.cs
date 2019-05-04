namespace StateMachinePack.StateMachineInterfaces
{
    public interface IStateMachineEventMethods
    {
        void OnMachineStart(StateMachine machine);
        void OnMachineProcess(StateMachine machine);
        void OnMachineStop(StateMachine machine);
    }
}