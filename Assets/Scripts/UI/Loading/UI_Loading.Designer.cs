using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace RimWorld.UI
{
	// Generate Id:de8a5725-89b0-4c98-adc6-4cc99dcd4322
	public partial class UI_Loading
	{
		public const string Name = "UI_Loading";
		
		
		private UI_LoadingData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			
			mData = null;
		}
		
		public UI_LoadingData Data
		{
			get
			{
				return mData;
			}
		}
		
		UI_LoadingData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UI_LoadingData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
