namespace StateMachine
{
    internal interface IState
    {
        void OnStateEnter(StateInfo stateInfo, StateMachine machine, Layer layer);
        void OnStateUpdate(StateInfo stateInfo, StateMachine machine, Layer layer);
        void OnStateExit(StateInfo stateInfo, StateMachine machine, Layer layer);
    }
}
