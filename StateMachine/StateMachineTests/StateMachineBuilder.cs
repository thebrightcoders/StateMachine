using System.Runtime.CompilerServices;

namespace StateMachinePack.Tests
{
    public class StateMachineBuilder
    {
        private StateMachine stateMachine;

        public StateMachineBuilder()
        {
            this.stateMachine = new StateMachine();
        }

        public static StateMachineBuilder Build()
        {
            return new StateMachineBuilder();
        }

        public StateMachineBuilder WithLayers()
        {
            stateMachine.AddLayer("LayerOnly");
            stateMachine.AddLayer("LayerWithIndex", 1);
            stateMachine.AddLayer("LayerWithEnum", InListLocation.First);

            return this;
        }
        public StateMachineBuilder WithSubStateMachines()
        {
            stateMachine.AddSubStateMachine("stateID", "subMachineName");
            stateMachine.AddSubStateMachine("stateIDStateTransition", "subMachineNameStateTransition", StateTransitionType.StartUp);
            stateMachine.AddSubStateMachine("stateIDIsLoop", "subMachineNameIsLoop", true);
            stateMachine.AddSubStateMachine("stateIDBoth", "subMachineNameBoth", true, StateTransitionType.FromAny);
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {

                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddSubStateMachine("stateIDToLayerByObject", "subMachineNameToLayerByObject", layer);
                stateMachine.AddSubStateMachine("stateIDToLayerByObjectStateTransition", "subMachineNameToLayerByObjectStateTransition", layer, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDToLayerByObjectIsLoop", "subMachineNameToLayerByObjectIsLoop", layer, true);
                stateMachine.AddSubStateMachine("stateIDToLayerByObjectBoth", "subMachineNameToLayerByObjectBoth", layer, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine("stateIDToLayerByID", "subMachineToLayerByIDName", layerID);
                stateMachine.AddSubStateMachine("stateIDToLayerByIDStateTransition", "subMachineNameLayerByIDStateTransition", layerID, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDToLayerByIDIsLoop", "subMachineNameLayerByIDIsLoop", layerID, true);
                stateMachine.AddSubStateMachine("stateIDToLayerByIDBoth", "subMachineNameLayerByIDBoth", layerID, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine("stateIDToLayerByIndex", "subMachineToLayerByIndexName", i);
                stateMachine.AddSubStateMachine("stateIDToLayerByIndexStateTransition", "subMachineNameLayerByIndexStateTransition", i, StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDToLayerByIndexIsLoop", "subMachineNameLayerByIndexIsLoop", i, true);
                stateMachine.AddSubStateMachine("stateIDToLayerByIndexBoth", "subMachineNameLayerByIndexBoth", i, true, StateTransitionType.FromAny);
            }
            return this;
        }
        public StateMachineBuilder WithStates()
        {
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