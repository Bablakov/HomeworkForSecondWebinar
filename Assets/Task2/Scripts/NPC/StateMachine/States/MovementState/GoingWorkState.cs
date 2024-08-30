using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.ActionState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.MovementState
{
    public class GoingWorkState : MovementState
    {
        public GoingWorkState(IStateSwitcher<NPCState> stateSwitcher, NPCStateMachineData npsStateMachineDate, IMovable movable, NPCConfig npcConfig)
           : base(stateSwitcher, npsStateMachineDate, movable, npcConfig)
        { }

        protected override float Speed => MovementStateConfig.SpeedGoingWork;
        protected override Vector3 TargetPosition => NPCStateMachineData.TargetWork.position;

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Пошёл на работу");
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("Пришёл на работу");
        }

        protected override void EndMovement()
        {
            StateSwitcher.SwitchState<WorkingState>();
        }
    }
}