namespace StateMachinePack
{
    public class SubStateMachine : State
    {
        public SubStateMachine(string iD, string subMachineName, bool isLoop = false) : base(iD, isLoop)
        {
            Validator.ValidateID(ref subMachineName);
        }

    }
}