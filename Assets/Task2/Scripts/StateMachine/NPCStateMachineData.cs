using UnityEngine;
using System;

namespace Task2.StateMachine
{
    [Serializable]
    public class NPCStateMachineData
    {
        [field: SerializeField] public Transform TransformTargetWork { get; private set; }
        [field: SerializeField] public Transform TransformTargetHome { get; private set; }
    }
}