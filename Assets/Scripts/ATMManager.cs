using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;
    
    // 기본 현금 및 잔액 과 현재 현금 및 잔액
    private int _defaultCash = 100000;
    public int currentCash = 100000;
    public int updatedCash;

    private int _defaulttBalance = 50000;
    public int currentBalance = 50000;
    public int updatedBalance;

    [SerializeField] private TextMeshProUGUI updatedCashText;
    [SerializeField] private TextMeshProUGUI updatedBalanceText;


    // 메인화면, 입금화면, 출금화면
    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    // 팝업 창
    [SerializeField] private GameObject popupMsgUI;

    private void Awake()
    {
        instance = this;
    }

    //Start is called before the first frame update
    void Start()
    {
        // 기본 현금과 잔액 설정..?
        _defaultCash = 100000;
        _defaulttBalance = 50000;

    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    private void Deposit(int money) // 입금
    {
        // TODO 팝업창 띄우기
        if (updatedCash < money) // 현재 보유 현금보다 더 많이 입금하려고 하면
        {
            ShowWarning();// 에러 팝업 메세지 띄우기
        }

        currentCash -= money;
        currentBalance += money;

        // cash 와 balance 업데이트하고
        UpdateCash();
        UpdateBalance();

        // 업데이트한 cash 와 balance 보여주기
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
    private void Withdraw(int money) // 출금
    {
        // TODO 팝업창 띄우기
        if (currentBalance < money) // 현재 잔액보다 더 많이 출금하려고 하면
        {
            ShowWarning();// 에러 팝업 메세지 띄우기
        }

        currentBalance -= money;
        currentCash += money;

        // cash 와 balance 업데이트하고
        UpdateCash();
        UpdateBalance();

        // 업데이트한 cash 와 balance 보여주기
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
        // 현재 보유 현금을 updatedCash 로 옮기기
        updatedCash = currentCash;
    }

    private void ShowUpdatedCash()
    {
        // Cash 의 text 가져와서
        updatedCashText.text = updatedCash.ToString();
    }

    private void UpdateBalance()
    {
        // 현재 잔액을 updatedBalance 로 옮기기
        updatedBalance = currentBalance;

    }

    private void ShowUpdatedBalance()
    {
        // Balance 의 text 가져와서 연동
        updatedBalanceText.text = updatedBalance.ToString();

    }

    // TODO Input Field 버튼

    //뒤로가기 버튼
    public void Cancel()
    {
        // 뒤로가기 버튼 누르면 메인UI화면으로
        mainButtonUI.SetActive(true);
        depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(false);
    }

    private void ShowWarning() // "잔액이 부족합니다" 팝업
    {
        //팝업 활성화
        popupMsgUI.SetActive(true);
    }

    public void ClickPopupOkBtn() // 버튼 누르면 팝업 닫기
    {
        popupMsgUI.SetActive(false);
    }

}
