﻿using StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces;
using System;
using System.Collections.Generic;

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

        public Layer AddLayer(string iD, InListLocation LocationToAdd, params State[] states) //DONE
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
            Validator.ValidateID(ref iD);
            return layers.Find(layerTofind => layerTofind.iD == iD) != null;
        }

        public bool HasLayerByLayer(Layer layerToCheck)
        {
            if (layerToCheck == null)
                throw new NullReferenceException();
            return layers.Find(layerTofind => layerTofind == layerToCheck) != null;
        }

        public Layer GetLayer(string iD)
        {
            Validator.ValidateID(ref iD);
            Layer layer = layers.Find(layerTofind => layerTofind.iD == iD);
            //if (layer != null)
            return layer;

            //throw new Exception(string.Format("The layer is not found with this {0} iD", iD));
        }

        public Layer GetLayer(InListLocation layerLocation)
        {
            return GetLayer(layerLocation == InListLocation.First ? 0 : layers.Count - 1);
        }

        public Layer GetLayer(int index)
        {
            if (!Validator.IsValidIndexInLayersList(index, layers))
                throw new Exception(string.Format("The index {0} is  OUTOFRANGE!", index));

            return layers[index];
        }

        public Layer GetFirstLayer()
        {
            return layers[0];
        }

        public Layer GetLastLayer()
        {
            return layers[layers.Count - 1];
        }

        public int GetLayersListCount()
        {
            return layers == null ? 0 : layers.Count;
        }

        public Layer[] GetLayers(Predicate<Layer> layerCheckerMethod)
        {
            List<Layer> matchedLayersList = new List<Layer>();
            foreach (Layer layer in layers)
            {
                if (layerCheckerMethod(layer))
                {
                    matchedLayersList.Add(layer);
                }
            }

            return matchedLayersList.ToArray();
        }

        public void MoveLayer(Layer layerToMove, int targetIndex)
        {
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
    }
}