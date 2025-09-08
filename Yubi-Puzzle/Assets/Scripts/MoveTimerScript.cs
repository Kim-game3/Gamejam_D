using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoveTimerScript : MonoBehaviour
{
    public float MoveTime = 10f;
    public Text TimerText;
    public GameObject CountdownWindow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;//ƒVƒXƒeƒ€‚ðŽ~‚ß‚é

    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownWindow.activeSelf == false)
        {

            MoveTime -= Time.deltaTime;
            TimerText.text = ((int)MoveTime).ToString();

            if (MoveTime <= 0)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
