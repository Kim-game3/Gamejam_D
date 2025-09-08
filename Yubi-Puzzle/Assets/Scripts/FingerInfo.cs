using UnityEngine;

public class FingerInfo : MonoBehaviour
{
    Assign_Finger thisFinger;
    public string newName;
    public Vector3 Instantiate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (thisFinger.isClick)
        //{
        //    // TODO:‚¿‚å‚Á‚Æ•‚‚©‚· or ‰‚ğ—Î‚É‚µ‚Ä‚í‚©‚è‚â‚·‚­‚·‚é
        //}
    }
}
