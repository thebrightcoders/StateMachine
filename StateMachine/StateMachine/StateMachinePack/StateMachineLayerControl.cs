using StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces;
using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineLayerMethods
    {
        public Layer AddLayer(string iD)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD);
            layers.Add(layer);
            return layer;
        }

        public Layer AddLayer(string iD, int index)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD);
            if (Validator.IsValidIndexInLayersList(index, layers))
                layers.Insert(index, layer);
            else
                layers.Add(layer);
            return layer;
        }

        public Layer AddLayer(string iD, InListLocation LocationToAdd)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD);
            if (LocationToAdd == InListLocation.First)
                layers.Insert(0, layer);
            else if (LocationToAdd == InListLocation.Last)
                layers.Add(layer);
            return layer;
        }

        private Layer CheckExistanceAndCreateLayer(string iD)
        {
            Validator.ValidateLayerExistance(iD, layers);
            Layer layer = new Layer(iD);
            this.lastLayerAdded = layer;
            return layer;
        }

        public bool HasLayer(string iD)
        {
            return HasLayer(GetLayer(iD));
        }

        public bool HasLayer(Layer layerToCheck)
        {
            if (layerToCheck == null)
                throw new ArgumentNullException();
            return layers.Contains(layerToCheck);
        }

        public Layer GetLayer(string iD)
        {
            Validator.ValidateID(ref iD);
            return layers.Find(layerTofind => layerTofind.iD == iD);
        }

        public Layer GetLayer(InListLocation layerLocation)
        {
            return GetLayer(GetLayerListLocationIndex(layerLocation));
        }

        public Layer GetLayer(int index)
        {
            return layers[index];
        }

        public Layer GetFirstLayer()
        {
            return GetLayer(InListLocation.First);
        }

        public Layer GetLastLayer()
        {
            return GetLayer(InListLocation.Last);
        }

        public int GetLayersListCount()
        {
            return layers.Count;
        }

        public Layer[] GetLayers(Predicate<Layer> layerCheckerMethod)
        {
            return layers.FindAll(layerCheckerMethod).ToArray();
        }

        public void MoveLayer(Layer layerToMove, int targetIndex)
        {
            layers.Insert(targetIndex, layerToMove);
            layers.Remove(layerToMove);
        }

        public void MoveLayer(Layer layerToMove, InListLocation layerTargetLocation)
        {
            MoveLayer(layerToMove, GetLayerListLocationIndex(layerTargetLocation));
        }

        public void MoveLayer(string iD, int targetIndex)
        {
            MoveLayer(GetLayer(iD), targetIndex);
        }

        public void MoveLayer(string iD, InListLocation layerTargetLocation)
        {
            MoveLayer(GetLayer(iD), layerTargetLocation);
        }

        public void MoveLayer(int sourceIndex, int targetIndex)
        {
            MoveLayer(GetLayer(sourceIndex), targetIndex);
        }

        public void MoveLayer(int sourceIndex, InListLocation layerTargetLocation)
        {
            MoveLayer(GetLayer(sourceIndex), layerTargetLocation);
        }

        public void MoveLayer(InListLocation layerSourceLocation, int targetIndex)
        {
            MoveLayer(GetLayerListLocationIndex(layerSourceLocation), targetIndex);
        }

        public void MoveLayer(InListLocation layerSourceLocation, InListLocation layerTargetLocation)
        {
            MoveLayer(GetLayerListLocationIndex(layerSourceLocation), layerTargetLocation);
        }

        private int GetLayerListLocationIndex(InListLocation location)
        {
            return GetListLocationIndex(location, layers);
        }

        private int GetListLocationIndex<T>(InListLocation location, List<T> list)
        {
            return location == InListLocation.First ? 0 : Math.Max(list.Count - 1, 0);
        }

        public void MoveLayerToFirst(Layer layerToMove)
        {
            MoveLayer(layerToMove, InListLocation.First);
        }

        public void MoveLayerToFirst(string iD)
        {
            MoveLayer(iD, InListLocation.First);
        }

        public void MoveLayerToFirst(int sourceIndex)
        {
            MoveLayer(sourceIndex, InListLocation.First);
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
            layers.Remove(GetLayer(layerToRemove.iD));
        }

        public void RemoveLayer(int index)
        {
            RemoveLayer(GetLayer(index));
        }

        public void RemoveLayer(InListLocation layerTargetLocation)
        {
            RemoveLayer(GetLayerListLocationIndex(layerTargetLocation));
        }

        public void RemoveLayers(Predicate<Layer> layerCheckerMethod)
        {
            layers.RemoveAll(layerCheckerMethod);
        }
    }
}