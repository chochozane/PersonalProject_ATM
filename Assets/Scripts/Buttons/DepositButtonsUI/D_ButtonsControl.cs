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

    private int currentCash = 100000;
    private int currentBalance = 50000;



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
        currentCashText.text = (currentCash - 10000).ToString();
        currentBalanceText.text = (currentBalance + 10000).ToString();
    }

    public void ClickCancelButton()
    {
        // 혹시나 추후에 기능구현 하다가 변동된 값이 Cancel 버튼 누르면 초기화 되는경우, 그냥 SetActive 로 진행하자 !
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
