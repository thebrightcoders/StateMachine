namespace StateMachinePack
{
    public class StateInfo
    {
        internal StateInfo(string iD, bool isLoop)
        {
            this.iD = iD;
            this.isLoop = isLoop;
        }

        public string iD
        {
            get { return ID; }
            set
            {
                Validator.ValidateID(ref value);
                ID = value;
            }

        }

        private string ID;
        internal bool isLoop { get; set; }

    }
}