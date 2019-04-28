using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionMethods : 
        IStateMachineTransitionAdders, IStateMachineTransitionGetters,
        IStateMachineTransitionCheckers, IStateMachineTransitionRemovers
    {
    }
}
