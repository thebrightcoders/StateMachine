namespace StateMachinePack
{
    public class State : IState
    {
        public string iD
        {
            get { return stateInfo.iD; }
            set { stateInfo.iD = value; }

        }
        internal Layer parentLayer { get; set; }
        internal StateInfo stateInfo { get; set; }

        internal State(string iD, Layer parentLayerToAdd, bool isLoop = false)
        {
            this.stateInfo = new StateInfo(iD, isLoop);
            this.parentLayer = parentLayerToAdd;
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