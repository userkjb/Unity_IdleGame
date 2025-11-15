using UnityEngine;
using UnityEngine.UI;

public class ButtonClickEvent : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // 자식들은 해당 함수를 override 해서 사용하면 됨.
    public virtual void OnButtonClick(){}
}
