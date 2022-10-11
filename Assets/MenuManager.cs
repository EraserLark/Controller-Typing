using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    GameObject typingMenu;
    InputManager inputMan = new InputManager();

    private void Awake()
    {
        typingMenu = GameObject.Find("TypingMenu");
        openMenu(false);

        inputMan.inputDetected += menuInput;    //Connecting the signal(?)
    }

    //Func that runs once signal is recieved
    public void menuInput(System.Object sender, InputAction inpAct)
    {
        print(inpAct);
    }

    public void openMenu(bool state)
    {
        typingMenu.SetActive(state);
    }
}
