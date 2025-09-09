using UnityEngine;

public class Finger_Struct : MonoBehaviour
{
    struct Finger
    {
        public bool isClick;
        public string name;
        public Vector3 position;

        public Finger(bool isClick, string name, Vector3 position)
        {
            this.isClick = isClick;
            this.name = name;
            this.position = position;
        }
    }

}
