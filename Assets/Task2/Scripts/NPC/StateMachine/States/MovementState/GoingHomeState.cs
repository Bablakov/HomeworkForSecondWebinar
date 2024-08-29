using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.ActionState;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.MovementState
{
    public class GoingHomeState : MovementState
    {
        public GoingHomeState(IStateSwitcher stateSwitcher, NPCStateMachineData npsStateMachineDate, IMovable movable, NPCConfig npcConfig)
            : base(stateSwitcher, npsStateMachineDate, movable, npcConfig)
        { }

        protected override float Speed => MovementStateConfig.SpeedGoingHome;
        protected override Vector3 TargetPosition => NPCStateMachineData.TransformTargetHome.position;

        public override void Enter()
        {
            Debug.Log("Пошёл домой");
        }

        public override void Exit()
        {
            Debug.Log("Пришёл домой");
        }

        protected override void EndMovement()
        {
            StateSwitcher.SwitchState<SleepingState>();
        }
    }
}