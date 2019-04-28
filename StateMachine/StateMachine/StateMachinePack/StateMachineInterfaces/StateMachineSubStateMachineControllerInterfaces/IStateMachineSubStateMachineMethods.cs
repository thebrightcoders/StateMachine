using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.StateMachinePack.StateMachineInterfaces.StateMachineSubStateMachineControllerInterfaces
{
    interface IStateMachineSubStateMachineMethods : 
        IStateMachineSubStateMachineAdders, IStateMachineSubStateMachineGetters,
        IStateMachineSubStateMachineCheckers, IStateMachineSubStateMachineRemovers
    {
    }
}
