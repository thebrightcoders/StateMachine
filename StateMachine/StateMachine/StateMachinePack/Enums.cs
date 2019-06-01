namespace StateMachinePack
{
    public enum InListLocation
    {
        First, Last
    }
    public enum MachineExecutionOrder
    {
        OnTimeSpanTrick, OnCall
    }
    public enum MachineExecutionType
    {
        Serial, Parallel
    }
    public enum MachineMethodType
    {
        Start, Process, Stop
    }
    public enum StateMethodType
    {
        Enter, Process, Exit
    }
    public enum StateTransitionType
    {
        Default, Startup, FromAny, Exit = 4
    }

    public enum SubStateMachineSelection
    {
        Name, ID
    }
}
