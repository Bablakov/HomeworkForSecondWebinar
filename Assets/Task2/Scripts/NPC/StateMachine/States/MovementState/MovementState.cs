using Task2.Interfaces;
using Task2.NPC.Config;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.MovementState
{
    public abstract class MovementState : NPCState
    {
        protected NPCStateMachineData NPCStateMachineData;
        protected MovementStateConfig MovementStateConfig;

        private IMovable _movable;

        public MovementState(IStateSwitcher<NPCState> stateSwitcher, NPCStateMachineData npcStateMachineData, IMovable movable, NPCConfig npcConfig)
            : base(stateSwitcher)
        {
            _movable = movable;
            NPCStateMachineData = npcStateMachineData;
            MovementStateConfig = npcConfig.MovementStateConfig;
        }

        protected abstract float Speed { get; }
        protected abstract Vector3 TargetPosition { get; }
        private Vector3 NPCPosition => _movable.Transform.position;
        private float FinishingDistance => MovementStateConfig.FinishingDistance;

        public override void Enter()
        {
        }

        public override void Exit()
        {
        }

        public override void Update()
        {
            var directionMovement = TargetPosition - NPCPosition;
            if (directionMovement.magnitude <= FinishingDistance)
                EndMovement();

            _movable.Move(directionMovement.normalized * Speed * Time.deltaTime);
        }

        protected override void EndState() => EndMovement();

        protected abstract void EndMovement();
    }
}