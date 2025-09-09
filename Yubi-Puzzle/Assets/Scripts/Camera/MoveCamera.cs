using UnityEngine;

[RequireComponent (typeof(Camera))]
public class MoveCamera : MonoBehaviour
{
    GameObject Player;
    Transform PlayerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Hand");
        PlayerTransform = Player.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Move_Camera();
    }

    void Move_Camera()
    {
        transform.position = new Vector3(transform.position.x, PlayerTransform.position.y, transform.position.z);
    }
}
