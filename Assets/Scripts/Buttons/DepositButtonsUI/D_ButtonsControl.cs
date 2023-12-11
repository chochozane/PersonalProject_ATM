using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D_ButtonsControl : MonoBehaviour
{
    // ���� text �� Balance(�ܾ�) text
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

        // TODO �˾�â ����
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

    // �����Է¹�ư
    public void InputD()
    {
        currentCash -= int.Parse(depositInputField.text);
        currentCashText.text = currentCash.ToString();

        currentBalance += int.Parse(depositInputField.text);
        currentBalanceText.text = currentBalance.ToString();
    }
    public void ClickCancelButton()
    {
        // Ȥ�ó� ���Ŀ� ��ɱ��� �ϴٰ� ������ ���� Cancel ��ư ������ �ʱ�ȭ �Ǵ°��, �׳� SetActive �� �������� !
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        mainButtonUI.SetActive(true);
        depositButtonUI.SetActive(false);
        //withdrawalButtonUI.SetActive(false);
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
