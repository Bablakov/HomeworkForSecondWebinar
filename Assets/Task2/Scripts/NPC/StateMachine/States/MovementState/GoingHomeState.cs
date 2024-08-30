using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.ActionState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.MovementState
{
    public class GoingHomeState : MovementState
    {
        public GoingHomeState(IStateSwitcher<NPCState> stateSwitcher, NPCStateMachineData npsStateMachineDate, IMovable movable, NPCConfig npcConfig)
            : base(stateSwitcher, npsStateMachineDate, movable, npcConfig)
        { }

        protected override float Speed => MovementStateConfig.SpeedGoingHome;
        protected override Vector3 TargetPosition => NPCStateMachineData.TargetHome.position;

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Пошёл домой");
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("Пришёл домой");
        }

        protected override void EndMovement()
        {
            StateSwitcher.SwitchState<SleepingState>();
        }
    }
}