using StateMachine;

namespace StateMachine.StateMachineInterfaces.StateMachineLayerControllerInterfaces
{
    public interface IStateMachineLayerMovers
    {
        void MoveLayer(Layer layerToMove, int targetIndex);
        void MoveLayer(Layer layerToMove, InListLocation layerTargetLocation);
        void MoveLayer(string iD, int targetIndex);
        void MoveLayer(string iD, InListLocation layerTargetLocation);
        void MoveLayer(int sourceIndex, int targetIndex);
        void MoveLayer(int sourceIndex, InListLocation layerTargetLocation);
        void MoveLayer(InListLocation layerTargetLocation, int targetIndex);
        void MoveLayer(InListLocation layerSourceLocation, InListLocation layerTargetLocation);
        void MoveLayerToFirst(Layer layerToMove);
        void MoveLayerToFirst(string iD);
        void MoveLayerToFirst(int sourceIndex);
        void MoveLayerToLast(Layer layerToMove);
        void MoveLayerToLast(string iD);
        void MoveLayerToLast(int sourceIndex);

    }
}