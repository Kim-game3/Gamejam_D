using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ToTitleButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ToTitlePush);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ToTitlePush()
    {
        SceneManager.LoadScene("Title");
    }

}
