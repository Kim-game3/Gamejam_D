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
        // �w�̂ǂꂩ��������Ă�����쓮
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
