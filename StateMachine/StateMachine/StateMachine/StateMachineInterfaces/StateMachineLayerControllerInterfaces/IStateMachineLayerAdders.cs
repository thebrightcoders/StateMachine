namespace StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerAdders
    {
         Layer AddLayer(string iD, params State[] states);
         Layer AddLayer(string iD, int index, params State[] states);
         Layer AddLayer(string iD, InListLocation LocationToAdd, params State[] states);

    }
}