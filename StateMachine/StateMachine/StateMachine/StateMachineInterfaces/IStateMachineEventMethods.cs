namespace StateMachine.StateMachineInterfaces
{
    public interface IStateMachineEventMethods
    {
        void OnMachineStart(StateMachine machine);
        void OnMachineUpdate(StateMachine machine);
        void OnMachineStop(StateMachine machine);
    }
}