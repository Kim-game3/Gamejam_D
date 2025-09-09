using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static CorrectFinger;


public class MoveTimerScript : MonoBehaviour
{
    public float MaxTime = 120f;//��������
    public float MoveTime = 10f;
    public Text TimerText;
    public GameObject CountdownWindow;
    float ElapsedTime = 0f;//�o�ߎ���

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveTime = MaxTime;
        Time.timeScale = 0;//�V�X�e�����~�߂�

    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownWindow.activeSelf == false)
        {

            MoveTime -= Time.deltaTime;//�c�莞��
            ElapsedTime += Time.deltaTime;
            GameScore.GoalTime = (int)ElapsedTime;
            GameScore.RemainingTime = (int)MoveTime;
            TimerText.text = ((int)MoveTime).ToString();

            if (MoveTime <= 0)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
