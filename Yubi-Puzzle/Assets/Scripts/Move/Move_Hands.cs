using UnityEngine;
using UnityEngine.InputSystem;

public class Move_Hands : MonoBehaviour
{
    [SerializeField] float Move_Speed;
    [SerializeField] GameObject[] Fingers;
    private InputAction little;
    private InputAction ring;
    private InputAction middle;
    private InputAction index;
    private InputAction tomb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        little = InputSystem.actions.FindAction("Little");
        ring = InputSystem.actions.FindAction("Ring");
        middle = InputSystem.actions.FindAction("Middle");
        index = InputSystem.actions.FindAction("Index");
        tomb = InputSystem.actions.FindAction("Tomb");
        
    }

    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (little.IsPressed())
        {
            Vector3 force = new Vector3(0, 0, -Move_Speed);

            rb.AddForce(force);
        }

        if(ring.IsPressed()) 
        {
            Vector3 force = new Vector3(Move_Speed, 0, -Move_Speed);

            rb.AddForce(force);
        }

        if(middle.IsPressed()) 
        {
            Vector3 force = new Vector3(Move_Speed, 0, 0);
            rb.AddForce(force);
        }

        if(index.IsPressed())
        {
            Vector3 force = new Vector3(Move_Speed, 0, -Move_Speed);
            rb.AddForce(force);
        }

        if(tomb.IsPressed())
        {
            Vector3 force = new Vector3(0, 0, -Move_Speed);
            rb.AddForce(force);
        }
    }

}
