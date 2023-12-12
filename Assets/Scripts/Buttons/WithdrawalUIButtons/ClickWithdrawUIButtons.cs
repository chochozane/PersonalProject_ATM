using UnityEngine;

public class ClickWithdrawUIButtons : MonoBehaviour
{
 
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
