using QFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RimWorld
{
    public class ToolLists : MonoSingleton<ToolLists>,IUtility
    {
        /// <summary>
        /// 异步生成UI
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="level"></param>
        public void SpawnUI_Async<T>(UILevel level, Action complete) where T : UIPanel
        {
            StartCoroutine(IemSpawnUI_Async<T>(level, complete));
        }

        protected IEnumerator IemSpawnUI_Async<T>(UILevel level,Action complete) where T : UIPanel
        {
            yield return UIKit.OpenPanelAsync<T>(level);
            complete?.Invoke();
        }

        /// <summary>
        /// 将秒转换成时分秒
        /// </summary>
        /// <param name="totalSeconds"></param>
        /// <returns></returns>
        public string ConvertToTimeFormat(float totalSeconds)
        {
            int hours = Mathf.FloorToInt(totalSeconds / 3600);
            int minutes = Mathf.FloorToInt((totalSeconds % 3600) / 60);
            int seconds = Mathf.FloorToInt(totalSeconds % 60);

            return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        /// <summary>
        /// 开始一个协程
        /// </summary>
        /// <param name="routine"></param>
        /// <returns></returns>
        public static Coroutine StartRoutine(IEnumerator routine)
        {
            return Instance.StartCoroutine(routine);
        }

        // 停止协程
        public static void StopRoutine(Coroutine coroutine)
        {
            if (coroutine != null)
            {
                Instance.StopCoroutine(coroutine);
            }
        }

        // 停止所有协程
        public static void StopAllRoutines()
        {
            Instance.StopAllCoroutines();
        }
    }
}

