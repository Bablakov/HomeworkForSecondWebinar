using Task2.NPC.StateMachine;
using UnityEngine;
using Zenject;

namespace Task2.Services
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private NPC.NPC _npc;
        [SerializeField] private NPCStateMachineData _npcStateMachineData;

        public override void InstallBindings()
        {
            BindStateMachineData();
            BindNPC();
            BindStateMachine();
            BindStatesFactory();
        }

        private void BindStateMachineData() =>
            Container.BindInterfacesAndSelfTo<NPCStateMachineData>().FromInstance(_npcStateMachineData);

        private void BindNPC() =>
            Container.BindInterfacesAndSelfTo<NPC.NPC>().FromInstance(_npc);

        private void BindStateMachine() =>
            Container.BindInterfacesAndSelfTo<NPCStateMachine>().AsSingle();

        private void BindStatesFactory() =>
            Container.BindInterfacesAndSelfTo<StatesFactory>().AsSingle();
    }
}