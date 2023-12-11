using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D_ButtonsControl : MonoBehaviour
{
    // 현금 text 와 Balance(잔액) text
    [SerializeField] private TextMeshProUGUI currentCashText;
    [SerializeField] private TextMeshProUGUI currentBalanceText;
    //[SerializeField] private TextMeshProUGUI updatedCashText;

    private int currentCash = 100000;
    private int currentBalance = 50000;

    [SerializeField] private GameObject mainButtonUI;
    [SerializeField] private GameObject depositButtonUI;
    [SerializeField] private GameObject withdrawalButtonUI;

    [SerializeField] private TMP_InputField depositInputField;

    [SerializeField] private GameObject popupMsgUI;



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
        currentCash -= 10000;
        currentCashText.text = currentCash.ToString();
        currentBalance += 10000;
        currentBalanceText.text = currentBalance.ToString();

        // TODO 팝업창 띄우기
        if(int.Parse(currentCashText.text) < 0)
        {
            ShowWarning();
        }
    }


    public void ClickButton3()
    {
        currentCash -= 30000;
        currentCashText.text = currentCash.ToString();
        currentBalance += 30000;
        currentBalanceText.text = currentBalance.ToString();
        //currentCashText.text = (currentCash - 30000).ToString();
        //currentBalanceText.text = (currentBalance + 30000).ToString();
    }

    public void ClickButton5()
    {
        currentCash -= 50000;
        currentCashText.text = currentCash.ToString();
        currentBalance += 50000;
        currentBalanceText.text = currentBalance.ToString();
        //currentCashText.text = (currentCash - 50000).ToString();
        //currentBalanceText.text = (currentBalance + 50000).ToString();
    }

    // 직접입력버튼
    public void InputD()
    {
        currentCash -= int.Parse(depositInputField.text);
        currentCashText.text = currentCash.ToString();

        currentBalance += int.Parse(depositInputField.text);
        currentBalanceText.text = currentBalance.ToString();
    }
    public void ClickCancelButton()
    {
        // 혹시나 추후에 기능구현 하다가 변동된 값이 Cancel 버튼 누르면 초기화 되는경우, 그냥 SetActive 로 진행하자 !
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        mainButtonUI.SetActive(true);
        depositButtonUI.SetActive(false);
        //withdrawalButtonUI.SetActive(false);
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
