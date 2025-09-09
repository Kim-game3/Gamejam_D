using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Move_Hands : MonoBehaviour
{
    [Tooltip("一回の入力辺りに進む距離")]
    [SerializeField] float Move_Speed;

    [Tooltip("入力されたキーを表示するためのテキスト")]
    [SerializeField] Text Debug_Text;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 move = Vector2.zero;

        // 小指: Aキー → 左
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            move += new Vector2(0, -Move_Speed);
            Debug_Text.text = $"{Key.A}";
            Debug.Log("A");
        }

        // 薬指: Wキー → 左上
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            move += new Vector2(Move_Speed, -Move_Speed);
            Debug_Text.text = $"{Key.W}";
            Debug.Log("W");
        }

        // 中指: Eキー → 上
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            move += new Vector2(Move_Speed, 0);
            Debug_Text.text = $"{Key.E}";
            Debug.Log("E");
        }

        // 人差し指: Fキー → 右上
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            move += new Vector2(Move_Speed, Move_Speed);
            Debug_Text.text = $"{Key.F}";
            Debug.Log("F");
        }

        // 親指: Spaceキー → 右
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            move += new Vector2(0, Move_Speed);
            Debug_Text.text = $"{Key.Space}";
            Debug.Log("Space");
        }

        // 入力があれば位置を更新
        if (move != Vector2.zero)
        {
            rb.MovePosition(rb.position + move);
        }
    }



}
