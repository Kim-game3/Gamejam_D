using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleTimerScript : MonoBehaviour
{
    public float PuzzleTime = 10f;
    public Text TimerText;
    public GameObject DescriptionWindow;
    public GameObject CountdownWindow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;//システムを止める
    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownWindow.activeSelf==false)
        {
            PuzzleTime -= Time.deltaTime;
            TimerText.text = ((int)PuzzleTime).ToString();

            if (PuzzleTime <= 0)
            {
                CheckAllFingers();
                SceneManager.LoadScene("MoveScene");
            }
        }
    }
    void CheckAllFingers()
    {
        CorrectFinger[] all = FindObjectsByType<CorrectFinger>(FindObjectsSortMode.None);
        foreach (var cf in all)
        {
            cf.CheckFinger(); // ← 正解判定してスコア加算する
        }

        Debug.Log("正解数: " + GameScore.correctScore);
    }
}
