using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;
    
    // ���ݰ� �ܾ�
    private int currentCash = 100000;
    private int currentBalance = 50000;

    //[SerializeField] private TextMeshProUGUI updatedCashText;
    //[SerializeField] private TextMeshProUGUI updatedBalanceText;
    [SerializeField] private TMP_Text CashText;
    [SerializeField] private TMP_Text BalanceText;


    // ����ȭ��, �Ա�ȭ��, ���ȭ��
    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    // �˾� â
    [SerializeField] private GameObject popupMsgUI;

    // Input Field
    [SerializeField] private TMP_InputField depositInputField;
    [SerializeField] private TMP_InputField withdrawalInputField;


    private void Awake()
    {
        instance = this;
    }

    //Start is called before the first frame update
    //void Start()
    //{
        
    //
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}


    private void Deposit(int money) // �Ա�
    {

        if (money <= currentCash)
        {
            currentCash -= money;
            currentBalance += money;

            UpdateCashAndBalance();

        }
        else // (money > currentCash) ���� ���� ���ݺ��� �� ���� �Ա��Ϸ��� �ϸ�
        {
            ShowWarning();

        }
    }

    public void Deposit1()
    {
        Deposit(10000);
    }
    public void Deposit3()
    {
        Deposit(30000);
    }
    public void Deposit5()
    {
        Deposit(50000);
    }

    public void DepositByInputField()
    {
        Deposit(int.Parse(depositInputField.text));
    }
    
    private void Withdraw(int money) // ���
    {

        if (money <= currentBalance)
        {
            currentBalance -= money;
            currentCash += money;

            UpdateCashAndBalance();

        }
        else // (money > currentCash) ���� ���� ���ݺ��� �� ���� �Ա��Ϸ��� �ϸ�
        {
            ShowWarning();
        }

    }

    public void Withdraw1()
    {
        Withdraw(10000);
    }
    public void Withdraw3()
    {
        Withdraw(30000);
    }
    public void Withdraw5()
    {
        Withdraw(50000);
    }

    public void WithdrawtByInputField()
    {
        Withdraw(int.Parse(withdrawalInputField.text));
    }

    private void UpdateCashAndBalance()
    {
        CashText.text = currentCash.ToString();
        BalanceText.text = currentBalance.ToString();

    }

    //�ڷΰ��� ��ư
    public void Cancel()
    {
        mainButtonUI.SetActive(true);
        depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(false);
    }

    private void ShowWarning() // "�ܾ��� �����մϴ�" �˾�
    {
        popupMsgUI.SetActive(true);
    }

    public void ClickPopupOkBtn() // ��ư ������ �˾� �ݱ�
    {
        popupMsgUI.SetActive(false);
    }

}
