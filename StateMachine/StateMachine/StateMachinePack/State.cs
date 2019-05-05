namespace StateMachinePack
{
    public class State :IState
    {
        internal Layer parentLayer { get; set; }
        internal StateInfo stateInfo { get; set; }

        internal State(string iD, Layer parentLayerToAdd, bool isLoop = false)
        {
            Validator.ValidateID(ref iD);
            this.stateInfo = new StateInfo(iD, isLoop);
            this.parentLayer = parentLayerToAdd;
        }

        public void SetID(string iD)
        {
            stateInfo.iD = iD;
        }

        public string GetID()
        {
            return stateInfo.iD;
        }

        public Layer GetParentLayer()
        {
            return parentLayer;
        }

        public void OnStateEnter(StateInfo stateInfo, StateMachine machine, Layer layer)
        {
            throw new System.NotImplementedException();
        }

        public void OnStateProcess(StateInfo stateInfo, StateMachine machine, Layer layer)
        {
            throw new System.NotImplementedException();
        }

        public void OnStateExit(StateInfo stateInfo, StateMachine machine, Layer layer)
        {
            throw new System.NotImplementedException();
        }

        protected void InvokeOnStateEnter()
        {
            throw new System.NotImplementedException();
        }

        protected void InvokeOnStateProcess()
        {
            throw new System.NotImplementedException();
        }

        protected void InvokeOnStateExit()
        {
            throw new System.NotImplementedException();
        }
    }
}