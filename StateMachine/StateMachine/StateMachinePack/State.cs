namespace StateMachinePack
{
    public class State
    {
        internal Layer layer { get; set; }
        internal StateInfo stateInfo { get; set; }

        public State(string iD, bool isLoop = false)
        {
            Validator.ValidateID(ref iD);
            stateInfo = new StateInfo(iD, isLoop);
        }

        public string GetID()
        {
            return stateInfo.iD;
        }
    }
}