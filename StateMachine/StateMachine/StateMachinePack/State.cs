namespace StateMachinePack
{
    public class State
    {
        internal Layer layer { get; set; }
        internal StateInfo stateInfo { get; set; }

        public State(string iD, Layer layerToAdd, bool isLoop = false)
        {
            Validator.ValidateID(ref iD);
            this.stateInfo = new StateInfo(iD, isLoop);
            this.layer = layerToAdd;
        }

        public void SetID(string iD)
        {
            stateInfo.iD = iD;
        }

        public string GetID()
        {
            return stateInfo.iD;
        }

        public Layer GetLayer()
        {
            return layer;
        }
    }
}