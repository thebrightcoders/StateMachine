namespace StateMachinePack
{
    public class Transition
    {
        internal string iD;
        internal State sourceState;
        internal State targetState;

        internal Transition(string iD, State sourceState, State targetState)
        {
            this.iD = iD;
            this.sourceState = sourceState;
            this.targetState = targetState;
        }

        public string getID()
        {
            return this.iD;
        }
        public State getSourceState()
        {
            return this.sourceState;
        }
        public State getTargetState()
        {
            return this.targetState;
        }

        protected event Condition AreConditionsMet;

    }
}