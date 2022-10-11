using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    GameObject typingMenu;
    GameObject screenKeys;

    InputManager inputMan = new InputManager();
    Vector2 selectCoords = Vector2.one;

    private void Awake()
    {
        typingMenu = GameObject.Find("TypingMenu");
        screenKeys = GameObject.Find("ScreenKeys");
        openMenu(false);
    }

    public void openMenu(bool state)
    {
        typingMenu.SetActive(state);
    }

    public void navigateMenu(Vector2 move)
    {
        selectCoords = QuantizeAxis(move);
        screenKeys.GetComponent<ScreenKeys>().highlightKey(selectCoords);
    }

    public void SelectLetter()
    {
        print(selectCoords);
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

        //Adjust for array (flip x and y, other adjustments)
        float temp = input.x;
        input.x = (input.y * -1) + 1;
        input.y = (temp + 1);

        return input;
    }
}
