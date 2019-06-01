using StateMachinePack.LayerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{

    public class Layer : ILayerStateMethods, ILayerSubStateMachineMethods, ILayerTransitionMethods, ILayerConditionMethods
    {
        public static readonly string DEFAULTID = "DEFAULT";
        public static readonly string DEFAULTSTARTSTATEID = "STARTSTATE";

        private string ID;

        public string iD
        {
            get { return ID; }
            set
            {
                Validator.ValidateID(ref value);
                ID = value;
            }
        }

        internal Dictionary<string, State> states { get; set; }
        internal Dictionary<string, SubStateMachine> subMachines { get; set; }
        private StateMachine machine { get; set; }
        internal Dictionary<string, Transition> transitions { get; set; }

        public bool IsStartupState(State state)
        {
            return state == startupState;
        }

        public bool IsStartupState(string stateID)
        {
            return stateID == startupState.iD;
        }

        internal State previousState { get; set; }
        internal State currentState { get; set; }
        internal State startupState { get; set; }
        internal State anyState { get; set; }
        internal State exitState { get; set; }

        internal Layer(string iD)
        {
            this.iD = iD;
            this.states = new Dictionary<string, State>();
            this.subMachines = new Dictionary<string, SubStateMachine>();
            this.transitions = new Dictionary<string, Transition>();
            this.startupState = AddState(DEFAULTSTARTSTATEID, false, StateTransitionType.Startup);
        }

        internal Layer() : this(DEFAULTID)
        {

        }

        public State AddState(string iD, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            Validator.ValidateStateExistance(iD, states);
            State state = new State(iD, this, isLoop);
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
            this.states.Remove(state.stateInfo.iD);
        }

        public SubStateMachine AddSubStateMachine(string iD, string machineName, bool isLoop = false,
                                                  StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            SubStateMachine subStateMachine = new SubStateMachine(iD, machineName, this, isLoop);
            this.states.Add(iD, subStateMachine);
            this.subMachines.Add(machineName, subStateMachine);
            return subStateMachine;
        }

        public SubStateMachine GetSubStateMachine(SubStateMachineSelection nameOrID, string text)
        {
            if (HasSubStateMachine(nameOrID, text))
                return nameOrID == SubStateMachineSelection.Name ? subMachines[text] : states[text] as SubStateMachine;
            return null;
        }

        public bool HasSubStateMachine(SubStateMachineSelection nameOrID, string text)
        {
            Validator.ValidateID(ref text);
            return nameOrID == SubStateMachineSelection.Name ? subMachines.ContainsKey(text) : states.ContainsKey(text);
        }

        public void RemoveSubStateMachine(SubStateMachine subMachine)
        {
            RemoveState(subMachine);
            subMachines.Remove(subMachine.GetName());
        }

        public Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditionMethods)
        {
            Transition transition = new Transition(iD, sourceState, targetState, this, conditionMethods);
            this.transitions.Add(iD, transition);
            return transition;
        }

        public Transition GetTransition(string iD)
        {
            Validator.ValidateID(ref iD);
            return transitions.TryGetValue(iD, out Transition transition) == true ? transition : null;
        }

        public bool HasTransition(string iD)
        {
            if (iD == null)
                throw new NullReferenceException();

            return transitions.ContainsKey(iD);
        }

        public void RemoveTransition(Transition transition)
        {
            transitions.Remove(transition.iD);
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