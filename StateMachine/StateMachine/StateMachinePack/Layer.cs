using StateMachinePack.LayerInterfaces;
using System.Collections.Generic;

namespace StateMachinePack
{
    public class Layer : ILayerStateMethods
    {
        private const string STARTSTATE = "StartState";
        internal string iD { get; set; }
        internal List<State> states { get; set; }
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
            if (states == null)
                this.states = new List<State>();
            else
                this.states = new List<State>(states);

            this.startUpState = states.Length <= 0 ? new State(STARTSTATE) : states[0];
        }

        public Layer()
        {
            states = new List<State>(); ;
            this.iD = "DEFAULT";
            State startUpState = new State(STARTSTATE);
            this.startUpState = startUpState;
            this.states.Add(startUpState);
        }

        public State AddState(string iD, bool isLoop, StateTransitionType stateTransitionType)
        {
            throw new System.NotImplementedException();
        }

        public State GetState(string iD)
        {
            throw new System.NotImplementedException();
        }

        public bool HasState(string iD)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveState(State state)
        {
            throw new System.NotImplementedException();
        }
    }
}