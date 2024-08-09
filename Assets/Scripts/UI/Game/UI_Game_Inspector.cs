using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	public class UI_Game_InspectorData : UIPanelData
	{
	}
	public partial class UI_Game_Inspector : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UI_Game_InspectorData ?? new UI_Game_InspectorData();
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
