using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D_ButtonsControl : MonoBehaviour
{
    // 현금 text 와 Balance(잔액) text
    [SerializeField] private TextMeshProUGUI currentCashText;
    [SerializeField] private TextMeshProUGUI currentBalanceText;

    private int currentCash = 100000;
    private int currentBalance = 50000;

    [SerializeField] private TMP_InputField depositInputField;


    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void ClickButton1()
    {
        ATMManager.instance.Deposit1();                
    }

    public void ClickButton3()
    {
        ATMManager.instance.Deposit3();
    }

    public void ClickButton5()
    {

        ATMManager.instance.Deposit5();
    }

    // TODO 직접입력버튼
    public void InputD()
    {
        currentCash -= int.Parse(depositInputField.text);
        currentCashText.text = currentCash.ToString();

        currentBalance += int.Parse(depositInputField.text);
        currentBalanceText.text = currentBalance.ToString();
    }

    public void ClickCancelButton()
    {
        ATMManager.instance.Cancel();
    }

}
