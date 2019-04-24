namespace StateMachinePack.LayerInterfaces
{
    internal interface ILayerStateMethods
    {
        State AddState(string iD, bool isLoop, StateTransitionType stateTransitionType);
        State GetState(string iD);
        bool HasState(string iD);
        void RemoveState(State state);
    }
}