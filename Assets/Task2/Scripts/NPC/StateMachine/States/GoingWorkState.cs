using Task2.Interfaces;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States
{
    public class GoingWorkState : IState
    {
        private IStateSwitcher _stateSwitcher;
        private IMovable _movable;
        private NPCStateMachineData _npcStateMachineData;

        private float _speed = 5f;

        public GoingWorkState(IStateSwitcher stateSwitcher, NPCStateMachineData npsStateMachineDate, IMovable movable)
        {
            _stateSwitcher = stateSwitcher;
            _npcStateMachineData = npsStateMachineDate;
            _movable = movable;
        }

        private Vector3 WorkPosition => _npcStateMachineData.transformTargetWork.position;
        private Vector3 NPCPosition => _movable.Transform.position;

        public void Enter()
        {
            Debug.Log("Начинаю идти на работу");
        }

        public void Exit()
        {
            Debug.Log("Пришёл на работу");
        }

        public void Update()
        {
            var directionMovement = WorkPosition - NPCPosition;
            if (directionMovement.magnitude <= 0.1f)
                _stateSwitcher.SwitchState<WorkingState>();

            _movable.Move(directionMovement.normalized * _speed * Time.deltaTime);
        }
    }
}