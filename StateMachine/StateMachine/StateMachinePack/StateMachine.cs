using System;
using System.Collections.Generic;
using StateMachinePack.StateMachineInterfaces;

namespace StateMachinePack
{
    public delegate void StateMachineEvent(StateMachine machine);
    public delegate void StateEvent(StateInfo stateInfo, StateMachine machine, Layer layer);
    public delegate void Condition();

    public partial class StateMachine : StateMachineProcessControllers
    {
        //vars
        public string name;
        private List<Layer> layers = new List<Layer>();
        private MachineExecutionType executionType { get; set; }
        private MachineExecutionOrder machineExecutionOrder { get; set; }
        private TimeSpan executionTimeSpan { get; set; }
        private bool isRunning { get; set; }
        private bool isPaused { get; set; }
        private Layer lastLayerAdded;

        //function pointers
        protected event StateMachineEvent OnMachineStart;
        protected event StateMachineEvent OnMachineUpdate;
        protected event StateMachineEvent OnMachineStop;

        protected void InvokeOnMachineStart()
        {
        }

        protected void InvokeOnMachineUpdate()
        {
        }

        protected void InvokeOnMachineStop()
        {
        }

        //Constructors
        public StateMachine()
        {
            layers.Add(new Layer());
        }

        public StateMachine(params IStateMachineEventMethods[] methods) : this()
        {

        }

        public StateMachine(MachineMethodType methodType, params StateMachineEvent[] methods) : this()
        {

        }

        public StateMachine(MachineMethodType[] methodType, params StateMachineEvent[] methods) : this()
        {

        }

        //functions
        public void AddMachineEventMethod(IStateMachineEventMethods methods)
        {

        }

        public void AddMachineEventMethod(params IStateMachineEventMethods[] methods)
        {

        }

        public void AddMachineEventMethod(MachineMethodType methodType, StateMachineEvent method)
        {

        }

        public void AddMachineEventMethod(MachineMethodType methodType, params StateMachineEvent[] method)
        {

        }

        public void AddMachineEventMethod(MachineMethodType[] methodType, params StateMachineEvent[] method)
        {

        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Proceed()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Continue()
        {
            throw new NotImplementedException();
        }

        public void Wait(TimeSpan waitTime)
        {
            throw new NotImplementedException();
        }
    }
}
