using UnityEngine;
using UnityEngine.UI;

public class ScreenKeys : MonoBehaviour
{
    GameObject[,] keyBoxes = new GameObject[3,3];
    public Text[] keyLetters = new Text[9];
    CheatSheet cheatSheet;

    private void Awake()
    {
        keyLetters = GetComponentsInChildren<Text>();

        int i = 0;
        for(int row = 0; row <= 2; row++)
        {
            for(int col = 0; col <= 2; col++)
            {
                keyBoxes[row, col] = transform.GetChild(i).gameObject;
                i++;
                //print("Obj:" + transform.GetChild(i).gameObject + " Row:" + row + " Col:" + col);
            }
        }
    }

    private void OnEnable()
    {
        cheatSheet = GameObject.Find("CheatSheet").GetComponent<CheatSheet>();
        if (cheatSheet.cheatIsOpen == true)
        {
            CheatResizeKeys(true);
        }
        else if (cheatSheet.cheatIsOpen == false)
        {
            CheatResizeKeys(false);
        }
    }

    public void CheatResizeKeys(bool state)
    {
        RectTransform keysRect = GetComponent<RectTransform>();

        if(state)
        {
            keysRect.localScale = new Vector3(0.75f, 0.75f, 1f);
            keysRect.anchoredPosition = new Vector2(500f, -325f);
            //keysRect.offsetMin = new Vector2(keysRect.offsetMin.x, 350f);
            //keysRect.offsetMax = new Vector2(keysRect.offsetMax.x, 0f);
        }
        else if(!state)
        {
            keysRect.localScale = new Vector3(1f, 1f, 1f);
            keysRect.anchoredPosition = new Vector2(500f, -377.5f);
            //keysRect.offsetMin = new Vector2(keysRect.offsetMin.x, 325f);
            //keysRect.offsetMax = new Vector2(keysRect.offsetMax.x, 0f);
        }
    }

    public void SetKeyLetters(string letters)
    {
        //print("Obj " + transform.GetChild(8).gameObject);
        //print("keyLetters Array: " + keyLetters[8]);

        for (int i = 0; i <= 8; i++)
        {
            keyLetters[i].text = letters[i].ToString();
        }
    }

    public void highlightKey(Vector2 keyToLight)
    {
        ResetWhite();

        int arrayX = (int)keyToLight.x;     //Array can't take float
        int arrayY = (int)keyToLight.y;

        keyBoxes[arrayX, arrayY].GetComponent<Image>().color = Color.green;

        //print(arrayX + ", " + arrayY + " = Green");
    }

    public void ResetWhite()
    {
        int i = 1;
        for (int row = 0; row <= 2; row++)
        {
            for (int col = 0; col <= 2; col++)
            {
                keyBoxes[row, col].GetComponent<Image>().color = Color.white;
            }
            i++;
        }
    }
}
