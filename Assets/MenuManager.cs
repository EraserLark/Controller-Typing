using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    GameObject typingMenu;
    ScreenKeys screenKeys;
    BasicTextbox basicTextbox;

    InputManager inputMan = new InputManager();
    Vector2 selectCoords = Vector2.one;

    //Letters
    string northChars = "ABCD EFGH"; //North(X)
    string eastChars =  "IJKL MNOP"; //East(A)
    string southChars = "QRST UVWX"; //South(B)
    string westChars =  "YZ.! ?,+-"; //West(Y)
    char[][] currentLetters = new char[4][];

    private void Awake()
    {
        typingMenu = GameObject.Find("TypingMenu");
        screenKeys = GameObject.Find("ScreenKeys").GetComponent<ScreenKeys>();
        basicTextbox = GameObject.Find("BasicTextbox").GetComponent<BasicTextbox>();
    }

    private void Start()   //Lets vars initialize before menu is set inactive
    {
        openMenu(false);
    }

    public void openMenu(bool state)
    {
        typingMenu.SetActive(state);
        screenKeys.SetKeyLetters(northChars);
    }

    public void navigateMenu(Vector2 move)
    {
        selectCoords = QuantizeAxis(move);
        screenKeys.highlightKey(selectCoords);
    }

    public void SelectLetter()
    {
        int charToPrint = (int)((selectCoords.x * 3) + selectCoords.y); //Format for 1D array
        basicTextbox.addLetter(northChars[charToPrint]);
    }

    //Will give 8 directional movement
    //Change .35f if want the input areas on joystick to be different
    Vector2 QuantizeAxis(Vector2 input)
    {   
        if (input.x < -0.35f)
        {
            input.x = -1;
        }
        else if (input.x > 0.35f)
        {
            input.x = 1;
        }
        if (input.y < -0.35f)
        {
            input.y = -1;
        }
        else if (input.y > 0.35f)
        {
            input.y = 1;
        }

        //Adjust for 2D array (flip x and y, other adjustments)
        float temp = input.x;
        input.x = (input.y * -1) + 1;
        input.y = (temp + 1);

        return input;
    }
}
