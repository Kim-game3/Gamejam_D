using UnityEngine;

public class FingerManager : MonoBehaviour
{
    Camera mainCam;
    public Assign_Finger[] Finger;   // HACK:–¼‘O•Ï‚¦‚½‚¢
    public GameObject SelectFinger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out RaycastHit hit))
            {
                Assign_Finger finger = hit.collider.GetComponent<Assign_Finger>();

                if(finger != null)
                {
                    SelectFinger = hit.collider.gameObject;
                    finger.OnFingerClicked();
                }
                else if (hit.collider.CompareTag("Finger"))
                {
                    Vector3 tmp = finger.transform.position;
                    finger.transform.position = hit.collider.gameObject.transform.position;
                    hit.collider.gameObject.transform.position = tmp;
                    for (int i = 0; i < Finger.Length; i++)
                    {
                        Finger[i].isClick = false;
                    }
                    SelectFinger = null;
                }
                else if (hit.collider.CompareTag("HitBox"))
                {
                    Debug.Log("HitBox is clicked");
                    SetFingerPoint sfp = hit.collider.GetComponent<SetFingerPoint>();
                    if (sfp != null)
                    {
                        sfp.SetFinger(SelectFinger);
                        hit.collider.gameObject.SetActive(false);
                    }

                    for (int i = 0; i < Finger.Length; i++)
                    {
                        Finger[i].isClick = false;
                    }
                    SelectFinger = null;
                }
            }
            else
            {
                Debug.Log("Air Click");

                for (int i = 0; i < Finger.Length; i++)
                {
                    Finger[i].isClick = false;
                }
                SelectFinger = null;
            }
        }   
    }
}
