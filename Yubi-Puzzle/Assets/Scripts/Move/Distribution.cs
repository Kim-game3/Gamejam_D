using UnityEngine;

public class Distribution : MonoBehaviour
{
    [SerializeField] GameObject[] FingerPrefabs;
    [SerializeField] Transform parent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Transform child in parent)
        {
            FingerInfo info = child.GetComponent<FingerInfo>();
            if(info == null)
            {
                continue;
            }
            foreach(var obj in FingerPrefabs) 
            {
                if(obj != null && obj.name == info.newName)
                {
                    obj.transform.SetParent(child, false);
                }
            }
        }
    }
}
