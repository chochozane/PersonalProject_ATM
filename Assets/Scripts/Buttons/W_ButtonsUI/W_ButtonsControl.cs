using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W_ButtonsControl : MonoBehaviour
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton1()
    {
        print("��ư1 ����");
        currentCashText.text = (currentCash + 10000).ToString();
        currentBalanceText.text = (currentBalance - 10000).ToString();
        /* 
         * ��ư Ŭ���� ������ ��� �۵��ǵ��� �Ϸ��� ��� �ؾ��ұ�
         * currentCashText �Ǵ� currentCash �� update ���༭ ..
         */
    }

    //public void UpdateCash()
    //{

    //}

    public void ClickButton3()
    {
        currentCashText.text = (currentCash + 30000).ToString();
        currentBalanceText.text = (currentBalance - 30000).ToString();
    }

    public void ClickButton5()
    {
        currentCashText.text = (currentCash + 50000).ToString();
        currentBalanceText.text = (currentBalance - 50000).ToString();
    }

    // TODO �����Է¹�ư

    public void ClickCancelButton()
    {
        // Ȥ�ó� ���Ŀ� ��ɱ��� �ϴٰ� ������ ���� Cancel ��ư ������ �ʱ�ȭ �Ǵ°��, �׳� SetActive �� �������� !
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        mainButtonUI.SetActive(true);
        //depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(false);

    }
}
