using UnityEngine;

public class SetFingerPoint : MonoBehaviour
{
    public GameObject SetPoint;

    public void SetFinger(GameObject Finger)
    {
        Finger.transform.position = SetPoint.transform.position;
    }
}
