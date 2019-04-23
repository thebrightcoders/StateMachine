using StateMachinePack;
using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerRemovers
    {
        void RemoveLayer(Layer layerToRemove);
        void RemoveLayer(int index);
        void RemoveLayer(InListLocation layerTargetLocation);
        void RemoveLayers(Predicate<Layer> layerCheckerMethod);
    }
}