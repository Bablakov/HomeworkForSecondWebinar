using Assets.Task2.Scripts.StateMachine;
using Task2.NPC.StateMachine.States;
using Zenject;
using UnityEngine;
using Task2.StateMachine;

namespace Task2.Services
{
    public class Bootstrap : MonoBehaviour
    {
        private NPCStateMachine _stateSwitcher;
        private StatesFactory _statesFactory;

        [Inject]
        public void Construct(NPCStateMachine stateSwitcher, StatesFactory statesFactory)
        {
            _stateSwitcher = stateSwitcher;
            _statesFactory = statesFactory;
        }

        private void Awake()
        {
            Debug.Log($"{_statesFactory}, {_stateSwitcher}");

            _stateSwitcher.RegistrateState(_statesFactory.Create<GoingHomeState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<GoingWorkState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<RestingState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<WorkingState>());
            
            _stateSwitcher.SwitchState<GoingWorkState>();
        }
    }
}