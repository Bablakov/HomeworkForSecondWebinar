using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.MovementState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.ActionState
{
    public class SleepingState : ActionState
    {
        public SleepingState(IStateSwitcher<NPCState> stateSwitcher, NPCConfig npcConfig)
            : base(stateSwitcher, npcConfig)
        { }

        protected override float TimeAction => ActionStateConfig.SleepingTime;

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Начинаю отдыхать");
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("Закончил отдыхать");
        }

        protected override void EndTime()
        {
            StateSwitcher.SwitchState<GoingWorkState>();
        }
    }
}