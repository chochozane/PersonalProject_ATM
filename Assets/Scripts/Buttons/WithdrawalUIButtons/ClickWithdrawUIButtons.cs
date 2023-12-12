using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickWithdrawUIButtons : MonoBehaviour
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
        ATMManager.instance.Withdraw1();
    }

    public void ClickButton3()
    {
        ATMManager.instance.Withdraw3();
    }

    public void ClickButton5()
    {
        ATMManager.instance.Withdraw5();                
    }

    public void ClickWithdrawInputFieldButton()
    {
        ATMManager.instance.WithdrawtByInputField();
    }
    
    public void ClickCancelButton()
    {
        ATMManager.instance.Cancel();

    }
}
