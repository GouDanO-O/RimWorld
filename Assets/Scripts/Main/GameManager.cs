using QFramework;
using RimWorld.Mission;
using RimWorld.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RimWorld
{
    public class GameManager : MonoSingleton<GameManager>
    {
        protected SceneLoader sceneLoader;

        private void Awake()
        {
            Init();
            DontDestroyOnLoad(gameObject); 
        }

        private void Start()
        {
            
        }

        private void FixedUpdate()
        {

        }

        private void Update()
        {

        }

        private void LateUpdate()
        {

        }

        private void OnDisable()
        {

        }

        private void OnDestroy()
        {
            UnRegistEvent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        protected void Init()
        {
            RegistEvent();
            LoadData();
            InitComponent();
            UIRoot.Instance.OnSingletonInit();
            EnterMenu();
        }

        /// <summary>
        /// 注册事件
        /// </summary>
        protected void RegistEvent()
        {
            
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        protected void LoadData()
        {
            
        }

        /// <summary>
        /// 初始化管理类和组件
        /// </summary>
        protected void InitComponent()
        {
            sceneLoader = new SceneLoader();
            sceneLoader.OnSceneLoadStart = LoadSceneStart;
            sceneLoader.OnSceneLoading = LoadingScene;
            sceneLoader.OnSceneLoadComplete = LoadSceneComplete;
        }

        /// <summary>
        /// 进入菜单
        /// </summary>
        protected void EnterMenu()
        {
            sceneLoader.LoadSceneAsync(ESceneName.Menu);
        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        public void StartGame()
        {
            sceneLoader.LoadSceneAsync(ESceneName.GameScene);
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        protected void UnRegistEvent()
        {
            
        }

        /// <summary>
        /// 开始加载场景
        /// </summary>
        protected void LoadSceneStart()
        {
            Debug.Log("开始加载场景");
        }

        /// <summary>
        /// 加载中
        /// </summary>
        /// <param name="progress"></param>
        protected void LoadingScene(float progress)
        {
            Debug.Log("加载场景中"+progress);
        }

        /// <summary>
        /// 加载场景结束
        /// </summary>
        protected void LoadSceneComplete(ESceneName sceneName)
        {
            if (sceneName == ESceneName.Menu)
            {
                
            }
            else if(sceneName == ESceneName.GameScene)
            {
                UIKit.ClosePanel<UI_Menu>();
            }

            Debug.Log("加载场景结束");
        }
    }
}

