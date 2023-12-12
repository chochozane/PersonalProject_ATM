using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDepositUIButtons : MonoBehaviour
{
 
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

    public void ClickDepositInputFieldButton()
    {
        ATMManager.instance.DepositByInputField();
    }

    public void ClickCancelButton()
    {
        ATMManager.instance.Cancel();
    }

}
