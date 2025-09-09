using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("一回の入力あたりに進む距離")]
    [SerializeField] float Move_Range;

    private GameObject[] Fingers;

    [SerializeField] Transform parent;

    Rigidbody2D rb;
    private int L_count = 0;
    private int R_count = 0;
    private int M_count = 0;
    private int I_count = 0;
    private int T_count = 0;

    private void Start()
    {
        int count = parent.childCount;
        Fingers = new GameObject[count];
        rb = GetComponent<Rigidbody2D>();
        for(int i = 0; i < Fingers.Length; i++)
        {
            Fingers[i] = parent.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        
       Vector2 move = Vector2.zero;

        for(int i = 0; i < Fingers.Length; i++) 
        {
            if (Fingers[i].CompareTag("Little"))
            {
                break;
            }
            L_count++;
        }

        for (int i = 0; i < Fingers.Length; i++)
        {
            if (Fingers[i].CompareTag("Ring"))
            {
                break;
            }
            R_count++;
        }

        for (int i = 0; i < Fingers.Length; i++)
        {
            if (Fingers[i].CompareTag("Middle"))
            {
                break;
            }
            M_count++;
        }

        for (int i = 0; i < Fingers.Length; i++)
        {
            if (Fingers[i].CompareTag("Index"))
            {
                break;
            }
            I_count++;
        }

        for (int i = 0; i < Fingers.Length; i++)
        {
            if (Fingers[i].CompareTag("Tomb"))
            {
                break;
            }
            T_count++;
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
       {
            switch(L_count)
            {
                case 0: move += new Vector2(-Move_Range, 0);
                    break;
                case 1: move += new Vector2(-Move_Range, Move_Range);
                    break;
                case 2: move += new Vector2(0, Move_Range);
                    break;
                case 3: move += new Vector2(Move_Range, Move_Range);
                    break;
                case 4: move += new Vector2(Move_Range, 0);
                    break;
                default: break;
            }
            Debug.Log("A");
       }

       if (Keyboard.current.wKey.wasPressedThisFrame)
       {
            switch (R_count)
            {
                case 0:
                    move += new Vector2(-Move_Range, 0);
                    break;
                case 1:
                    move += new Vector2(-Move_Range, Move_Range);
                    break;
                case 2:
                    move += new Vector2(0, Move_Range);
                    break;
                case 3:
                    move += new Vector2(Move_Range, Move_Range);
                    break;
                case 4:
                    move += new Vector2(Move_Range, 0);
                    break;
                default: break;
            }

            Debug.Log("W");
       }

       if (Keyboard.current.eKey.wasPressedThisFrame)
       {
            switch (M_count)
            {
                case 0:
                    move += new Vector2(-Move_Range, 0);
                    break;
                case 1:
                    move += new Vector2(-Move_Range, Move_Range);
                    break;
                case 2:
                    move += new Vector2(0, Move_Range);
                    break;
                case 3:
                    move += new Vector2(Move_Range, Move_Range);
                    break;
                case 4:
                    move += new Vector2(Move_Range, 0);
                    break;
                default: break;
            }

            Debug.Log("E");
       }

       if (Keyboard.current.fKey.wasPressedThisFrame)
       {
            switch (I_count)
            {
                case 0:
                    move += new Vector2(-Move_Range, 0);
                    break;
                case 1:
                    move += new Vector2(-Move_Range, Move_Range);
                    break;
                case 2:
                    move += new Vector2(0, Move_Range);
                    break;
                case 3:
                    move += new Vector2(Move_Range, Move_Range);
                    break;
                case 4:
                    move += new Vector2(Move_Range, 0);
                    break;
                default: break;
            }

            Debug.Log("F");
       }

       if (Keyboard.current.spaceKey.wasPressedThisFrame)
       {

            switch (T_count)
            {
                case 0:
                    move += new Vector2(-Move_Range, 0);
                    break;
                case 1:
                    move += new Vector2(-Move_Range, Move_Range);
                    break;
                case 2:
                    move += new Vector2(0, Move_Range);
                    break;
                case 3:
                    move += new Vector2(Move_Range, Move_Range);
                    break;
                case 4:
                    move += new Vector2(Move_Range, 0);
                    break;
                default: break;
            }

            Debug.Log("Space");
       }

       if (move != Vector2.zero)
       {
         
         rb.MovePosition(rb.position + move);

       }

        
    }
}
