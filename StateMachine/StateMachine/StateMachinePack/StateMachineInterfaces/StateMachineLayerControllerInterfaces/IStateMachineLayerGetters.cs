using StateMachinePack;
using System;
using System.Collections.Generic;

namespace StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerGetters
    {
        Layer GetLayer(string iD);
        Layer GetLayer(int index);
        Layer GetLayer(InListLocation layerLocation);
        Layer GetFirstLayer();
        Layer GetLastLayer();
        int GetLayersListCount();
        Layer[] GetLayers(Predicate<Layer> layerCheckerMethod);
    }
}