using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(RetryPush);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RetryPush()
    {
        SceneManager.LoadScene("PuzzleScene");
    }

}
