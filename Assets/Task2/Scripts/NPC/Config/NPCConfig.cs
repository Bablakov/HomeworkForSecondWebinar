using UnityEngine;

namespace Task2.NPC.Config
{
    [CreateAssetMenu(menuName = "Configs/NPCConfig", fileName = "NPCConfig")]
    public class NPCConfig : ScriptableObject
    {
        [field: SerializeField] public ActionStateConfig ActionStateConfig { get; private set; }
        [field: SerializeField] public MovementStateConfig MovementStateConfig { get; private set; }
    }
}