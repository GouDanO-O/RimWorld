using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	public class UI_MenuData : UIPanelData
	{

	}
	public partial class UI_Menu : UIPanel
	{
		protected Button StartGameButton;

		protected Button ContinuteGameButton;

		protected Button SettingButton;

		protected Button ExitGameButton;


        protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UI_MenuData ?? new UI_MenuData();
            // please add init code here

            StartGameButton=transform.Find("StartGameButton").GetComponent<Button>();
            ContinuteGameButton = transform.Find("ContinuteGameButton").GetComponent<Button>();
            SettingButton = transform.Find("SettingButton").GetComponent<Button>();
            ExitGameButton = transform.Find("ExitGameButton").GetComponent<Button>();

			StartGameButton.onClick.AddListener(TryStartGame);
            ContinuteGameButton.onClick.AddListener(TryContinuteGame);
            SettingButton.onClick.AddListener(TrySettingButton);
            ExitGameButton.onClick.AddListener(TryExitGame);
        }
		
		protected override void OnOpen(IUIData uiData = null)
		{

		}
		
		protected override void OnShow()
		{

		}
		
		protected override void OnHide()
		{

		}
		
		protected override void OnClose()
		{

		}

		/// <summary>
		/// 尝试开始游戏
		/// </summary>
		protected void TryStartGame()
		{
			GameManager.Instance.StartGame();
		}

		/// <summary>
		/// 尝试继续游戏
		/// </summary>
		protected void TryContinuteGame()
		{

		}

		/// <summary>
		/// 尝试打开设置
		/// </summary>
		protected void TrySettingButton()
		{
			
		}

		/// <summary>
		/// 尝试退出游戏
		/// </summary>
		protected void TryExitGame()
		{

		}
	}
}
