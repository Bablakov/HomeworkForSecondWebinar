using Task2.Interfaces;

namespace Task2.StateMachine
{
    public abstract class NPCState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;

        public NPCState(IStateSwitcher stateSwitcher)
        {
            StateSwitcher = stateSwitcher;
        }

        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
        protected abstract void EndState();
    }
}