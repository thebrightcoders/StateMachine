using StateMachinePack;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineConditionControllerInterfaces
{
    interface IStateMachineConditionRemovers
    {
        void RemoveCondition(Transition transition, Condition conditionMethod);

        void RemoveCondition(string transitionID, string layerID, Condition conditionMethod);

        void RemoveCondition(string transitionID, Layer layer, Condition conditionMethod);

        void RemoveCondition(string transitionID, int layerIndex, Condition conditionMethod);

    }
}
