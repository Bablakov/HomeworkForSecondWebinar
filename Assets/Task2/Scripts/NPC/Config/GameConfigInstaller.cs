using UnityEngine;
using Zenject;

namespace Task2.NPC.Config
{
    [CreateAssetMenu(fileName = "GameConfigInstaller", menuName = "Configs/GameConfigInstaller")]
    public class GameConfigInstaller : ScriptableObjectInstaller<GameConfigInstaller>
    {
        [SerializeField] private NPCConfig _npcCofig;
        public override void InstallBindings()
        {
            BindNPCConfig();
        }

        private void BindNPCConfig() => 
            Container.Bind<NPCConfig>().FromInstance(_npcCofig);
    }
}