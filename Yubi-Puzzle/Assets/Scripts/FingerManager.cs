using UnityEngine;

public class FingerManager : MonoBehaviour
{
    Camera mainCam;
    public Assign_Finger[] Finger;   // HACK:名前変えたい
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

                if (finger != null && SelectFinger == null) 
                {
                    SelectFinger = hit.collider.gameObject;
                    finger.OnFingerClicked();
                }
                else if (hit.collider.CompareTag("Finger"))
                {
                    Debug.Log("Swap Fingers!");
                    GameObject otherFinger = hit.collider.gameObject;
                    FingerInfo infoA = SelectFinger.GetComponent<FingerInfo>();
                    FingerInfo infoB = otherFinger.GetComponent<FingerInfo>();

                    //HitBoxの保存
                    GameObject hitBoxA = infoA.currentHitBox;
                    GameObject hitBoxB = infoB.currentHitBox;

                    Vector3 tmp = finger.transform.position;
                    finger.transform.position = hit.collider.gameObject.transform.position;
                    hit.collider.gameObject.transform.position = tmp;

                    infoA.currentHitBox = hitBoxB;
                    infoB.currentHitBox = hitBoxA;

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
                    if (sfp != null && SelectFinger != null)
                    {
                        FingerInfo info = SelectFinger.GetComponent<FingerInfo>();
                        if(info != null)
                        {
                            if (info.currentHitBox != null)
                            {
                                info.currentHitBox.SetActive(true);
                                info.currentHitBox = null;
                            }
                            sfp.SetFinger(SelectFinger);
                            hit.collider.gameObject.SetActive(false);
                            info.currentHitBox = hit.collider.gameObject;
                        }
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

                if (SelectFinger != null)
                {
                    FingerInfo info = SelectFinger.GetComponent<FingerInfo>();
                    if(info != null)
                    {
                        // 指を元の位置に戻し、HitBoxを復活させる
                        SelectFinger.transform.position = info.InitialPosition;

                        if(info.currentHitBox != null)
                        {
                            info.currentHitBox.SetActive(true);
                            info.currentHitBox = null;
                        }
                    }
                }
                for (int i = 0; i < Finger.Length; i++)
                {
                    Finger[i].isClick = false;
                }
                SelectFinger = null;
            }
        }   
    }
}
