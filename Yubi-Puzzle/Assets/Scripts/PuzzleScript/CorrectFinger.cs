using UnityEngine;

public static class GameScore
{
    public static int correctScore = 0;
}

public class CorrectFinger : MonoBehaviour
{
    public string correctFingerName; // Inspector‚ÅŽw’è‚·‚é³‰ð
    private GameObject currentFinger; // ‚±‚ÌŠÖß‚ÉƒAƒ^ƒbƒ`‚³‚ê‚Ä‚¢‚éŽw
    private bool isChecked = false;   // ƒXƒRƒAd•¡–hŽ~

    // ‚±‚±‚ðŠO•”‚©‚çŒÄ‚ÔiƒV[ƒ“‘JˆÚŽžj
    public void CheckFinger()
    {
        public static int correctScore = 0;
        public static int GoalTime = 0;//MoveScene‚Å‚©‚©‚Á‚½ŽžŠÔ
        public static int RemainingTime = 0;
    }

    // ‘¼‚ÌƒXƒNƒŠƒvƒgiSetFingerPoint‚È‚Çj‚©‚çu‚±‚ÌŠÖß‚ÉŽw‚ª•t‚¢‚½v‚±‚Æ‚ð’Ê’m‚·‚é‚½‚ß‚Ìƒƒ\ƒbƒh
    public void SetFinger(GameObject finger)
    {
        currentFinger = finger;
    }

    // ŠÖß‚©‚çŽw‚ªŠO‚ê‚½‚Æ‚«‚ÉŒÄ‚Ô
    public void ClearFinger()
    {
        currentFinger = null;
    }
}
