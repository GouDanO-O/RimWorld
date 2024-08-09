using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	// Generate Id:b66d308e-105a-4ae7-99c4-fa4bda9380ca
	public partial class UI_Game_Inspector
	{
		public const string Name = "UI_Game_Inspector";
		
		
		private UI_Game_InspectorData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			
			mData = null;
		}
		
		public UI_Game_InspectorData Data
		{
			get
			{
				return mData;
			}
		}
		
		UI_Game_InspectorData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UI_Game_InspectorData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
