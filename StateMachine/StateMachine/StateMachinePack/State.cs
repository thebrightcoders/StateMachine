﻿namespace StateMachinePack
{
    public class State
    {
        internal Layer layer { get; set; }
        internal StateInfo stateInfo { get; set; }

        public State(string iD, bool isLoop = false)
        {
            
        }
    }
}