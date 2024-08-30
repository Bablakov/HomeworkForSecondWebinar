using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.NPC.StateMachine.States.MovementState;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.ActionState
{
    public class WorkingState : ActionState
    {
        public WorkingState(IStateSwitcher<NPCState> stateSwitcher, NPCConfig npcConfig) 
            : base(stateSwitcher, npcConfig)
        { }

        protected override float TimeAction => ActionStateConfig.WorkingTime;

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Начинаю работать");
        }

        public override void Exit()
        {
            base.Exit();
            Debug.Log("Закончил работать");
        }

        protected override void EndTime()
        {
            StateSwitcher.SwitchState<GoingHomeState>();
        }
    }
}