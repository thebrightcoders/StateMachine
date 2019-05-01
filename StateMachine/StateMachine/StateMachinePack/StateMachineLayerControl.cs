using StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces;
using System;

namespace StateMachinePack
{
    public partial class StateMachine : IStateMachineLayerMethods
    {
        public Layer AddLayer(string iD, params State[] states)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD, states);
            layers.Add(layer);
            return layer;
        }

        public Layer AddLayer(string iD, int index, params State[] states)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD, states);
            if (Validator.IsValidIndexInLayersList(index, layers))
                layers.Insert(index, layer);
            else
                layers.Add(layer);
            return layer;
        }

        public Layer AddLayer(string iD, InListLocation LocationToAdd, params State[] states)
        {
            Layer layer = CheckExistanceAndCreateLayer(iD, states);
            if (LocationToAdd == InListLocation.First)
                layers.Insert(0, layer);
            else if (LocationToAdd == InListLocation.Last)
                layers.Add(layer);
            return layer;
        }

        private Layer CheckExistanceAndCreateLayer(string iD, State[] states)
        {
            Validator.ValidateLayerExistance(iD, layers);
            Layer layer = new Layer(iD, states);
            this.lastLayerAdded = layer;
            return layer;
        }

        public bool HasLayerById(string iD)
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
            return GetLayer(GetListLocationIndex(layerLocation));
        }

        public Layer GetLayer(int index)
        {
            return layers[index];
        }

        public Layer GetFirstLayer()
        {
            return GetLayer(0);
        }

        public Layer GetLastLayer()
        {
            return GetLayer(layers.Count - 1);
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
            //if (!Validator.IsValidIndexInLayersList(targetIndex, layers))
            //    throw new Exception(string.Format("The targetIndex {0} is OUT OF RANGE.", targetIndex));

            layers.Insert(targetIndex, layerToMove);
            layers.Remove(layerToMove);
        }

        public void MoveLayer(Layer layerToMove, InListLocation layerTargetLocation)
        {
            MoveLayer(layerToMove, GetListLocationIndex(layerTargetLocation));
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
            MoveLayer(GetListLocationIndex(layerSourceLocation), targetIndex);
        }

        public void MoveLayer(InListLocation layerSourceLocation, InListLocation layerTargetLocation)
        {
            MoveLayer(GetListLocationIndex(layerSourceLocation), layerTargetLocation);
        }

        private int GetListLocationIndex(InListLocation location)
        {
            return location == InListLocation.First ? 0 : layers.Count - 1;
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
            RemoveLayer(GetListLocationIndex(layerTargetLocation));
        }

        public void RemoveLayers(Predicate<Layer> layerCheckerMethod)
        {
            layers.RemoveAll(layer => layerCheckerMethod(layer));
        }
    }
}