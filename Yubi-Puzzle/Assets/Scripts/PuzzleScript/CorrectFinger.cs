using UnityEngine;

public static class GameScore
{
    public static int correctScore = 0;
}

public class CorrectFinger : MonoBehaviour
{
    public string correctFingerName; // Inspector�Ŏw�肷�鐳��
    private GameObject currentFinger; // ���̊֐߂ɃA�^�b�`����Ă���w
    private bool isChecked = false;   // �X�R�A�d���h�~

    // �������O������Ăԁi�V�[���J�ڎ��j
    public void CheckFinger()
    {
        if (isChecked) return;

        if (currentFinger != null)
        {
            FingerInfo info = currentFinger.GetComponent<FingerInfo>();
            if (info != null)
            {
                if (info.newName == correctFingerName)
                {
                    GameScore.correctScore++;
                    Debug.Log($"{gameObject.name} �����I Score = {GameScore.correctScore}");
                }
                else
                {
                    Debug.Log($"{gameObject.name} �s�����c");
                }
            }
        }
        isChecked = true;
    }

    // ���̃X�N���v�g�iSetFingerPoint�Ȃǁj����u���̊֐߂Ɏw���t�����v���Ƃ�ʒm���邽�߂̃��\�b�h
    public void SetFinger(GameObject finger)
    {
        currentFinger = finger;
    }

    // �֐߂���w���O�ꂽ�Ƃ��ɌĂ�
    public void ClearFinger()
    {
        currentFinger = null;
    }
}
