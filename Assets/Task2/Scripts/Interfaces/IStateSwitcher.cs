namespace Task2.Interfaces
{
    public interface IStateSwitcher
    {
        public void SwitchState<TState>() where TState : IState;
        public void RegistrateState<TState>(TState state) where TState : IState;
    }
}