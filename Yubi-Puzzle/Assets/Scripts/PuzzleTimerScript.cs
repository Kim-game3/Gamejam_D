using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleTimerScript : MonoBehaviour
{
    public float PuzzleTime = 10f;
    public Text TimerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PuzzleTime -= Time.deltaTime;
        TimerText.text = ((int)PuzzleTime).ToString();

        if (PuzzleTime <= 0)
        {
            SceneManager.LoadScene("MoveScene");
        }
    }
}
