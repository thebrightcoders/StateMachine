using StateMachinePack.LayerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public class Layer : ILayerStateMethods
    {
        private const string STARTSTATE = "StartState";
        internal string iD { get; set; }
        internal Dictionary<string, State> states { get; set; }
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
                this.states = new Dictionary<string, State>();
            else
            {
                this.states = new Dictionary<string, State>();
                for (int i = 0; i < states.Length; i++)
                {
                    this.states.Add(states[i].GetStateInfo().iD, states[i]);
                }
            }

            if (this.states.Count <= 0)
            {
                State state = new State(STARTSTATE);
                this.states.Add(state.GetStateInfo().iD, state);
                this.startUpState = state;
            }
            else
            {
                this.startUpState = states[0];
            }
        }

        public Layer()
        {
            states = new Dictionary<string, State>();
            this.iD = "DEFAULT";
            State startUpState = new State(STARTSTATE);
            this.startUpState = startUpState;
            this.states.Add(startUpState.GetStateInfo().iD, startUpState);
        }

        public State AddState(string iD, bool isLoop, StateTransitionType stateTransitionType)
        {
            Validator.ValidateID(ref iD);
            if (states.ContainsKey(iD))
                throw new Exception(string.Format("The State With ID = {0} Already Exists.", iD));
            State state = new State(iD, isLoop);
            this.states.Add(state.GetStateInfo().iD, state);
            //TODO ::: Checking the StateTransitionType is not implemented!
            return state;
        }

        public State GetState(string iD)
        {
            Validator.ValidateID(ref iD);

            State tempState;
            this.states.TryGetValue(iD, out tempState);

            return tempState;
        }

        public bool HasState(string iD)
        {
            Validator.ValidateID(ref iD);

            return this.states.ContainsKey(iD);
        }

        public void RemoveState(State state)
        {
            if (state == null)
                throw new Exception("The State is 'NULL'!!");
            if (!this.states.ContainsValue(state))
                throw new Exception("The is no such state in this layer!");
            this.states.Remove(state.GetStateInfo().iD);
        }
    }
}