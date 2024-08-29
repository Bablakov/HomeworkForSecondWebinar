using Assets.Task2.Scripts.StateMachine;
using Task2.NPC;
using Task2.StateMachine;
using UnityEngine;
using Zenject;

namespace Assets.Task2.Scripts.Services
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private NPC _npc;
        [SerializeField] private NPCStateMachineData _npcStateMachineData;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<NPCStateMachineData>().FromInstance(_npcStateMachineData);
            Container.BindInterfacesAndSelfTo<NPC>().FromInstance(_npc);
            Container.BindInterfacesAndSelfTo<NPCStateMachine>().AsSingle();
            Container.BindInterfacesAndSelfTo<StatesFactory>().AsSingle();
        }
    }
}