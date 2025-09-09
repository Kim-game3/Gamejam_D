using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("移動速度")]
    [SerializeField] float Move_Speed;
    [Tooltip("どのキーを押したか表示するテキスト")]
    [SerializeField] Text Debug_Text;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 move = Vector2.zero;

        if(Keyboard.current.aKey.wasPressedThisFrame)
        {
            move += new Vector2(0, -Move_Speed);
            Debug_Text.text = $"{Key.A}";
        }

        if(Keyboard.current.wKey.wasPressedThisFrame)
        {
            move += new Vector2(Move_Speed, -Move_Speed);
            Debug_Text.text = $"{Key.W}";
        }

        if(Keyboard.current.eKey.wasPressedThisFrame)
        {
            move += new Vector2(Move_Speed, 0);
            Debug_Text.text = $"{Key.E}";
        }

        if(Keyboard.current.fKey.wasPressedThisFrame) 
        {
            move += new Vector2(Move_Speed, Move_Speed);
            Debug_Text.text = $"{Key.F}";
        }

        if(Keyboard.current.spaceKey.wasPressedThisFrame) 
        {
            move += new Vector2(0, Move_Speed);
            Debug_Text.text = $"{Key.Space}";
        }

        if(move != Vector2.zero)
        {
            rb.MovePosition(rb.position + move);
        }
    }



}
