using UnityEngine;

public static class GameScore
{
    public static int correctScore = 0;
}

public class CorrectFinger : MonoBehaviour
{
    public string correctFingerName; // Inspectorで指定する正解
    private GameObject currentFinger; // この関節にアタッチされている指
    private bool isChecked = false;   // スコア重複防止

    // ここを外部から呼ぶ（シーン遷移時）
    public void CheckFinger()
    {
        if (isChecked) return;

        if (currentFinger != null)
        {
            FingerInfo info = currentFinger.GetComponent<FingerInfo>();
            if (info != null)
            {
                if (info.newName == correctFingerName)
                {
                    GameScore.correctScore++;
                    Debug.Log($"{gameObject.name} 正解！ Score = {GameScore.correctScore}");
                }
                else
                {
                    Debug.Log($"{gameObject.name} 不正解…");
                }
            }
        }
        isChecked = true;
    }

    // 他のスクリプト（SetFingerPointなど）から「この関節に指が付いた」ことを通知するためのメソッド
    public void SetFinger(GameObject finger)
    {
        currentFinger = finger;
    }

    // 関節から指が外れたときに呼ぶ
    public void ClearFinger()
    {
        currentFinger = null;
    }
}
