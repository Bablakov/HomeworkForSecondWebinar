using UnityEngine;

namespace Task2.NPC.Config
{
    [CreateAssetMenu(menuName = "Configs/NPCConfig", fileName = "NPCConfig")]
    public class NPCConfig : ScriptableObject
    {
        [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
        [field: SerializeField, Range(0, 100)] public float WorkingTime { get; private set; }
        [field: SerializeField, Range(0, 100)] public float RestingTime { get; private set; }
    }
}