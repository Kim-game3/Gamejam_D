using UnityEngine;

public class Check_isClick : MonoBehaviour
{
    public Assign_Finger[] Click;
    public bool isClickFinger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // w‚Ì‚Ç‚ê‚©‚ª‰Ÿ‚³‚ê‚Ä‚¢‚½‚çì“®
        for(int i = 0; i < Click.Length; i++)
        {
            if (Click[i].isClick == true)
            {
                isClickFinger = true;
                break;
            }
            else
                isClickFinger = false;
        }
    }
}
