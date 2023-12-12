using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ATMManager : MonoBehaviour
{
    public static ATMManager instance;
    
    // 기본 현금 및 잔액 과 현재 현금 및 잔액
    //private int _defaultCash = 100000;
    private int currentCash = 100000;
    private int updatedCash = 100000;

    //private int _defaulttBalance = 50000;
    private int currentBalance = 50000;
    private int updatedBalance = 50000;

    //[SerializeField] private Text updatedCashText;
    //[SerializeField] private Text updatedBalanceText;
    [SerializeField] private TextMeshProUGUI updatedCashText;
    [SerializeField] private TextMeshProUGUI updatedBalanceText;


    // 메인화면, 입금화면, 출금화면
    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    // 팝업 창
    [SerializeField] private GameObject popupMsgUI;

    // Input Field
    [SerializeField] private TMP_InputField depositInputField;
    [SerializeField] private TMP_InputField withdrawalInputField;

    // 


    private void Awake()
    {
        instance = this;
    }

    //Start is called before the first frame update
    void Start()
    {
        // 기본 현금과 잔액 설정..?
        //_defaultCash = 100000;
        //_defaulttBalance = 50000;

    }

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}

    //private void CheckBeforeDeposit() // 입금 전 체크
    //{
    //    if (int.Parse(updatedCashText.text) < 0) // 보유 현금보다 입금 금액이 더 많은 경우
    //    {
    //        ShowWarning(); // 에러 팝업 메세지 띄우기
    //    }
    //}

    private void Deposit(int money) // 입금
    {
        /* 
         * TODO 팝업창 띄우기
         * 검사하자
         * e.g.
         * Check()
        */

        //if (money > updatedCash) // 현재 보유 현금보다 더 많이 입금하려고 하면
        //{
        //    ShowWarning();// 에러 팝업 메세지 띄우기
        //}
        //CheckBeforeDeposit();

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

    public void DepositByInputField()
    {
        Deposit(int.Parse(depositInputField.text));
    }
    
    private void Withdraw(int money) // 출금
    {
        // TODO 팝업창 띄우기
        if (currentBalance < int.Parse(updatedCashText.text)) // 현재 잔액보다 더 많이 출금하려고 하면
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

    public void WithdrawtByInputField()
    {
        Withdraw(int.Parse(withdrawalInputField.text));
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
