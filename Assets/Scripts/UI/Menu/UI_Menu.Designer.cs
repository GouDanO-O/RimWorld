using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	// Generate Id:ac5942ed-ac62-45f7-b4ee-bf1d6aabdc44
	public partial class UI_Menu
	{
		public const string Name = "UI_Menu";
		
		
		private UI_MenuData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			
			mData = null;
		}
		
		public UI_MenuData Data
		{
			get
			{
				return mData;
			}
		}
		
		UI_MenuData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UI_MenuData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
