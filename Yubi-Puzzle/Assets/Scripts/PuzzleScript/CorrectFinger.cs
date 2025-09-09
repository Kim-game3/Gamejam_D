using UnityEngine;

public static class GameScore
{
    public static int correctScore = 0;
    public static int GoalTime = 0;//MoveScene‚Å‚©‚©‚Á‚½ŽžŠÔ
    public static int RemainingTime = 0;
}

public class CorrectFinger : MonoBehaviour
{
    public string correctFingerName; // Inspectorで指定する
    private FingerInfo fingerInfo;   // この指に付いているFingerInfoを参照
    private bool isChecked = false;  // スコアを二重加算しないように制御

    void Start()
    {
        // このオブジェクトに付いているFingerInfoを取得
        fingerInfo = GetComponent<FingerInfo>();
    }

    // シーン切り替え前に呼ばれる想定
    public void CheckFinger()
    {
        if (isChecked) return; // すでに判定済みならスキップ

        if (fingerInfo != null)
        {
            // FingerInfoのnewNameと正解を比較
            if (fingerInfo.newName == correctFingerName)
            {
                GameScore.correctScore++;
                Debug.Log($"{gameObject.name} 正解！ Score = {GameScore.correctScore}");
            }
            else
            {
                Debug.Log($"{gameObject.name} 不正解…");
            }
        }
        isChecked = true;
    }
}