namespace StateMachinePack
{
    public class Layer
    {
        internal string iD { get; set; }
        internal State[] states { get; set; }
        private StateMachine machine { get; set; }
        internal Transition[] transitions { get; set; }
        internal State previousState { get; set; }
        internal State currentState { get; set; }
        internal State startUpState { get; set; }
        internal State anyState { get; set; }
        internal State exitState { get; set; }
        //constructor
        public Layer(string iD, params State[] states)
        {
            this.iD = iD;
            this.states = states;

        }

    }
}