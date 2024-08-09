using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace RimWorld
{
    /// <summary>
    /// 场景名称
    /// </summary>
    public enum ESceneName : byte
    {
        Menu=1,
        GameScene=2
    }

    public class SceneLoader
    {
        public UnityAction<ESceneName> onLoadScene;

        public UnityAction OnSceneLoadStart;
        public UnityAction<float> OnSceneLoading;
        public UnityAction<ESceneName> OnSceneLoadComplete;


        public SceneLoader()
        {
            onLoadScene += LoadSceneAsync;
        }

        /// <summary>
        /// 异步加载场景
        /// </summary>
        /// <param name="sceneName"></param>
        public void LoadSceneAsync(ESceneName sceneName)
        {
            ToolLists.Instance.StartCoroutine(LoadSceneCoroutine(sceneName));
        }

        private IEnumerator LoadSceneCoroutine(ESceneName sceneName)
        {
            // 触发开始加载事件
            OnSceneLoadStart?.Invoke();

            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync((int)sceneName);

            // 场景异步加载的过程中，我们可以通过 asyncOperation.progress 获取进度
            while (!asyncOperation.isDone)
            {
                // 触发加载中事件，并传递当前进度
                OnSceneLoading?.Invoke(asyncOperation.progress);
                yield return null;
            }

            // 场景加载完毕
            OnSceneLoadComplete?.Invoke(sceneName);
        }
    }
}

