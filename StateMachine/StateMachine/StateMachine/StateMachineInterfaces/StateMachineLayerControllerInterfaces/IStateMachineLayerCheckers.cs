﻿namespace StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerCheckers
    {
        bool HasLayer(string iD);
        bool HasLayer(Layer layerToCheck);

    }
}