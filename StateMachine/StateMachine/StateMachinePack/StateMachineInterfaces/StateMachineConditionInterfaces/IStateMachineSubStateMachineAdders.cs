using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachinePack;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineConditionControllerInterfaces
{
    interface IStateMachineConditionAdders
    {
        Condition AddCondition(Transition transition, Condition conditionMethod);

        Condition AddCondition(string transitionID, Condition conditionMethod);

        Condition AddCondition(string transitionID, string layerID, Condition conditionMethod);

        Condition AddCondition(string transitionID, Layer layer, Condition conditionMethod);

        Condition AddCondition(string transitionID, int layerIndex, Condition conditionMethod);
    }
}
