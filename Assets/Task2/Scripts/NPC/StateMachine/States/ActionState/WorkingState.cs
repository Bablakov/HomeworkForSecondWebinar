using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.MovementState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.ActionState
{
    public class WorkingState : ActionState
    {
        public WorkingState(IStateSwitcher stateSwitcher, NPCConfig npcConfig) 
            : base(stateSwitcher, npcConfig)
        { }

        protected override float TimeAction => ActionStateConfig.WorkingTime;

        public override void Enter()
        {
            Debug.Log("Начинаю работать");
        }

        public override void Exit()
        {
            Debug.Log("Закончил работать");
        }

        protected override void EndTime()
        {
            StateSwitcher.SwitchState<GoingHomeState>();
        }
    }
}