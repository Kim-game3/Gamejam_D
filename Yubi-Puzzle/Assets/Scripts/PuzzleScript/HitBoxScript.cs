using UnityEngine;

public class HitBoxScript : MonoBehaviour
{
    public Check_isClick Cursor;
    [SerializeField] private Renderer[] HitBoxesRenderer;
    [SerializeField] private Collider[] HitBoxesCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        // 指がクリックされていたら緑の当たり判定を表示する
        if (Cursor.isClickFinger)
            ShowHitBox();
        else
            HideHitBox();
    }

    void ShowHitBox()
    {
        for (int i = 0; i < HitBoxesRenderer.Length; i++)
            HitBoxesRenderer[i].enabled = true;
        for (int i = 0; i < HitBoxesCollider.Length; i++)
            HitBoxesCollider[i].enabled = true;

    }

    void HideHitBox()
    {
        for (int i = 0; i < HitBoxesRenderer.Length; i++)
            HitBoxesRenderer[i].enabled = false;
        for (int i = 0; i < HitBoxesCollider.Length; i++)
            HitBoxesCollider[i].enabled = false;
    }
}
