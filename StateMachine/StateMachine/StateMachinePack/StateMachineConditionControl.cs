using StateMachinePack.StateMachineInterfaces.StateMachineConditionControllerInterfaces;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineConditionMethods
    {
        public Condition AddCondition(Transition transition, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public Condition AddCondition(string transitionID, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public Condition AddCondition(string transitionID, string layerID, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public Condition AddCondition(string transitionID, Layer layer, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public Condition AddCondition(string transitionID, int layerIndex, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCondition(Transition transition, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCondition(string transitionID, string layerID, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCondition(string transitionID, Layer layer, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCondition(string transitionID, int layerIndex, Condition conditionMethod)
        {
            throw new System.NotImplementedException();
        }
    }
}