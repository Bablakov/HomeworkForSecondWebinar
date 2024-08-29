using Task2.Interfaces;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States
{
    public class WorkingState : IState
    {
        private IStateSwitcher _stateSwitcher;
        private NPCStateMachineData _npcStateMachineData;
        private float _timeWorking;

        public WorkingState(IStateSwitcher stateSwitcher, NPCStateMachineData npcStateMachineData)
        {
            _stateSwitcher = stateSwitcher;
            _npcStateMachineData = npcStateMachineData;
        }

        public void Enter()
        {
            _timeWorking = _npcStateMachineData.WorkingTime;
            Debug.Log("Начинаю работать");
        }

        public void Exit()
        {
            Debug.Log("Закончил работать");
        }

        public void Update()
        {
            _timeWorking -= Time.deltaTime;

            if (_timeWorking <= 0)
                _stateSwitcher.SwitchState<GoingHomeState>();
        }
    }
}