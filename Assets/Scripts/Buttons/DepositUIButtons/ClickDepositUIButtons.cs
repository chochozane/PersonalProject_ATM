using UnityEngine;

public class ClickDepositUIButtons : MonoBehaviour
{
 
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

    public void ClickBackButton()
    {
        ATMManager.instance.Back();
    }
}
