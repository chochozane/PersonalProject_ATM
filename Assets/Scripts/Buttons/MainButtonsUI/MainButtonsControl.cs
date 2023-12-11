using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonsControl : MonoBehaviour
{
    //[SerializeField] private Button depositButton;
    //[SerializeField] private Button withdrawalButton;

    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    public void ClickDepositButton()
    {
        mainButtonUI.SetActive(false);
        depositButtonUI.SetActive(true);
        withdrawalButtonUI.SetActive(false);
    }

    public void ClickWithdrawalButton()
    {
        mainButtonUI.SetActive(false);
        depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(true);
    }
}
