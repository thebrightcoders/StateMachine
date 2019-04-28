namespace StateMachinePack
{
    public class State
    {
        private Layer layer;
        private StateInfo stateInfo;

        public Layer GetLayer()
        {
            return this.layer;
        }

        public StateInfo GetStateInfo()
        {
            return this.stateInfo;
        }
        public State(string iD, bool isLoop = false)
        {

        }
    }
}