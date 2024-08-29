using Task2.Config;
using Task2.Interfaces;
using Task2.NPC.Config;
using Task2.StateMachine;
using UnityEngine;

namespace Task2.NPC.StateMachine.States.ActionState
{
    public abstract class ActionState : NPCState
    {
        protected ActionStateConfig ActionStateConfig;

        private float _timeAction;

        public ActionState(IStateSwitcher stateSwitcher, NPCConfig npcConfig)
            : base(stateSwitcher) => ActionStateConfig = npcConfig.ActionStateConfig;

        protected abstract float TimeAction { get; }

        public override void Enter()
        {
        }

        public override void Exit()
        {}

        public override void Update()
        {
            _timeAction += Time.deltaTime;

            if (_timeAction >= TimeAction)
                EndState();
        }


        protected override void EndState() => EndTime();

        protected abstract void EndTime();
    }
}
