namespace StateMachinePack.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerAdders
    {
         Layer AddLayer(string iD);
         Layer AddLayer(string iD, int index);
         Layer AddLayer(string iD, InListLocation LocationToAdd);

    }
}