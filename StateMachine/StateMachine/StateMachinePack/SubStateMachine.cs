using System;

namespace StateMachinePack
{
    public class SubStateMachine : State
    {
        public StateMachine machine;
        internal SubStateMachine(string iD, string subMachineName, Layer parentLayerToAdd, bool isLoop = false) : base(iD, parentLayerToAdd, isLoop)
        {
            machine = new StateMachine(subMachineName);
        }

        internal string GetName()
        {
            return machine.name;
        }
    }
}