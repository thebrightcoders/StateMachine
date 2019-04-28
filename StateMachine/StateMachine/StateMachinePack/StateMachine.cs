using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using StateMachinePack.StateMachineInterfaces;
using StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces;
using StateMachinePack.StateMachineInterfaces.StateMachineStateControllerInterfaces;

namespace StateMachinePack
{
    public delegate void StateMachineEvent(StateMachine machine);
    public delegate void StateEvent(StateInfo stateInfo, StateMachine machine, Layer layer);
    public delegate void Condition();

    public partial class StateMachine :
        StateMachineProcessControllers,
        IStateMachineLayerMethods,
        IStateMachineStateMethods
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
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            if (layers.Find(layerTofind => layerTofind.iD == TrimediD) != null)
                throw new Exception(string.Format("The Layer With ID = {0} Already Exists.", TrimediD));

            Layer layer = new Layer(TrimediD, states);
            this.lastLayerAdded = layer;
            layers.Add(layer);
            return layer;
        }

        public Layer AddLayer(string iD, int index, params State[] states)
        {

            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            if (layers.Find(layerTofind => layerTofind.iD == TrimediD) != null)
                throw new Exception(string.Format("The Layer With ID = {0} Already Exists.", TrimediD));
            if (!Validator.IsValidIndexInLayersList(index, layers))
            {
                Layer layer = new Layer(TrimediD, states);
                //                if (states!=null)
                //                {
                //                    foreach (State state in states)
                //                    {
                //                        if (state.GetLayer() == null)
                //                        {
                //                            layer.A(state);
                //                        }
                //                    }
                //                }


                layers.Add(layer);
                this.lastLayerAdded = layer;
                return layer;
            }
            else
            {
                Layer layer = new Layer(TrimediD, states);
                //                layer.AddState();
                layers.Insert(index, layer);
                this.lastLayerAdded = layer;
                return layer;
            }



        }

        public Layer AddLayer(string iD, InListLocation LocationToAdd, params State[] states) //DONE
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            if (layers.Find(layerTofind => layerTofind.iD == TrimediD) != null)
                throw new Exception(string.Format("The Layer With ID = {0} Already Exists.", TrimediD));
            Layer layer = new Layer(TrimediD, states);

            if (LocationToAdd == InListLocation.First)
                layers.Insert(0, layer);
            else if (LocationToAdd == InListLocation.Last)
                layers.Add(layer);
            this.lastLayerAdded = layer;
            return layer;
        }


        public bool HasLayerById(string iD)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            return layers.Find(layerTofind => layerTofind.iD == TrimediD) != null;
        }

        public bool HasLayerByLayer(Layer layerToCheck)
        {
            if (layerToCheck == null)
                throw new Exception("The layerTocheck is null");
            return layers.Find(layerTofind => layerTofind == layerToCheck) != null;
        }

        public Layer GetLayer(string iD)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            Layer layer = layers.Find(layerTofind => layerTofind.iD == TrimediD);
            if (layer != null)
            {
                return layer;
            }

            throw new Exception(string.Format("The layer is not found with this {0} iD", iD));
        }

        public Layer GetLayer(InListLocation layerLocation)
        {
            return GetLayer(layerLocation == InListLocation.First ? 0 : layers.Count - 1);
        }

        public Layer GetLayer(int index)
        {
            if (Validator.IsValidIndexInLayersList(index, layers))
            {
                return layers[index];
            }

            throw new Exception(string.Format("The index {0} is  OUTOFRANGE!", index));
        }

        public Layer GetFirstLayer()
        {
            return layers[0];
        } //DONE

        public Layer GetLastLayer()
        {
            return layers[layers.Count - 1];
        } //DONE

        public int GetLayersListCount()
        {
            return layers == null ? 0 : layers.Count;
        } //DONE

        Layer[] IStateMachineLayerGetters.GetLayers(Predicate<Layer> layerCheckerMethod)
        {
            List<Layer> matchedLayersList = new List<Layer>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(layers[i]))
                {
                    matchedLayersList.Add(layers[i]);
                }
            }

            return matchedLayersList.ToArray();
        } //DONE

        public void MoveLayer(Layer layerToMove, int targetIndex)
        {
            if (layerToMove == null)
                throw new Exception("The layer to move is null!");
            if (!Validator.IsValidIndexInLayersList(targetIndex, layers))
                throw new Exception(string.Format("The targetIndex {0} is OutOfRange", targetIndex));

            int sourceIndex = layers.FindIndex(layerTofind => layerTofind == layerToMove);
            if (sourceIndex < 0)
                throw new Exception("Layer is not Found! 404 ;)");
            if (targetIndex == sourceIndex)
                return;
            layers.Insert(targetIndex, layerToMove);
            layers.RemoveAt(sourceIndex);
        }

        public void MoveLayer(Layer layerToMove, InListLocation layerTargetLocation)
        {
            MoveLayer(layerToMove, layerTargetLocation == InListLocation.First ? 0 : layers.Count - 1);

        }

        public void MoveLayer(string iD, int targetIndex)
        {
            MoveLayer(GetLayer(iD), targetIndex);
        }

        public void MoveLayer(string iD, InListLocation layerTargetLocation)
        {
            MoveLayer(GetLayer(iD), layerTargetLocation == InListLocation.First ? 0 : layers.Count - 1);
        }

        public void MoveLayer(int sourceIndex, int targetIndex)
        {
            MoveLayer(GetLayer(sourceIndex), targetIndex);
        }

        public void MoveLayer(int sourceIndex, InListLocation layerTargetLocation)
        {
            MoveLayer(GetLayer(sourceIndex), layerTargetLocation == InListLocation.First ? 0 : layers.Count - 1);
        }

        public void MoveLayer(InListLocation layerSourceLocation, int targetIndex)
        {

            MoveLayer(layerSourceLocation == InListLocation.First ? 0 : layers.Count - 1, targetIndex);
        }


        public void MoveLayer(InListLocation layerSourceLocation, InListLocation layerTargetLocation)
        {
            MoveLayer(
                layerSourceLocation == InListLocation.First ? 0 : layers.Count - 1,
                layerTargetLocation == InListLocation.First ? 0 : layers.Count - 1
            );
        }

        public void MoveLayerToFirst(Layer layerToMove)
        {
            MoveLayer(layerToMove, 0);
        }

        public void MoveLayerToFirst(string iD)
        {
            MoveLayer(iD, 0);
        }

        public void MoveLayerToFirst(int sourceIndex)
        {
            MoveLayer(0, 0);
        }

        public void MoveLayerToLast(Layer layerToMove)
        {
            MoveLayer(layerToMove, InListLocation.Last);
        }

        public void MoveLayerToLast(string iD)
        {
            MoveLayer(iD, InListLocation.Last);
        }

        public void MoveLayerToLast(int sourceIndex)
        {
            MoveLayer(sourceIndex, InListLocation.Last);
        }

        public void RemoveLayer(Layer layerToRemove)
        {
            if (layerToRemove == null)
                throw new Exception("LayerToRemove is null");
            if (layers.Find(layer => layer == layerToRemove) == null)
                throw new Exception("LayerToRemove is not found! 404 ;)");
            layers.Remove(layerToRemove);
        }

        public void RemoveLayer(int index)
        {
            RemoveLayer(GetLayer(index));
        }

        public void RemoveLayer(InListLocation layerTargetLocation)
        {
            RemoveLayer(layerTargetLocation == InListLocation.First ? 0 : layers.Count - 1);
        }

        public void RemoveLayers(Predicate<Layer> layerCheckerMethod)
        {
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(layers[i]))
                {
                    layers.Remove(layers[i]);
                }
            }
        }

        public State AddState(string iD, StateTransitionType stateTransitionType)
        {
            return AddState(iD, false, stateTransitionType);
        }

        public State AddState(string iD, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            if (this.lastLayerAdded == null)
                throw new Exception("The last added Layer is removed!");
            return this.lastLayerAdded.AddState(iD, isLoop, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, StateTransitionType stateTransitionType)
        {
            return AddState(iD, layerToAddState, false, stateTransitionType);
        }

        public State AddState(string iD, Layer layerToAddState, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            if (layerToAddState == null)
                throw new Exception("The layerToAddState is 'null'");
            return layerToAddState.AddState(iD, isLoop, stateTransitionType);
        }

        public State AddState(string iD, string layerID, StateTransitionType stateTransitionType)
        {
            return AddState(iD, GetLayer(iD), stateTransitionType);
        }

        public State AddState(string iD, string layerID, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddState(iD, GetLayer(iD), isLoop, stateTransitionType);
        }

        public State AddState(string iD, int layerIndex, StateTransitionType stateTransitionType)
        {
            return AddState(iD, GetLayer(layerIndex), stateTransitionType);
        }

        public State AddState(string iD, int layerIndex, bool isLoop = false,
            StateTransitionType stateTransitionType = StateTransitionType.Default)
        {
            return AddState(iD, GetLayer(layerIndex), isLoop, stateTransitionType);
        }

        public bool HasState(string iD)
        {
            if (this.lastLayerAdded == null)
                throw new Exception("The last added Layer is removed!");
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");

            return this.lastLayerAdded.states.ContainsKey(TrimediD);
        }

        public bool HasState(string iD, string layerID)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");

            return GetLayer(layerID).states.ContainsKey(TrimediD);
        }

        public bool HasState(string iD, int layerIndex)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");

            return GetLayer(layerIndex).states.ContainsKey(TrimediD);
        }

        public bool HasState(string iD, InListLocation layerLocation = InListLocation.First)
        {
            return HasState(iD, layerLocation == InListLocation.First ? 0 : InListLocation.Last);
        }

        public bool HasState(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            List<Layer> layers = new List<Layer>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(this.layers[i]))
                {
                    layers.Add(this.layers[i]);
                }
            }

            if (layers.Count < 0)
                return false;

            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    if (stateCheckerMethod(tempStates[i]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public State GetState(string iD, InListLocation stateSelection = InListLocation.First)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            List<State> gotStates = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                gotStates.AddRange(
                    layers[i].states.Values.ToList()
                        .FindAll(state => state.GetStateInfo().iD == TrimediD));

            }

            return stateSelection == InListLocation.First ? gotStates[0] : gotStates[gotStates.Count - 1];
        }

        public State GetState(string iD, Layer layerToGetState)
        {
            if (Validator.IsNullString(iD))
                throw new Exception("The iD is 'NULL'!!");
            string TrimediD = iD.Trim();
            if (Validator.IsStringEmpty(TrimediD))
                throw new Exception("The ID can't be empty!");
            if (!Validator.IsValidString(TrimediD))
                throw new Exception("The Id is not valid!");
            State state;
            layerToGetState.states.TryGetValue(TrimediD, out state);
            return state;
        }

        public State GetState(string iD, string layerIDToGetState)
        {
            return GetState(iD, GetLayer(layerIDToGetState));
        }

        public State GetState(string iD, int layerIndexToGetState)
        {
            return GetState(iD, GetLayer(layerIndexToGetState));
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod)
        {
            if (stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is 'null'");
            List<State> gotStates = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                gotStates.AddRange(
                    layers[i].states.Values.ToList()
                        .FindAll(stateCheckerMethod));
            }

            return gotStates.ToArray();
        }

        public State[] GetStates(Predicate<State> stateCheckerMethod, Predicate<Layer> layerCheckerMethod)
        {
            if(stateCheckerMethod == null)
                throw new Exception("The stateCheckerMethod is null");
            if (layerCheckerMethod == null)
                throw new Exception("The layerCheckerMethod is null");
            List<Layer> layers = new List<Layer>();
            List<State> states = new List<State>();
            for (int i = 0; i < layers.Count; i++)
            {
                if (layerCheckerMethod(this.layers[i]))
                {
                    layers.Add(this.layers[i]);
                }
            }

            if (layers.Count < 0)
                return null;
            for (int i = 0; i < layers.Count; i++)
            {
                List<State> tempStates = layers[i].states.Values.ToList();
                for (int j = 0; j < tempStates.Count; j++)
                {
                    if (stateCheckerMethod(tempStates[i]))
                    {
                        states.Add(tempStates[i]);
                    }
                }
            }
            return states.ToArray();
        }


        public void RemoveState(State state)
        {
            
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
