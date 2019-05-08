using System;

namespace StateMachinePack.StateMachineInterfaces.StateMachineTransitionControllerInterfaces
{
    interface IStateMachineTransitionAdders
    {
        Transition AddTransition(string iD, State sourceState, State targetState, params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, State targetState, params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetStateID, params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, string targetStateID, params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, Layer layerToAddTransition,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, string targetStateID, Layer layerToAddTransition,
                    params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, State targetState, Layer layerToAddTransition,
                    params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetStateID, Layer layerToAddTransition,
                    params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, int layerIndex,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, State targetState, int layerIndex,
                    params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetStateID, int layerIndex,
                    params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, string targetStateID, int layerIndex,
                    params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, string layerID,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, State targetState, string layerID,
            params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetStateID, string layerID,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, string targetStateID, string layerID,
            params Condition[] conditions);


        Transition AddTransition(string iD, State sourceState, State targetState,
            InListLocation layerLocation = InListLocation.First, params Condition[] conditions);
        Transition AddTransition(string iD, string sourceStateID, State targetState,
            InListLocation layerLocation = InListLocation.First, params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetStateID,
            InListLocation layerLocation = InListLocation.First, params Condition[] conditions);
        Transition AddTransition(string iD, string sourceState, string targetState,
            InListLocation layerLocation = InListLocation.First, params Condition[] conditions);

        Transition AddTransition(string iD, State sourceState, State targetState, Predicate<Layer> layerCheckerMethod,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceState, State targetState, Predicate<Layer> layerCheckerMethod,
            params Condition[] conditions);
        Transition AddTransition(string iD, State sourceState, string targetState, Predicate<Layer> layerCheckerMethod,
            params Condition[] conditions);
        Transition AddTransition(string iD, string sourceState, string targetState, Predicate<Layer> layerCheckerMethod,
            params Condition[] conditions);

        Transition AddTransition(string iD, Predicate<State> sourceStateCheckerMethod,
                                 Predicate<State> targetStateCheckerMethod, Predicate<Layer> layerCheckerMethod,
                                 params Condition[] conditions);

        Transition AddTransition(string iD, State state, StateTransitionType transitionType,
                                 params Condition[] conditions);
        Transition AddTransition(string iD, string stateID, StateTransitionType transitionType,
                                 params Condition[] conditions);

        Transition AddTransition(string iD, Predicate<State> stateCheckerMethod, StateTransitionType transitionType,
                                 params Condition[] conditions);


    }
}
