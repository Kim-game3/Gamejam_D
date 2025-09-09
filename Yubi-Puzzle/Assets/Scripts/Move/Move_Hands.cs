using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("一回の入力あたりに進む距離")]
    [SerializeField] float Move_Range;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
       Vector2 move = Vector2.zero;

       if (Keyboard.current.aKey.wasPressedThisFrame)
       {
         move += new Vector2(-Move_Range, 0);
                Debug.Log("A");
       }

       if (Keyboard.current.wKey.wasPressedThisFrame)
       {
         move += new Vector2(-Move_Range, Move_Range);
         Debug.Log("W");
       }

       if (Keyboard.current.eKey.wasPressedThisFrame)
       {
         move += new Vector2(0, Move_Range);
         Debug.Log("E");
       }

       if (Keyboard.current.fKey.wasPressedThisFrame)
       {
         move += new Vector2(Move_Range, Move_Range);
         Debug.Log("F");
       }

       if (Keyboard.current.spaceKey.wasPressedThisFrame)
       {
         move += new Vector2(Move_Range, 0);
         Debug.Log("Space");
       }

       if (move != Vector2.zero)
       {
         
         rb.MovePosition(rb.position + move);

       }

        
    }
}
