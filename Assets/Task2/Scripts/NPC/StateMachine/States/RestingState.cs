using Task2.Interfaces;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States
{
    public class RestingState : IState
    {
        private IStateSwitcher _stateSwitcher;
        private NPCStateMachineData _npcStateMachineData;

        private float _timeWorking;

        public RestingState(IStateSwitcher stateSwitcher, NPCStateMachineData npsStateMachineDate)
        {
            _stateSwitcher = stateSwitcher;
            _npcStateMachineData = npsStateMachineDate;
        }

        public void Enter()
        {
            _timeWorking = _npcStateMachineData.RestingTime;
            Debug.Log("Начинаю отдыхать");
        }

        public void Exit()
        {
            Debug.Log("Закончил отдыхать");
        }

        public void Update()
        {
            _timeWorking -= Time.deltaTime;

            if (_timeWorking <= 0)
                _stateSwitcher.SwitchState<GoingWorkState>();
        }
    }
}