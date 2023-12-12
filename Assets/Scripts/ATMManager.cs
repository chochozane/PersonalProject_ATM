using TMPro;
using UnityEngine;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;
    
    // ���� �� ������Ʈ ���ݰ� �ܾ�
    private int currentCash = 100000;
    private int updatedCash = 100000;
    private int currentBalance = 50000;
    private int updatedBalance = 50000;

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

        if (money <= updatedCash)
        {
            currentCash -= money;
            currentBalance += money;

            UpdateCashAndBalance();
            ShowUpdatedCashAndBalance();
        }
        else // (money > updatedCash) ���� ���� ���ݺ��� �� ���� �Ա��Ϸ��� �ϸ�
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

        if (money <= updatedBalance)
        {
            currentBalance -= money;
            currentCash += money;

            UpdateCashAndBalance();
            ShowUpdatedCashAndBalance();
        }
        else // (money > updatedBalance) ���� ���� �ܾ׺��� �� ���� ����Ϸ��� �ϸ�
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
        updatedCash = currentCash;
        updatedBalance = currentBalance;
    }

    private void ShowUpdatedCashAndBalance()
    {
        CashText.text = updatedCash.ToString();
        BalanceText.text = updatedBalance.ToString();
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
