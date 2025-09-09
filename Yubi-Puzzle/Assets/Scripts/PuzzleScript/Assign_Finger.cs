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
            Debug.Log($"{name} ‚ª‘I‘ð‚³‚ê‚½");
        }
    }
}
