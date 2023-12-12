using UnityEngine;

public class ClickMainUIButtons : MonoBehaviour
{
    
    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    public void ClickDepositButton()
    {
        mainButtonUI.SetActive(false);
        depositButtonUI.SetActive(true);
    }

    public void ClickWithdrawalButton()
    {
        mainButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(true);
    }
}
