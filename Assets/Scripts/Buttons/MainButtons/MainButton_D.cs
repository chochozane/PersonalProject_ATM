using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButton_D : MonoBehaviour
{
    //[SerializeField] private Button depositButton;
    //[SerializeField] private Button withdrawalButton;

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

    public void ClickDepositButton()
    {
        mainButtonUI.SetActive(false);
        depositButtonUI.SetActive(true);
        withdrawalButtonUI.SetActive(false);
    }
}
