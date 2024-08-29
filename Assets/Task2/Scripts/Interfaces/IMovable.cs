using UnityEngine;

namespace Task2.Interfaces
{
    public interface IMovable
    {
        public Transform Transform { get; }

        public void Move(Vector3 direrectionMovement);
    }
}
