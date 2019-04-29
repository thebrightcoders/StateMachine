﻿using System.Runtime.CompilerServices;

namespace StateMachinePack.Tests
{
    public class StateMachineBuilder
    {
        private StateMachine stateMachine;

        public static readonly string layerOnly = "LayerOnly";
        public static readonly string layerwithindex = "LayerWithIndex";
        public static readonly string layerWithEnum = "LayerWithEnum";

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
            stateMachine.AddLayer(layerOnly);
            stateMachine.AddLayer(layerwithindex, 1);
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