namespace StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerCheckers
    {
        bool HasLayerById(string iD);
        bool HasLayer(Layer layerToCheck);

    }
}