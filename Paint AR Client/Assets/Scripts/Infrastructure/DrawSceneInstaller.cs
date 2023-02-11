﻿using ArPaint.Infrastructure.GameStates;
using ArPaint.Input;
using ArPaint.Services.Commands;
using UnityEngine.XR.ARFoundation;
using Zenject;

namespace ArPaint.Infrastructure
{
    public class DrawSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ARPlaneManager>().FromComponentInHierarchy().AsSingle();
            Container.Bind<ARAnchorManager>().FromComponentInHierarchy().AsSingle();
            Container.Bind<DrawActions>().AsSingle();
            Container.Bind<ICommandBuffer>().To<CommandBuffer>().AsSingle();
            Container.BindFactory<ArInitState, ArInitState.Factory>();
            Container.BindFactory<DrawState, DrawState.Factory>();
            Container.BindInterfacesAndSelfTo<DrawSceneBootstrap>().AsSingle().NonLazy();
        }
    }
}