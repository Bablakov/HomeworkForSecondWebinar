using Task2.StateMachine;
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
            Container.BindInterfacesAndSelfTo<NPCStateMachineData>().FromInstance(_npcStateMachineData);
            Container.BindInterfacesAndSelfTo<NPC.NPC>().FromInstance(_npc);
            Container.BindInterfacesAndSelfTo<NPCStateMachine>().AsSingle();
            Container.BindInterfacesAndSelfTo<StatesFactory>().AsSingle();
        }
    }
}