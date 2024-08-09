using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	public class UI_LoadingData : UIPanelData
	{
	}
	public partial class UI_Loading : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UI_LoadingData ?? new UI_LoadingData();
			// please add init code here
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
	}
}
