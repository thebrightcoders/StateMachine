namespace StateMachinePack
{
    internal interface IState
    {
        void OnStateEnter(StateInfo stateInfo, StateMachine machine, Layer layer);
        void OnStateProcess(StateInfo stateInfo, StateMachine machine, Layer layer);
        void OnStateExit(StateInfo stateInfo, StateMachine machine, Layer layer);
    }
}
