using UnityEngine;
using UnityEngine.InputSystem;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("���x")]
    [SerializeField] float Move_Speed;

    [Tooltip("�w���i�[����z��")]
    [SerializeField] GameObject[] Fingers;

    Rigidbody2D rb;
    private InputAction little;
    private InputAction ring;
    private InputAction middle;
    private InputAction index;
    private InputAction tomb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        little = InputSystem.actions.FindAction("Little");
        ring = InputSystem.actions.FindAction("Ring");
        middle = InputSystem.actions.FindAction("Middle");
        index = InputSystem.actions.FindAction("Index");
        tomb = InputSystem.actions.FindAction("Tomb");
    }

    private void FixedUpdate()
    {
        if(little.IsPressed())
        {
            Debug.Log("Little button pressed");
            while(!little.IsPressed()) 
            {
                rb.linearVelocity = new Vector2(0, Move_Speed);
            }

            rb.linearVelocity = Vector2.zero;
        }

        if(ring.IsPressed())
        {
            Debug.Log("Ring button pressed");
            while (!ring.IsPressed()) 
            {
                rb.linearVelocity = new Vector2(Move_Speed, Move_Speed);
            }

            rb.linearVelocity = Vector2.zero;
        }

        if (middle.IsPressed())
        {
            Debug.Log("Middle button pressed");
            while (!middle.IsPressed())
            {
                rb.linearVelocity = new Vector2(Move_Speed, 0);
            }

            rb.linearVelocity = Vector2.zero;
        }

        if(!index.IsPressed())
        {
            Debug.Log("Index button pressed");
            while (!index.IsPressed())
            {
                rb.linearVelocity = new Vector2(Move_Speed, -Move_Speed);
            }

            rb.linearVelocity = Vector2.zero;
        }

        if(tomb.IsPressed())
        {
            Debug.Log("Tomb button pressed");
            while (!tomb.IsPressed())
            {
                rb.linearVelocity = new Vector2(0, -Move_Speed);
            }

            rb.linearVelocity = Vector2.zero;
        }
    }



}
