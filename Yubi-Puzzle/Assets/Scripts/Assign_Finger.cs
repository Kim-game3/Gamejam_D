using UnityEngine;

public class Assign_Finger : MonoBehaviour
{
    public bool isClick = false;

    public void OnFingerClicked()
    {
        if (isClick)
        {

        }
        else
        {
            isClick = true;
            Debug.Log($"{name} ���I�����ꂽ");
        }
    }
}
