using UnityEngine;
using UnityEngine.InputSystem;      //Using 'UnityEngine.InputSystem' !!
using UnityEngine.UI;               //Using 'UnityEngine.UI' !!

public class ControllerTypingTest : MonoBehaviour
{
    /*
     * TUTORIALS
     * https://youtu.be/p-3S73MaDP8 - Brackeys Controller Input
     * https://youtu.be/INbqu9JvZHw - SebLague Arrays
    */

    PlayerControls typeControls;    //Create a 'PlayerControls' var, for controller input

    public float moveSpeed = 5f;    //Obsolete??

    Vector2 move;   //Store the 'context' (ctx) of input from the left stick (In this it is read as a Vector2 (see below))

    //Vector2[] buttonCoords = new Vector2[7];
    Transform[,] buttonCoords2 = new Transform[3,3];      //2D Array for determining which of the 8 directions the player is moving relative to the typing menu

    public bool menuOpen = false;     //Will be true if the typing menu is open
    //public bool buttonSelected = false;

    string[] eastLetters  = { "A", "B", "C", "D", "E", "F", "G", "H" };
    string[] southLetters = new string[7];
    string[] westLetters  = new string[7];
    string[] northLetters = new string[7];

    public string[][] arrayofStringArrays = new string[4][];

    public GameObject typingMenu;     //Set in inspector, ref to the typing menu from the UI layer

    private void Awake()
    {
        typeControls = new PlayerControls();    //Everytime want to do something with input, can just type 'controls' now

        //Right and Left Bumpers
        typeControls.Typing_Gamepad.Confirm.performed += ctx => Confirm();      //Confirm which letter you want
        typeControls.Typing_Gamepad.Backspace.performed += ctx => Backspace();  //Delete the letter you just typed
        //controls.Gameplay.Grow.performed += ctx => Grow();

        //Getting input from buttons, opening menu
        typeControls.Typing_Gamepad.EastButtonMenu.performed += ctx => OpenMenu(0);     //Run function that opens menu (0 for "arrayOfStringArrays" to know which letter group to bring up)
        typeControls.Typing_Gamepad.EastButtonMenu.canceled += ctx => CloseMenu();

        //Getting input from left stick, movement
        typeControls.Typing_Gamepad.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        typeControls.Typing_Gamepad.Move.canceled += ctx => move = Vector2.zero;

        //Gets the child of each corresponding button in the typing menu    //DEBUG
        buttonCoords2[0, 0] = typingMenu.transform.GetChild(0);             //"NW";
        buttonCoords2[0, 1] = typingMenu.transform.GetChild(1);             //"N";
        buttonCoords2[0, 2] = typingMenu.transform.GetChild(2);             //"NE";
        buttonCoords2[1, 0] = typingMenu.transform.GetChild(3);             //"W";
        buttonCoords2[1, 1] = null; //typingMenu.transform.GetChild(4);           //"Empty";        //Get rid of/make null? (Would need to adjust children in hierarchy)
        buttonCoords2[1, 2] = typingMenu.transform.GetChild(4);             //"E";
        buttonCoords2[2, 0] = typingMenu.transform.GetChild(5);             //"SW";
        buttonCoords2[2, 1] = typingMenu.transform.GetChild(6);             //"S";
        buttonCoords2[2, 2] = typingMenu.transform.GetChild(7);             //"SE";

        arrayofStringArrays[0] = eastLetters;
        arrayofStringArrays[1] = southLetters;
        arrayofStringArrays[2] = westLetters;
        arrayofStringArrays[3] = northLetters;
    }

    private void Update()
    {
        if(menuOpen)    //If A,B,X, or Y is being held...
        {


            //Convert Input to 2D Array Indices
            //First Quantize Input (see below), gives 8 directions of movement (Cardinal directions basically)
            int arrayX = QuantizeAxis(move.x) + 1;
            int arrayY = (QuantizeAxis(move.y) * -1) + 1;

            //print(buttonCoords2[arrayY, arrayX]);   //DEBUG


            //Highlights the buttons on the Typing Menu
            HighlightMenu(buttonCoords2[arrayY, arrayX]);    //Reversed to help convert (x,y) coords to the array indicies (see notebook for how this works)
        }
    }

    //Will give 8 directional movement
    //Change .35f if want the input areas on joystick to be different
    int QuantizeAxis(float input)
    {
        if (input < -0.35f) return -1;
        if (input > 0.35f) return 1;
        return 0;
    }

    //Open up the general typing menu, which letters not calculated yet
    void OpenMenu(int buttonIdentity)
    {
        if(!menuOpen)       //Prevent mult buttons being pressed from running this method mult times (?? Still need to test, only 1 button working rn)
        {
            menuOpen = true;
            typingMenu.SetActive(true);     //Typing menu overlay appears
            print("Button Pressed: " + buttonIdentity);     //DEBUG

            /*
            for each(Transform in buttonCoords2)
            {
                int i;
                //Trasnform.etc.SetLetter(i);   //Would need to make this script a parent to 'TypingButton' again though??
                i ++;
            }
            */
        }

        //int buttonCount ++; ??
    }

    void CloseMenu()
    {
        if(menuOpen)        //Prevent mult buttons being pressed from running this method mult times (?? Still need to test, only 1 button working rn)
            //Or 'if(buttonCount <= 1)' ??
        {
            menuOpen = false;
            typingMenu.SetActive(false);    //Typing menu overlay disappears
            print("Button released");                       //DEBUG
        }
        
        //buttonCount --;
    }

    void HighlightMenu(Transform buttonChild)   //buttonChild is 'buttonCoords2[arrayY, arrayX]'
    {
        if (buttonChild)
        {
            //buttonChild.GetComponent<Image>().color = Color.green;\
            buttonChild.GetComponent<TypingButton>().buttonSelected = true;
        }
    }

    void Confirm()
    {
        if(menuOpen)
        {
            print("Confirmed!");
        }
    }

    void Backspace()
    {
        if(menuOpen)
        {
            print("Backspace!");
        }
    }



    //Included so that if the obj we have these controls working on is not in the scene, those controls will no longer be applied
    private void OnEnable()
    {
        typeControls.Typing_Gamepad.Enable(); //Activates all of our actions in our action map
    }

    private void OnDisable()
    {
        typeControls.Typing_Gamepad.Disable();
    }
}
