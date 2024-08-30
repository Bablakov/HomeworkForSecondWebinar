using Task2.Interfaces;

namespace Task2.NPC.StateMachine.States
{
    public abstract class NPCState : IState
    {
        protected readonly IStateSwitcher<NPCState> StateSwitcher;

        public NPCState(IStateSwitcher<NPCState> stateSwitcher)
        {
            StateSwitcher = stateSwitcher;
        }

        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
        protected abstract void EndState();
    }
}