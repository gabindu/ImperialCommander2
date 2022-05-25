﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Saga
{
	public class SagaLanguageController : MonoBehaviour
	{
		public Text endRoundBtn, roundHeading, onslaughtDeploy, landingDeploy1, landingDeploy2, fameHeading, awardsHeading, fameContinueBtn, depTypeHeading, eventHeading, eventContinueBtn, deploymentContinueBtn, activateContinueBtn;

		public TextMeshProUGUI fameItem1UC, fameItem2UC, fame1UC, fame2UC, onslaughtIncreasedUC, landingIncreasedUC, reinforceIncreasedUC, reinforceWarningUC, deploymentWarningUC, depWarningUC, calmMessageUC;

		public void SetTranslatedUI()
		{
			//SagaMainApp ui = DataStore.uiLanguage.sagaMainApp;


			UIMainApp uiMain = DataStore.uiLanguage.uiMainApp;

			fameContinueBtn.text = uiMain.continueBtn;
			deploymentContinueBtn.text = uiMain.continueBtn;
			activateContinueBtn.text = uiMain.continueBtn;
			eventContinueBtn.text = uiMain.continueBtn;

			fameHeading.text = uiMain.fameHeading;
			awardsHeading.text = uiMain.awardsHeading;
			fame1UC.text = uiMain.fame1UC;
			fame2UC.text = uiMain.fame2UC;
			fame1UC.text = uiMain.fame1UC;
			fame2UC.text = uiMain.fame2UC;

			onslaughtDeploy.text = uiMain.deploy;
			landingDeploy2.text = uiMain.deploy;
			landingDeploy1.text = uiMain.deploy;
			landingDeploy2.text = uiMain.deploy;

			roundHeading.text = uiMain.roundHeading;
			endRoundBtn.text = uiMain.endRoundBtn;
		}
	}
}
