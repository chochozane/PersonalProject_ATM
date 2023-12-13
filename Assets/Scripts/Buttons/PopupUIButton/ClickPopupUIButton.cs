using UnityEngine;

public class ClickPopupUIButton : MonoBehaviour
{

    [SerializeField] private GameObject popupMsgUICanvas;

    public void ClickPopupOkBtn()
    {
        popupMsgUICanvas.SetActive(false);
    }
}
