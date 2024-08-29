using Task2.Config;
using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.MovementState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.ActionState
{
    public class SleepingState : ActionState
    {
        public SleepingState(IStateSwitcher stateSwitcher, NPCConfig npcConfig)
            : base(stateSwitcher, npcConfig)
        { }

        protected override float TimeAction => ActionStateConfig.SleepingTime;

        public override void Enter()
        {
            Debug.Log("Начинаю отдыхать");
        }

        public override void Exit()
        {
            Debug.Log("Закончил отдыхать");
        }

        protected override void EndTime()
        {
            StateSwitcher.SwitchState<GoingWorkState>();
        }
    }
}