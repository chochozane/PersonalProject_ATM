using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;
    
    // �⺻ ���� �� �ܾ� �� ���� ���� �� �ܾ�
    private int _defaultCash = 100000;
    public int currentCash = 100000;
    public int updatedCash;

    private int _defaulttBalance = 50000;
    public int currentBalance = 50000;
    public int updatedBalance;

    [SerializeField] private TextMeshProUGUI updatedCashText;
    [SerializeField] private TextMeshProUGUI updatedBalanceText;


    // ����ȭ��, �Ա�ȭ��, ���ȭ��
    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    // �˾� â
    [SerializeField] private GameObject popupMsgUI;

    private void Awake()
    {
        instance = this;
    }

    //Start is called before the first frame update
    void Start()
    {
        // �⺻ ���ݰ� �ܾ� ����..?
        _defaultCash = 100000;
        _defaulttBalance = 50000;

    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    private void Deposit(int money) // �Ա�
    {
        // TODO �˾�â ����
        if (updatedCash < money) // ���� ���� ���ݺ��� �� ���� �Ա��Ϸ��� �ϸ�
        {
            ShowWarning();// ���� �˾� �޼��� ����
        }

        currentCash -= money;
        currentBalance += money;

        // cash �� balance ������Ʈ�ϰ�
        UpdateCash();
        UpdateBalance();

        // ������Ʈ�� cash �� balance �����ֱ�
        ShowUpdatedCash();
        ShowUpdatedBalance();

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
    private void Withdraw(int money) // ���
    {
        // TODO �˾�â ����
        if (currentBalance < money) // ���� �ܾ׺��� �� ���� ����Ϸ��� �ϸ�
        {
            ShowWarning();// ���� �˾� �޼��� ����
        }

        currentBalance -= money;
        currentCash += money;

        // cash �� balance ������Ʈ�ϰ�
        UpdateCash();
        UpdateBalance();

        // ������Ʈ�� cash �� balance �����ֱ�
        ShowUpdatedCash();
        ShowUpdatedBalance();
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

    private void UpdateCash()
    {
        // ���� ���� ������ updatedCash �� �ű��
        updatedCash = currentCash;
    }

    private void ShowUpdatedCash()
    {
        // Cash �� text �����ͼ�
        updatedCashText.text = updatedCash.ToString();
    }

    private void UpdateBalance()
    {
        // ���� �ܾ��� updatedBalance �� �ű��
        updatedBalance = currentBalance;

    }

    private void ShowUpdatedBalance()
    {
        // Balance �� text �����ͼ� ����
        updatedBalanceText.text = updatedBalance.ToString();

    }

    // TODO Input Field ��ư

    //�ڷΰ��� ��ư
    public void Cancel()
    {
        // �ڷΰ��� ��ư ������ ����UIȭ������
        mainButtonUI.SetActive(true);
        depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(false);
    }

    private void ShowWarning() // "�ܾ��� �����մϴ�" �˾�
    {
        //�˾� Ȱ��ȭ
        popupMsgUI.SetActive(true);
    }

    public void ClickPopupOkBtn() // ��ư ������ �˾� �ݱ�
    {
        popupMsgUI.SetActive(false);
    }

}
