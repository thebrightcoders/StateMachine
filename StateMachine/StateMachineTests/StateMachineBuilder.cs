using StateMachinePack;

namespace StateMachineTests
{
    public class StateMachineBuilder
    {
        private StateMachine stateMachine;
        
        #region Layer Names

        public static readonly string layerWithID = "LayerWithID";
        public static readonly string layerWithIndex = "LayerWithIndex";
        public static readonly string layerWithEnum = "LayerWithEnum";

        #endregion
        
        #region State Names

        public static readonly string StateIDToLastAddedLayer = "StateIDToLastAddedLayer";
        public static readonly string StateIDToLastAddedLayerStateTransition = "StateIDToLastAddedLayerStateTransition";
        public static readonly string StateIDToLastAddedLayerIsLoop = "StateIDToLastAddedLayerIsLoop";
        public static readonly string StateIDToLastAddedLayerBoth = "StateIDToLastAddedLayerBoth";
        public static readonly string StateIDToLayerByObject = "StateIDToLayerByObject";
        public static readonly string StateIDToLayerByObjectStateTransition = "StateIDToLayerByObjectStateTransition";
        public static readonly string StateIDToLayerByObjectIsLoop = "StateIDToLayerByObjectIsLoop";
        public static readonly string StateIDToLayerByObjectBoth = "StateIDToLayerByObjectBoth";
        public static readonly string StateIDToLayerByID = "StateIDToLayerByID";
        public static readonly string StateIDToLayerByIDStateTransition = "StateIDToLayerByIDStateTransition";
        public static readonly string StateIDToLayerByIDIsLoop = "StateIDToLayerByIDIsLoop";
        public static readonly string StateIDToLayerByIDBoth = "StateIDToLayerByIDBoth";
        public static readonly string StateIDToLayerByIndex = "StateIDToLayerByIndex";
        public static readonly string StateIDToLayerByIndexStateTransition = "StateIDToLayerByIndexStateTransition";
        public static readonly string StateIDToLayerByIndexIsLoop = "StateIDToLayerByIndexIsLoop";
        public static readonly string StateIDToLayerByIndexBoth = "StateIDToLayerByIndexBoth";

        #endregion

        #region Transition Names

        public static readonly string TransitionIDToLastAddedLayerToStateObjects = "TransitionIDToLastAddedLayerToStateObjects";
        public static readonly string TransitionIDToLastAddedLayerToStateIDAndObject1 = "TransitionIDToLastAddedLayerToStateIDAndObject1";
        public static readonly string TransitionIDToLastAddedLayerToStateIDAndObject2 = "TransitionIDToLastAddedLayerToStateIDAndObject2";
        public static readonly string TransitionIDToLastAddedLayerToStateIDs = "TransitionIDToLastAddedLayerToStateIDs";
        public static readonly string TransitionIDByLayerObjectToStateObjects = "TransitionIDByLayerObjectToStateObjects";
        public static readonly string TransitionIDByLayerObjectToStateIDAndObject1 = "TransitionIDByLayerObjectToStateIDAndObject1";
        public static readonly string TransitionIDByLayerObjectToStateIDAndObject2 = "TransitionIDByLayerObjectToStateIDAndObject2";
        public static readonly string TransitionIDByLayerObjectToStateIDs = "TransitionIDByLayerObjectToStateIDs";
        public static readonly string TransitionIDByLayerIDToStateObjects = "TransitionIDByLayerIDToStateObjects";
        public static readonly string TransitionIDByLayerIDToStateIDAndObject1 = "TransitionIDByLayerIDToStateIDAndObject1";
        public static readonly string TransitionIDByLayerIDToStateIDAndObject2 = "TransitionIDByLayerIDToStateIDAndObject2";
        public static readonly string TransitionIDByLayerIDToStateIDs = "TransitionIDByLayerIDToStateIDs";
        public static readonly string TransitionIDByLayerIndexToStateObjects = "TransitionIDByLayerIndexToStateObjects";
        public static readonly string TransitionIDByLayerIndexToStateIDAndObject1 = "TransitionIDByLayerIndexToStateIDAndObject1";
        public static readonly string TransitionIDByLayerIndexToStateIDAndObject2 = "TransitionIDByLayerIndexToStateIDAndObject2";
        public static readonly string TransitionIDByLayerIndexToStateIDs = "TransitionIDByLayerIndexToStateIDs";

        #endregion

        #region Sub State Machine Names

        public static readonly string SubStateIDToLastAddedLayer = "SubStateIDToLastAddedLayer";
        public static readonly string SubMachineNameToLastAddedLayer = "SubMachineNameToLastAddedLayer";
        public static readonly string SubStateIDToLastAddedLayerStateTransition = "SubStateIDToLastAddedLayerStateTransition";
        public static readonly string SubMachineNameToLastAddedLayerStateTransition = "SubMachineNameToLastAddedLayerStateTransition";
        public static readonly string SubStateIDToLastAddedLayerIsLoop = "SubStateIDToLastAddedLayerIsLoop";
        public static readonly string SubMachineNameToLastAddedLayerIsLoop = "SubMachineNameToLastAddedLayerIsLoop";
        public static readonly string SubStateIDToLastAddedLayerBoth = "SubStateIDToLastAddedLayerBoth";
        public static readonly string SubMachineNameToLastAddedLayerBoth = "SubMachineNameToLastAddedLayerBoth";
        public static readonly string SubStateIDToLayerByObject = "SubStateIDToLayerByObject";
        public static readonly string SubMachineNameToLayerByObject = "SubMachineNameToLayerByObject";
        public static readonly string SubStateIDToLayerByObjectStateTransition = "SubStateIDToLayerByObjectStateTransition";
        public static readonly string SubMachineNameToLayerByObjectStateTransition = "SubMachineNameToLayerByObjectStateTransition";
        public static readonly string SubStateIDToLayerByObjectIsLoop = "SubStateIDToLayerByObjectIsLoop";
        public static readonly string SubMachineNameToLayerByObjectIsLoop = "SubMachineNameToLayerByObjectIsLoop";
        public static readonly string SubStateIDToLayerByObjectBoth = "SubStateIDToLayerByObjectBoth";
        public static readonly string SubMachineNameToLayerByObjectBoth = "SubMachineNameToLayerByObjectBoth";
        public static readonly string SubStateIDToLayerByID = "SubStateIDToLayerByID";
        public static readonly string SubMachineToLayerByIDName = "SubMachineToLayerByIDName";
        public static readonly string SubStateIDToLayerByIDStateTransition = "SubStateIDToLayerByIDStateTransition";
        public static readonly string SubMachineNameLayerByIDStateTransition = "SubMachineNameLayerByIDStateTransition";
        public static readonly string SubStateIDToLayerByIDIsLoop = "SubStateIDToLayerByIDIsLoop";
        public static readonly string SubMachineNameLayerByIDIsLoop = "SubMachineNameLayerByIDIsLoop";
        public static readonly string SubStateIDToLayerByIDBoth = "SubStateIDToLayerByIDBoth";
        public static readonly string SubMachineNameLayerByIDBoth = "SubMachineNameLayerByIDBoth";
        public static readonly string SubStateIDToLayerByIndex = "SubStateIDToLayerByIndex";
        public static readonly string SubMachineToLayerByIndexName = "SubMachineToLayerByIndexName";
        public static readonly string SubStateIDToLayerByIndexStateTransition = "SubStateIDToLayerByIndexStateTransition";
        public static readonly string SubMachineNameLayerByIndexStateTransition = "SubMachineNameLayerByIndexStateTransition";
        public static readonly string SubStateIDToLayerByIndexIsLoop = "SubStateIDToLayerByIndexIsLoop";
        public static readonly string SubMachineNameLayerByIndexIsLoop = "SubMachineNameLayerByIndexIsLoop";
        public static readonly string SubStateIDToLayerByIndexBoth = "SubStateIDToLayerByIndexBoth";
        public static readonly string SubMachineNameLayerByIndexBoth = "SubMachineNameLayerByIndexBoth";

        #endregion

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
            stateMachine.AddSubStateMachine(SubStateIDToLastAddedLayer, SubMachineNameToLastAddedLayer);
            stateMachine.AddSubStateMachine(SubStateIDToLastAddedLayerStateTransition, SubMachineNameToLastAddedLayerStateTransition, StateTransitionType.Startup);
            stateMachine.AddSubStateMachine(SubStateIDToLastAddedLayerIsLoop, SubMachineNameToLastAddedLayerIsLoop, true);
            stateMachine.AddSubStateMachine(SubStateIDToLastAddedLayerBoth, SubMachineNameToLastAddedLayerBoth, true, StateTransitionType.FromAny);
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {

                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddSubStateMachine(SubStateIDToLayerByObject, SubMachineNameToLayerByObject, layer);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByObjectStateTransition, SubMachineNameToLayerByObjectStateTransition, layer, StateTransitionType.Startup);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByObjectIsLoop, SubMachineNameToLayerByObjectIsLoop, layer, true);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByObjectBoth, SubMachineNameToLayerByObjectBoth, layer, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine(SubStateIDToLayerByID, SubMachineToLayerByIDName, layerID);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIDStateTransition, SubMachineNameLayerByIDStateTransition, layerID, StateTransitionType.Startup);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIDIsLoop, SubMachineNameLayerByIDIsLoop, layerID, true);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIDBoth, SubMachineNameLayerByIDBoth, layerID, true, StateTransitionType.FromAny);

                stateMachine.AddSubStateMachine(SubStateIDToLayerByIndex, SubMachineToLayerByIndexName, i);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIndexStateTransition, SubMachineNameLayerByIndexStateTransition, i, StateTransitionType.Startup);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIndexIsLoop, SubMachineNameLayerByIndexIsLoop, i, true);
                stateMachine.AddSubStateMachine(SubStateIDToLayerByIndexBoth, SubMachineNameLayerByIndexBoth, i, true, StateTransitionType.FromAny);
            }
            return this;
        }
        public StateMachineBuilder WithStates()
        {
            stateMachine.AddState(StateIDToLastAddedLayer);
            stateMachine.AddState(StateIDToLastAddedLayerStateTransition, StateTransitionType.Startup);
            stateMachine.AddState(StateIDToLastAddedLayerIsLoop, true);
            stateMachine.AddState(StateIDToLastAddedLayerBoth, true, StateTransitionType.FromAny);
            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {
                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddState(StateIDToLayerByObject, layer);
                stateMachine.AddState(StateIDToLayerByObjectStateTransition, layer, StateTransitionType.Startup);
                stateMachine.AddState(StateIDToLayerByObjectIsLoop, layer, true);
                stateMachine.AddState(StateIDToLayerByObjectBoth, layer, true, StateTransitionType.FromAny);

                stateMachine.AddState(StateIDToLayerByID, layerID);
                stateMachine.AddState(StateIDToLayerByIDStateTransition, layerID, StateTransitionType.Startup);
                stateMachine.AddState(StateIDToLayerByIDIsLoop, layerID, true);
                stateMachine.AddState(StateIDToLayerByIDBoth, layerID, true, StateTransitionType.FromAny);

                stateMachine.AddState(StateIDToLayerByIndex, i);
                stateMachine.AddState(StateIDToLayerByIndexStateTransition, i, StateTransitionType.Startup);
                stateMachine.AddState(StateIDToLayerByIndexIsLoop, i, true);
                stateMachine.AddState(StateIDToLayerByIndexBoth, i, true, StateTransitionType.FromAny);
            }
            return this;
        }
        public StateMachineBuilder WithTransitions()
        {
            stateMachine.AddTransition(TransitionIDToLastAddedLayerToStateObjects, stateMachine.GetState(StateIDToLastAddedLayer),
                stateMachine.GetState(StateIDToLastAddedLayerBoth));
            stateMachine.AddTransition(TransitionIDToLastAddedLayerToStateIDAndObject1, StateIDToLastAddedLayer,
                stateMachine.GetState(StateIDToLastAddedLayerBoth));
            stateMachine.AddTransition(TransitionIDToLastAddedLayerToStateIDAndObject2, stateMachine.GetState(StateIDToLastAddedLayer),
                StateIDToLastAddedLayerBoth);
            stateMachine.AddTransition(TransitionIDToLastAddedLayerToStateIDs, StateIDToLastAddedLayer,
                StateIDToLastAddedLayerBoth);

            for (int i = 0; i < stateMachine.GetLayersListCount(); i++)
            {
                Layer layer = stateMachine.GetLayer(i);
                string layerID = layer.iD;

                stateMachine.AddTransition(TransitionIDByLayerObjectToStateObjects, stateMachine.GetState(StateIDToLayerByObject),
                    stateMachine.GetState(StateIDToLayerByObjectBoth), layer);
                stateMachine.AddTransition(TransitionIDByLayerObjectToStateIDAndObject1, StateIDToLayerByObject,
                    stateMachine.GetState(StateIDToLayerByObjectBoth), layer);
                stateMachine.AddTransition(TransitionIDByLayerObjectToStateIDAndObject2, stateMachine.GetState(StateIDToLayerByObject),
                    StateIDToLayerByObjectBoth, layer);
                stateMachine.AddTransition(TransitionIDByLayerObjectToStateIDs, StateIDToLayerByObject,
                    StateIDToLayerByObjectBoth, layer);

                stateMachine.AddTransition(TransitionIDByLayerIDToStateObjects, stateMachine.GetState(StateIDToLayerByID),
                    stateMachine.GetState(StateIDToLayerByIDBoth), layerID);
                stateMachine.AddTransition(TransitionIDByLayerIDToStateIDAndObject1, StateIDToLayerByID,
                    stateMachine.GetState(StateIDToLayerByIDBoth), layerID);
                stateMachine.AddTransition(TransitionIDByLayerIDToStateIDAndObject2, stateMachine.GetState(StateIDToLayerByID),
                    StateIDToLayerByIDBoth, layerID);
                stateMachine.AddTransition(TransitionIDByLayerIDToStateIDs, StateIDToLayerByID,
                    StateIDToLayerByIDBoth, layerID);

                stateMachine.AddTransition(TransitionIDByLayerIndexToStateObjects, stateMachine.GetState(StateIDToLayerByIndex),
                    stateMachine.GetState(StateIDToLayerByIndexBoth), i);
                stateMachine.AddTransition(TransitionIDByLayerIndexToStateIDAndObject1, StateIDToLayerByIndex,
                    stateMachine.GetState(StateIDToLayerByIndexBoth), i);
                stateMachine.AddTransition(TransitionIDByLayerIndexToStateIDAndObject2, stateMachine.GetState(StateIDToLayerByIndex),
                    StateIDToLayerByIndexBoth, i);
                stateMachine.AddTransition(TransitionIDByLayerIndexToStateIDs, StateIDToLayerByIndex,
                    StateIDToLayerByIndexBoth, i);
            }

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