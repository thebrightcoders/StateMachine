namespace StateMachinePack
{
    public class State
    {
        private Layer layer;

        public Layer GetLayer()
        {
            return this.layer;
        }
        public State(string iD, bool isLoop = false)
        {

        }
    }
}