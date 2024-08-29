using UnityEngine;
using System;

namespace Task2.StateMachine
{
    [Serializable]
    public class NPCStateMachineData
    {
        public float Speed;
        public float WorkingTime;
        public float RestingTime;
        public Transform transformTargetWork;
        public Transform TransformTargetHome;
    }
}