using StateMachine;
using System;

namespace StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerGetters
    {
        Layer GetLayer(string iD);
        Layer GetLayer(InListLocation layerLocation);
        Layer GetFirstLayer();
        Layer GetLastLayer();
        int GetLayersListCount();
        Layer[] GetLayers(Predicate<Layer> layerCheckerMethod);
    }
}