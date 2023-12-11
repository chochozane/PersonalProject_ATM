using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W_ButtonsControl : MonoBehaviour
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
        print("버튼1 눌림");
        currentCashText.text = (currentCash + 10000).ToString();
        currentBalanceText.text = (currentBalance - 10000).ToString();
        /* 
         * 버튼 클릭할 때마다 계속 작동되도록 하려면 어떻게 해야할까
         * currentCashText 또는 currentCash 를 update 해줘서 ..
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

    // TODO 직접입력버튼

    public void ClickCancelButton()
    {
        // 혹시나 추후에 기능구현 하다가 변동된 값이 Cancel 버튼 누르면 초기화 되는경우, 그냥 SetActive 로 진행하자 !
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        mainButtonUI.SetActive(true);
        //depositButtonUI.SetActive(false);
        withdrawalButtonUI.SetActive(false);

    }
}
