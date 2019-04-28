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
        Start, Update, Stop
    }
    public enum StateMethodType
    {
        Enter, Update, Exit
    }
    public enum StateTransitionType
    {
        Default, StartUp, FromAny, Exit = 4
    }

    public enum SubStateMachineSelection
    {
        Name, ID
    }
}
