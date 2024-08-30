using UnityEngine;
using Task2.Interfaces;
using Zenject;
using Task2.NPC.StateMachine;

namespace Task2.NPC
{
    [RequireComponent(typeof(CharacterController))]
    public class NPC : MonoBehaviour, IMovable, IInitializable
    {
        private CharacterController _characterController;
        private NPCStateMachine _stateMachine;

        public Transform Transform => transform;

        [Inject]
        public void Construct(NPCStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Initialize()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _stateMachine?.Update();
        }

        public void Move(Vector3 direrectionMovement)
        {
            _characterController.Move(direrectionMovement);
        }
    }
}