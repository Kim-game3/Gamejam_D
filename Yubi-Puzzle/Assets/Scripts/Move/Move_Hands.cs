using UnityEngine;
using UnityEngine.InputSystem;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("‘¬“x")]
    [SerializeField] float Move_Speed;

    [Tooltip("Žw‚ðŠi”[‚·‚é”z—ñ")]
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





}
