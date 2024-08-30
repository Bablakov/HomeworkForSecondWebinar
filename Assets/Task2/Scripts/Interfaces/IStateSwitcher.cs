namespace Task2.Interfaces
{
    public interface IStateSwitcher<TState>
    {
        public void SwitchState<State>() where State : TState;
    }
}