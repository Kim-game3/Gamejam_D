using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButtomScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(StartPush);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartPush()
    {
        SceneManager.LoadScene("PuzzleScene");
    }
}
