using System;
using System.Collections.Generic;
using System.Linq;
using Task2.Interfaces;

namespace Task2.StateMachine
{
    public abstract class StateMachine<TState> : IStateSwitcher<TState> where TState : IState
    {
        protected TState _currentState;
        
        private List<TState> _states;

        public StateMachine()
        {
            _states = new List<TState>();
        }

        public void SwitchState<State>() where State : TState
        {
            TState state = _states.FirstOrDefault(state => state is State);

            if (state == null)
                throw new ArgumentException($"¬ машине состо€ни€, данного состо€ни€ нет");

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void RegistrateState<State>(State state) where State : TState
        {
            if (_states.FirstOrDefault(state => state is State) != null)
                throw new ArgumentException($"¬ машине состо€ний, уже есть такое состо€ние");

            _states.Add(state);
        }

        public void Update() => _currentState?.Update();
    }
}