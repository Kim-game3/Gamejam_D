using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string SceneName = "Result";
    public GameObject CountdownWindow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void isClick()
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Finger_isClick()
    {
        if (CountdownWindow.activeSelf == false)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
