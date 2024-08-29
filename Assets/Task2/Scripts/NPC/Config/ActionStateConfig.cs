using System;
using UnityEngine;

namespace Task2.Config
{
    [Serializable]
    public class ActionStateConfig
    {
        [field: SerializeField, Range(0, 100)] public float WorkingTime { get; private set; }
        [field: SerializeField, Range(0, 100f)] public float SleepingTime { get; private set; }
    }
}
