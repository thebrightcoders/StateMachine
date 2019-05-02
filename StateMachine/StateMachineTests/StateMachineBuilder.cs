namespace StateMachinePack.Tests
{
    public class StateMachineBuilder
    {
        private StateMachine stateMachine;

        public static readonly string layerWithID = "LayerWithID";
        public static readonly string layerWithIndex = "LayerWithIndex";
        public static readonly string layerWithEnum = "LayerWithEnum";

        private StateMachineBuilder()
        {
            this.stateMachine = new StateMachine();
        }

        public static StateMachineBuilder Build()
        {
            return new StateMachineBuilder();
        }

        public StateMachineBuilder WithLayers()
        {
            stateMachine.AddLayer(layerWithID);
            stateMachine.AddLayer(layerWithIndex, 1);
            stateMachine.AddLayer(layerWithEnum, InListLocation.First);

            return this;
        }
        public StateMachineBuilder WithSubStateMachines()
        {
            stateMachine.AddSubStateMachine("subStateIDToLastAddedLayer", "subMachineNameToLastAddedLayer");
            stateMachine.AddSubStateMachine("subStateIDToLastAddedLayerStateTransition", "subMachineNameToLastAddedLayerStateTransition", StateTransitionType.StartUp);
            stateMachine.AddSubStateMachine("subStateIDToLastAddedLayerIsLoop", "subMachineNameToLastAddedLayerIsLoop", true);
            stateMachine.AddSubStateMachine("subStateIDToLastAddedLayerBoth", "subMachineNameToLastAddedLayerBoth", true, StateTransitionType.FromAny);
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {

                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddSubStateMachine("subStateIDToLayerByObject", "subMachineNameToLayerByObject", layer);
                stateMachine.AddSubStateMachine("subStateIDToLayerByObjectStateTransition", "subMachineNameToLayerByObjectStateTransition", layer, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("subStateIDToLayerByObjectIsLoop", "subMachineNameToLayerByObjectIsLoop", layer, true);
                stateMachine.AddSubStateMachine("subStateIDToLayerByObjectBoth", "subMachineNameToLayerByObjectBoth", layer, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine("subStateIDToLayerByID", "subMachineToLayerByIDName", layerID);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIDStateTransition", "subMachineNameLayerByIDStateTransition", layerID, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIDIsLoop", "subMachineNameLayerByIDIsLoop", layerID, true);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIDBoth", "subMachineNameLayerByIDBoth", layerID, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine("subStateIDToLayerByIndex", "subMachineToLayerByIndexName", i);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIndexStateTransition", "subMachineNameLayerByIndexStateTransition", i, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIndexIsLoop", "subMachineNameLayerByIndexIsLoop", i, true);
                stateMachine.AddSubStateMachine("subStateIDToLayerByIndexBoth", "subMachineNameLayerByIndexBoth", i, true, StateTransitionType.FromAny);
            }
            return this;
        }
        public StateMachineBuilder WithStates()
        {
            stateMachine.AddState("StateIDToLastAddedLayer");
            stateMachine.AddState("StateIDToLastAddedLayerStateTransition", StateTransitionType.StartUp);
            stateMachine.AddState("StateIDToLastAddedLayerIsLoop", true);
            stateMachine.AddState("StateIDToLastAddedLayerBoth", true, StateTransitionType.FromAny);
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {
                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddState("StateIDToLayerByObject", layer);
                stateMachine.AddState("StateIDToLayerByObjectStateTransition", layer, StateTransitionType.StartUp);
                stateMachine.AddState("StateIDToLayerByObjectIsLoop", layer, true);
                stateMachine.AddState("StateIDToLayerByObjectBoth", layer, true, StateTransitionType.FromAny);

                stateMachine.AddState("StateIDToLayerByID", layerID);
                stateMachine.AddState("StateIDToLayerByIDStateTransition", layerID, StateTransitionType.StartUp);
                stateMachine.AddState("StateIDToLayerByIDIsLoop", layerID, true);
                stateMachine.AddState("StateIDToLayerByIDBoth", layerID, true, StateTransitionType.FromAny);

                stateMachine.AddState("StateIDToLayerByIndex", i);
                stateMachine.AddState("StateIDToLayerByIndexStateTransition", i, StateTransitionType.StartUp);
                stateMachine.AddState("StateIDToLayerByIndexIsLoop", i, true);
                stateMachine.AddState("StateIDToLayerByIndexBoth", i, true, StateTransitionType.FromAny);
            }
            return this;
        }
        public StateMachineBuilder WithTransitions()
        {
            return this;
        }
        public StateMachineBuilder WithConditions()
        {
            return this;
        }


        public static implicit operator StateMachine(StateMachineBuilder smb)
        {
            return smb.stateMachine;
        }
    }
}