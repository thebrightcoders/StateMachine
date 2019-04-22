using StateMachine;
using System;

namespace StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerRemovers
    {
        void RemoveLayer(Layer layerToRemove);
        void RemoveLayer(int index);
        void RemoveLayer(InListLocation layerTargetLocation);
        void RemoveLayers(Predicate<Layer> layerCheckerMethod);
    }
}