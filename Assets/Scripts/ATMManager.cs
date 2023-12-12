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
    private int _defaulttBalance = 50000;
    public int currentBalance = 50000;

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

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    private void Deposit(int money) // 입금
    {
        if(currentCash < money) // 현재 보유 현금보다 더 많이 입금하려고 하면
        {
            ShowWarning();// 에러 팝업 메세지 띄우기
        }

        currentCash -= money;
        currentBalance += money;
    }

    private void Withdraw(int money) // 출금
    {
        if(currentBalance < money) // 현재 잔액보다 더 많이 출금하려고 하면
        {
            ShowWarning();// 에러 팝업 메세지 띄우기
        }
        currentBalance -= money;
        currentCash += money;
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
        Deposit(10000);
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

    public void ClickCancelButton()
    {
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
