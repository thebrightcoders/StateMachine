using System;
using System.Text.RegularExpressions;

namespace StateMachinePack
{
    public class Transition
    {
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

        internal Layer layer;

        internal State sourceState;
        internal State targetState;

        internal Transition(string iD, State sourceState, State targetState, Layer layer, params Condition[] conditionMethods)
        {
            Validator.ValidateID(ref iD);
            this.iD = iD;
            this.sourceState = sourceState;
            this.targetState = targetState;
            this.layer = layer;
        }

        internal Condition AddCondition(Condition conditionMethod)
        {
            AreConditionsMet += conditionMethod;
            return conditionMethod;
        }

        public string iD
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

        internal void RemoveCondition(Condition conditionMethod)
        {
            AreConditionsMet -= conditionMethod;
        }
    }
}