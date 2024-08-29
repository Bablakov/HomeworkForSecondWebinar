using Task2.Interfaces;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States
{
    public class GoingHomeState : IState
    {
        private IStateSwitcher _stateSwitcher;
        private IMovable _movable;
        private NPCStateMachineData _npcStateMachineData;

        private float _speed = 5f;

        public GoingHomeState(IStateSwitcher stateSwitcher, NPCStateMachineData npsStateMachineDate, IMovable movable)
        {
            _stateSwitcher = stateSwitcher;
            _npcStateMachineData = npsStateMachineDate;
            _movable = movable;
        }

        private Vector3 HomePosition => _npcStateMachineData.TransformTargetHome.position;
        private Vector3 NPCPosition => _movable.Transform.position;

        public void Enter()
        {
            Debug.Log("Начинаю идти домой");
        }

        public void Exit()
        {
            Debug.Log("Пришёл домой");
        }

        public void Update()
        {
            var directionMovement = HomePosition - NPCPosition;
            if (directionMovement.magnitude <= 0.1f)
                _stateSwitcher.SwitchState<RestingState>();

            _movable.Move(directionMovement.normalized * _speed * Time.deltaTime);
        }
    }
}