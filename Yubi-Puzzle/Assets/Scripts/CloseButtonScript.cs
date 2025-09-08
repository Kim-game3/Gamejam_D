using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CloseButtonScript : MonoBehaviour
{
    public GameObject DescriptionWindow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ClosePush);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ClosePush()
    {
        DescriptionWindow.SetActive(false);
        Time.timeScale = 1;
    }

}
