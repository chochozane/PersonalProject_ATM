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
        // Ȥ�ó� ���Ŀ� ��ɱ��� �ϴٰ� ������ ���� Cancel ��ư ������ �ʱ�ȭ �Ǵ°��, �׳� SetActive �� �������� !
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
