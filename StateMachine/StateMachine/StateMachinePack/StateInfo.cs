namespace StateMachinePack
{
    public class StateInfo
    {
        internal StateInfo(string iD, bool isLoop)
        {
            this.iD = iD;
            this.isLoop = isLoop;
        }

        internal string iD { get; set; }
        internal bool isLoop { get; set; }

    }
}