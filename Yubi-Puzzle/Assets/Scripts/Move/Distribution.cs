using UnityEngine;

public class Distribution : MonoBehaviour
{
    [SerializeField] GameObject[] FingerPrefabs;
    [SerializeField] Transform parent;
    [SerializeField] FingerInfo fingerinfo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int childCount = parent.childCount;
        
        for(int i = 0; i < childCount; i++) 
        {
            string targetName = fingerinfo.newName[i];
            Transform slot = parent.GetChild(i);

            foreach(var obj in FingerPrefabs)
            { }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
