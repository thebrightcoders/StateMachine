using System;

namespace StateMachinePack
{
    public class SubStateMachine : State
    {
        public StateMachine machine;
        public SubStateMachine(string iD, string subMachineName, Layer layerToAdd, bool isLoop = false) : base(iD, layerToAdd, isLoop)
        {
            machine = new StateMachine(subMachineName);
        }

        internal string GetName()
        {
            return machine.name;
        }
    }
}