using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public float CountdownTime = 3f;
    public Text CountdownText;
    public GameObject CountdownWindow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountdownTime -= Time.deltaTime;
        CountdownText.text = ((int)CountdownTime+1f).ToString();

        if (CountdownTime <= 0)
        {
            CountdownWindow.SetActive(false);
            this.enabled = false;
        }

    }
}
