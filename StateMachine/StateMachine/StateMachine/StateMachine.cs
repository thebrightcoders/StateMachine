﻿using System;
using StateMachine.StateMachineInterfaces;
using StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces;
using StateMachine.StateMachineInterfaces.StateMachineStateControllerInterfaces;

namespace StateMachine
{
    public delegate void StateMachineEvent(StateMachine machine);
    public delegate void StateEvent(StateInfo stateInfo, StateMachine machine, Layer layer);
    public delegate void Condition();

    public class StateMachine :
        StateMachineProcessControllers,
        IStateMachineLayerMethods,
        IStateMachineStateMethods
    {
        //vars
        public string name;
        private Layer[] layers;
        private MachineExecutionType executionType { get; set; }
        private MachineExecutionOrder machineExecutionOrder { get; set; }
        private TimeSpan executionTimeSpan { get; set; }
        private bool isRunning { get; set; }
        private bool isPaused { get; set; }

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

        }

        public StateMachine(params IStateMachineEventMethods[] methods)
        {
        }

        public StateMachine(MachineMethodType methodType, params StateMachineEvent[] methods)
        {

        }

        public StateMachine(MachineMethodType[] methodType, params StateMachineEvent[] methods)
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

        public Layer AddLayer(string iD, params State[] states)
        {
            throw new NotImplementedException();
        }

        public Layer AddLayer(string iD, int index, params State[] states)
        {
            throw new NotImplementedException();
        }

        public Layer AddLayer(string iD, InListLocation LocationToAdd, params State[] states)
        {
            throw new NotImplementedException();
        }

        public bool HasLayer(string iD)
        {
            throw new NotImplementedException();
        }

        public bool HasLayer(Layer layerToCheck)
        {
            throw new NotImplementedException();
        }

        public Layer GetLayer(string iD)
        {
            throw new NotImplementedException();
        }

        public Layer GetLayer(InListLocation layerLocation)
        {
            throw new NotImplementedException();
        }

        public Layer GetFirstLayer()
        {
            throw new NotImplementedException();
        }

        public Layer GetLastLayer()
        {
            throw new NotImplementedException();
        }

        public int GetLayersListCount()
        {
            throw new NotImplementedException();
        }

        public Layer[] GetLayers(Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(Layer layerToMove, int targetIndex)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(Layer layerToMove, InListLocation layerTargetLocation)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(string iD, int targetIndex)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(string iD, InListLocation layerTargetLocation)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(int sourceIndex, int targetIndex)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(int sourceIndex, InListLocation layerTargetLocation)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(InListLocation layerTargetLocation, int targetIndex)
        {
            throw new NotImplementedException();
        }

        public void MoveLayer(InListLocation layerSourceLocation, InListLocation layerTargetLocation)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToFirst(Layer layerToMove)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToFirst(string iD)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToFirst(int sourceIndex)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToLast(Layer layerToMove)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToLast(string iD)
        {
            throw new NotImplementedException();
        }

        public void MoveLayerToLast(int sourceIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveLayer(Layer layerToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveLayer(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveLayer(InListLocation layerTargetLocation)
        {
            throw new NotImplementedException();
        }

        public void RemoveLayers(Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, Layer layerToAddState, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, Layer layerToAddState, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, string layerID, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, string layerID, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, int layerIndex, StateTransitionType stateTransitionType)
        {
            throw new NotImplementedException();
        }

        public State AddState(string iD, int layerIndex, bool isLoop = false, StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            throw new NotImplementedException();
        }

        public bool HasState(string iD)
        {
            throw new NotImplementedException();
        }

        public bool HasState(string iD, string layerID)
        {
            throw new NotImplementedException();
        }

        public bool HasState(string iD, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public bool HasState(string iD, InListLocation layerLocation = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public bool HasState(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public State GetState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public State GetState(string iD, Layer layerToGetState)
        {
            throw new NotImplementedException();
        }

        public State GetState(string iD, string layerIDToGetState)
        {
            throw new NotImplementedException();
        }

        public State GetState(string iD, int layerIndexToGetState)
        {
            throw new NotImplementedException();
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(State state)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(string iD, string layerID)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(string iD, int layerIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveState(string iD, Layer layerToRemoveState)
        {
            throw new NotImplementedException();
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod)
        {
            throw new NotImplementedException();
        }

        public void RemoveStates(Predicate<State> stateCheckerMethod, Predicate<State> layerCheckerMethod)
        {
            throw new NotImplementedException();
        }
    }
}