using System;
using UnityEngine;
using UnityEngine.UI;
using Assets.SimpleLocalization.Scripts;

namespace Assets.SimpleLocalization
{
	/// <summary>
	
	/// </summary>
	public class LocalizationSwitch : MonoBehaviour
	{

		/// <summary>
		/// Called on app start.
		/// </summary>
		public void Awake()
		{
			LocalizationManager.Read();

			switch (Application.systemLanguage)
			{
				case SystemLanguage.German:
					LocalizationManager.Language = "German";
					break;
                case SystemLanguage.French:
					LocalizationManager.Language = "French";
					break;
                case SystemLanguage.Spanish:
					LocalizationManager.Language = "Spanish";
					break;
                case SystemLanguage.Italian:
					LocalizationManager.Language = "Italian";
					break;
                case SystemLanguage.Chinese:
					LocalizationManager.Language = "Chinese";
					break;
                case SystemLanguage.Japanese:
					LocalizationManager.Language = "Japanese";
					break;
                case SystemLanguage.Korean:
					LocalizationManager.Language = "Korean";
					break;
				case SystemLanguage.Russian:
					LocalizationManager.Language = "Russian";
					break;
				default:
					LocalizationManager.Language = "English";
					break;
			}
        }

		/// <summary>
		/// Change localization at runtime.
		/// </summary>
		public void SetLocalization(string localization)
		{
			LocalizationManager.Language = localization;
		}

		/// <summary>
		/// Write a review.
		/// </summary>
		public void Review()
		{
			Application.OpenURL("https://www.assetstore.unity3d.com/#!/content/120113");
		}
	}
}