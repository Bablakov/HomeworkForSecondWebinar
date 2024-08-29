using System;
using UnityEngine;

namespace Task2.Config
{
    [Serializable]
    public class MovementStateConfig
    {
        [field: SerializeField, Range(0, 10)] public float SpeedGoingHome { get; private set; }
        [field: SerializeField, Range(0, 10)] public float SpeedGoingWork { get; private set; }
        [field: SerializeField, Range(0, 1)] public float FinishingDistance { get; private set; }
    }
}
