using UnityEngine;
using System;

namespace Task2.NPC.StateMachine
{
    [Serializable]
    public class NPCStateMachineData
    {
        [field: SerializeField] public Transform TargetWork { get; private set; }
        [field: SerializeField] public Transform TargetHome { get; private set; }
    }
}