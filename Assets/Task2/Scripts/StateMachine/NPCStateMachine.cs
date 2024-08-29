using System;
using System.Collections.Generic;
using System.Linq;
using Task2.Interfaces;

namespace Task2.StateMachine
{
    public class NPCStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public NPCStateMachine()
        {
            _states = new List<IState>();
        }

        public void SwitchState<State>() where State : IState
        {
            IState state = _states.FirstOrDefault(state => state is State);

            if (state == null)
                throw new ArgumentException($"В машине состояния, данного состояния нет");

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void RegistrateState<TState>(TState state) where TState : IState
        {
            if (_states.FirstOrDefault(state => state is TState) != null)
                throw new ArgumentException($"В машине состояний, уже есть такое состояние");

            _states.Add(state);  
        }

        public void Update() => _currentState?.Update();
    }
}