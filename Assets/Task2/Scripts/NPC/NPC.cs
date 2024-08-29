using UnityEngine;
using Task2.StateMachine;
using Task2.Interfaces;
using Zenject;

namespace Task2.NPC
{
    [RequireComponent(typeof(CharacterController))]
    public class NPC : MonoBehaviour, IMovable, IInitializable
    {
        [SerializeField] private CharacterController _characterController;

        private NPCStateMachine _stateMachine;

        public Transform Transform => transform;

        [Inject]
        public void Construct(NPCStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Initialize()
        {
            GetComponent();
        }

        private void Update()
        {
            _stateMachine?.Update();
        }

        public void Move(Vector3 direrectionMovement)
        {
            _characterController.Move(direrectionMovement);
        }

        private void GetComponent()
        {
            _characterController = GetComponent<CharacterController>();
        }
    }
}
