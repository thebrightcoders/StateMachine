using StateMachinePack.StateMachineInterfaces.StateMachineConditionControllerInterfaces;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineConditionMethods
    {
        //public Condition AddCondition(string transitionID, Condition conditionMethod)
        //{
        //    return AddCondition(GetTransition(transitionID), conditionMethod));
        //}

        public Condition AddCondition(Transition transition, Condition conditionMethod)
        {
            return transition.AddCondition(conditionMethod);
        }

        public Condition AddCondition(string transitionID, string layerID, Condition conditionMethod)
        {
            return AddCondition(transitionID, GetLayer(layerID), conditionMethod);
        }

        public Condition AddCondition(string transitionID, Layer layer, Condition conditionMethod)
        {
            return AddCondition(GetTransition(transitionID, layer), conditionMethod);
        }

        public Condition AddCondition(string transitionID, int layerIndex, Condition conditionMethod)
        {
            return AddCondition(transitionID, GetLayer(layerIndex), conditionMethod);
        }

        public void RemoveCondition(Transition transition, Condition conditionMethod)
        {
            transition.RemoveCondition(conditionMethod);
        }

        public void RemoveCondition(string transitionID, string layerID, Condition conditionMethod)
        {
            RemoveCondition(transitionID, GetLayer(layerID), conditionMethod);
        }

        public void RemoveCondition(string transitionID, Layer layer, Condition conditionMethod)
        {
            RemoveCondition(GetTransition(transitionID, layer), conditionMethod);
        }

        public void RemoveCondition(string transitionID, int layerIndex, Condition conditionMethod)
        {
            RemoveCondition(transitionID, GetLayer(layerIndex), conditionMethod);
        }
    }
}