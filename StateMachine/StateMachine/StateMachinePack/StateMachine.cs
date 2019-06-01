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
        private string Name;
        public string name
        {
            get { return Name; }
            set
            {
                Validator.ValidateID(ref value);
                Name = value;
            }
        }
        private List<Layer> layers = new List<Layer>();
        private MachineExecutionType executionType { get; set; }
        private MachineExecutionOrder machineExecutionOrder { get; set; }
        private TimeSpan executionTimeSpan { get; set; }
        private bool isRunning { get; set; }
        private bool isPaused { get; set; }
        private Layer lastLayerAdded;

        protected event StateMachineEvent OnMachineStart;
        protected event StateMachineEvent OnMachineProcess;
        protected event StateMachineEvent OnMachineStop;

        protected void InvokeOnMachineStart()
        {
            throw new NotImplementedException();
        }

        protected void InvokeOnMachineProcess()
        {
            throw new NotImplementedException();
        }

        protected void InvokeOnMachineStop()
        {
            throw new NotImplementedException();
        }


        public StateMachine(string name = "State Machine")
        {
            this.name = name;
            AddLayer(Layer.DEFAULTID);
        }

        //Methods Below Are Considered Functionality Methods. Not Creation Methods
        public StateMachine(params IStateMachineEventMethods[] methods) : this()
        {

        }

        public StateMachine(MachineMethodType methodType, params StateMachineEvent[] methods) : this()
        {

        }

        public StateMachine(MachineMethodType[] methodType, params StateMachineEvent[] methods) : this()
        {

        }

        public StateMachine(string name, params IStateMachineEventMethods[] methods) : this(name)
        {

        }

        public StateMachine(string name, MachineMethodType methodType, params StateMachineEvent[] methods) : this(name)
        {

        }

        public StateMachine(string name, MachineMethodType[] methodType, params StateMachineEvent[] methods) : this(name)
        {

        }

        public void AddMachineEventMethod(params IStateMachineEventMethods[] methods)
        {

        }

        public void AddMachineEventMethod(MachineMethodType methodType, params StateMachineEvent[] method)
        {

        }

        public void AddMachineEventMethod(MachineMethodType[] methodType, params StateMachineEvent[] method)
        {

        }

        public void RemoveMachineEventMethod(params IStateMachineEventMethods[] methods)
        {

        }

        public void RemoveMachineEventMethod(MachineMethodType methodType, params StateMachineEvent[] method)
        {

        }

        public void RemoveMachineEventMethod(MachineMethodType[] methodType, params StateMachineEvent[] method)
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
