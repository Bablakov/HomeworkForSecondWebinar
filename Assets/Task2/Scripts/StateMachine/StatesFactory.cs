using Task2.Interfaces;
using Zenject;

namespace Assets.Task2.Scripts.StateMachine
{
    public class StatesFactory
    {
        private IInstantiator _instantiator;

        public StatesFactory(IInstantiator instantiator) =>
            _instantiator = instantiator;

        public TState Create<TState>() where TState : IState =>
            _instantiator.Instantiate<TState>();
    }
}
