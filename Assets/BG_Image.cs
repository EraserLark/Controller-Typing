using UnityEngine;
using UnityEngine.UI;

public class BG_Image : MonoBehaviour
{
    Image currentBG;
    public Sprite[] bgImages;

    private void Awake()
    {
        currentBG = GetComponent<Image>();
    }

    public void swapBG()    //Called from Button_ChangeBG
    {
        int newBGNum = Random.Range(0, bgImages.Length);
        currentBG.sprite = bgImages[newBGNum];
    }
}
