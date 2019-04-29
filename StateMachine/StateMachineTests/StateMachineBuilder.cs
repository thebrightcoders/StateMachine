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
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {
                stateMachine.AddSubStateMachine("stateID", "subMachineName");
                stateMachine.AddSubStateMachine("stateIDStateTransition", "subMachineNameStateTransition", StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDIsLoop", "subMachineNameIsLoop", true);
                stateMachine.AddSubStateMachine("stateIDBoth", "subMachineNameBoth", true, StateTransitionType.FromAny);
                stateMachine.AddSubStateMachine("stateIDToLayer", "subMachineNameToLayer");
                stateMachine.AddSubStateMachine("stateIDToLayerStateTransition", "subMachineNameToLayerStateTransition", StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDToLayerIsLoop", "subMachineNameToLayerIsLoop", true);
                stateMachine.AddSubStateMachine("stateIDToLayerBoth", "subMachineNameToLayerBoth", true, StateTransitionType.FromAny);
                stateMachine.AddSubStateMachine("stateIDToLayer", "subMachineToLayerName");
                stateMachine.AddSubStateMachine("stateIDToLayerStateTransition", "subMachineNameLayerStateTransition", StateTransitionType.StartUp);
                stateMachine.AddSubStateMachine("stateIDToLayerIsLoop", "subMachineNameLayerIsLoop", true);
                stateMachine.AddSubStateMachine("stateIDToLayerBoth", "subMachineNameLayerBoth", true, StateTransitionType.FromAny);
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