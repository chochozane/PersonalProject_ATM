using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //[SerializeField] private GameObject mainButtonUI;
    //[SerializeField] private GameObject depositButtonUI;
    //[SerializeField] private GameObject withdrawalButtonUI;

    //public int currentCash = 100000;
    //public int currentBalance = 50000;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //mainButtonUI.SetActive(true);
        //depositButtonUI.SetActive(false);
        //withdrawalButtonUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
