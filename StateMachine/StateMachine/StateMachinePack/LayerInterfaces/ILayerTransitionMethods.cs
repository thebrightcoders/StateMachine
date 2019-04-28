namespace StateMachinePack.LayerInterfaces
{
    internal interface ILayerTransitionMethods
    {
        Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditionMethods);
        Transition GetTransition(string iD);
        bool HasTransition(string iD);
        void RemoveTransition(Transition transition);
    }
}