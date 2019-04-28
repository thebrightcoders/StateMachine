namespace StateMachinePack.LayerInterfaces
{
    internal interface ILayerConditionMethods
    {
        Condition AddCondition(Transition transition, Condition condition);
        //Condition GetCondition();
        //bool HasCondition();
        void RemoveCondition(Transition transition, Condition condition);
    }
}