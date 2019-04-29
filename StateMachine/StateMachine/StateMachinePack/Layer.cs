using StateMachinePack.LayerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{

    public class Layer : ILayerStateMethods, ILayerSubStateMachineMethods, ILayerTransitionMethods, ILayerConditionMethods
    {
        public static readonly string DEFAULT = "DEFAULT";
        private static readonly string DEFAULTSTARTSTATEID = "StartState";

        internal string iD { get; set; }
        internal Dictionary<string, State> states { get; set; }
        internal Dictionary<string, SubStateMachine> subMachines { get; set; }
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
            this.subMachines = new Dictionary<string, SubStateMachine>();
            if (states != null)
                foreach (State state in states)
                    this.states.Add(state.stateInfo.iD, state);

            this.startUpState = this.states.Count <= 0 ? AddState(DEFAULTSTARTSTATEID) : states[0];
        }

        public Layer() : this(DEFAULT)
        {

        }

        public State AddState(string iD, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            Validator.ValidateStateExistance(iD, states);
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
            //if (!this.states.ContainsValue(state))
            //    throw new Exception("The is no such state in this layer!");
            this.states.Remove(state.stateInfo.iD);
        }

        public SubStateMachine AddSubStateMachine(string iD, string machineName, bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            SubStateMachine subStateMachine = new SubStateMachine(iD, machineName);
            this.states.Add(iD, subStateMachine);
            this.subMachines.Add(machineName, subStateMachine);
            return subStateMachine;
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection nameOrID, string text)
        {
            throw new NotImplementedException();
        }

        public bool HasSubStateMachine(SubStateMachineSelection nameOrID, string text)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubStateMachine(SubStateMachine subMachine)
        {
            throw new NotImplementedException();
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditionMethods)
        {
            throw new NotImplementedException();
        }

        public Transition GetTransition(string iD)
        {
            throw new NotImplementedException();
        }

        public bool HasTransition(string iD)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(Transition transition)
        {
            throw new NotImplementedException();
        }

        public Condition AddCondition(Transition transition, Condition condition)
        {
            throw new NotImplementedException();
        }

        public void RemoveCondition(Transition transition, Condition condition)
        {
            throw new NotImplementedException();
        }
    }
}