using StateMachinePack.LayerInterfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            if (states.ContainsKey(TrimediD))
                throw new Exception(string.Format("The Layer With ID = {0} Already Exists.", TrimediD));
            State state = new State(TrimediD, isLoop);
            this.states.Add(state.GetStateInfo().iD, state);
            //TODO ::: Checking the StateTransitionType is not implemented!
            return state;
        }

        public State GetState(string iD)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");

            State tempState;
            this.states.TryGetValue(TrimediD, out tempState);

            return tempState;
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