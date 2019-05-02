using System;

namespace StateMachinePack
{
    public class SubStateMachine : State
    {
        public SubStateMachine(string iD, string subMachineName, Layer layerToAdd, bool isLoop = false) : base(iD, layerToAdd, isLoop)
        {
            Validator.ValidateID(ref subMachineName);
        }
    }
}