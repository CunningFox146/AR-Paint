using ArPaint.Infrastructure.SceneManagement;
using Services.StaticData;
using UnityEngine;
using Zenject;

namespace ArPaint.Infrastructure.GameStates
{
    public class BootstrapState : IEnterState
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly IStaticDataService _staticData;

        public BootstrapState(ISceneLoader sceneLoader, IStaticDataService staticData)
        {
            _sceneLoader = sceneLoader;
            _staticData = staticData;
        }

        public async void OnEnter()
        {
            Application.targetFrameRate = 300;
            await _staticData.Load();
            await _sceneLoader.LoadScene(SceneIndex.Draw);
        }

        public class Factory : PlaceholderFactory<BootstrapState>
        {
        }
    }
}