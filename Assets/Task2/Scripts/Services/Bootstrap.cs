using Zenject;
using UnityEngine;
using Task2.NPC.StateMachine.States.MovementState;
using Task2.NPC.StateMachine.States.ActionState;
using Task2.NPC.StateMachine;

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
            RegistrateNPCStates();
            SwitchStartState();
        }

        private void RegistrateNPCStates()
        {
            _stateSwitcher.RegistrateState(_statesFactory.Create<GoingHomeState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<GoingWorkState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<SleepingState>());
            _stateSwitcher.RegistrateState(_statesFactory.Create<WorkingState>());
        }

        private void SwitchStartState() =>
            _stateSwitcher.SwitchState<GoingWorkState>();
    }
}