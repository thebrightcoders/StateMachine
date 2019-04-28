using StateMachinePack.LayerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public class Layer : ILayerStateMethods
    {
        private const string DEFAULTSTARTSTATEID = "StartState";
        internal string iD { get; set; }
        internal Dictionary<string, State> states { get; set; }
        private StateMachine machine { get; set; }
        internal Transition[] transitions { get; set; }
        internal State previousState { get; set; }
        internal State currentState { get; set; }
        internal State startUpState { get; set; }
        internal State anyState { get; set; }
        internal State exitState { get; set; }

        //Constructor
        public Layer(string iD, params State[] states)
        {
            Validator.ValidateID(ref iD);
            this.iD = iD;
            this.states = new Dictionary<string, State>();
            if (states != null)
            {
                for (int i = 0; i < states.Length; i++)
                {
                    this.states.Add(states[i].stateInfo.iD, states[i]);
                }
            }

            if (this.states.Count <= 0)
            {
                this.startUpState = new State(DEFAULTSTARTSTATEID);
                this.states.Add(DEFAULTSTARTSTATEID, this.startUpState);
            }
            else
            {
                this.startUpState = states[0];
            }
        }

        public Layer() : this("DEFAULT")
        {
            
        }

        public State AddState(string iD, bool isLoop, StateTransitionType stateTransitionType)
        {
            Validator.ValidateID(ref iD);
            if (states.ContainsKey(iD))
                throw new Exception(string.Format("The State With ID = {0} Already Exists.", iD));
            State state = new State(iD, isLoop);
            this.states.Add(iD, state);
            //TODO ::: Checking the StateTransitionType is not implemented!
            return state;
        }

        public State GetState(string iD)
        {
            Validator.ValidateID(ref iD);

            return this.states.TryGetValue(iD, out State tempState) ? tempState : null;
        }

        public bool HasState(string iD)
        {
            Validator.ValidateID(ref iD);

            return this.states.ContainsKey(iD);
        }

        public void RemoveState(State state)
        {
            if (!this.states.ContainsValue(state))
                throw new Exception("The is no such state in this layer!");
            this.states.Remove(state.stateInfo.iD);
        }
    }
}