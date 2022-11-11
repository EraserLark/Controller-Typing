using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    GameObject typingMenu;
    ScreenKeys screenKeys;
    BasicTextbox basicTextbox;
    LetterData letterData;
    CheatSheet cheatSheet;
    DebugPanel debugPanel;
    Toggle fastToggle;

    InputManager inputMan = new InputManager();
    Vector2 selectCoords = Vector2.one;

    //Axis Letters
    LetterGroup currentAxisGroup;
    string currentGroup;

    bool firstCondition = false;
    bool secondCondition = false;

    private void Awake()
    {
        typingMenu = GameObject.Find("TypingMenu");
        screenKeys = GameObject.Find("ScreenKeys").GetComponent<ScreenKeys>();
        basicTextbox = GameObject.Find("BasicTextbox").GetComponent<BasicTextbox>();
        letterData = GameObject.Find("LetterData").GetComponent<LetterData>();
        cheatSheet = GameObject.Find("CheatSheet").GetComponent<CheatSheet>();
        debugPanel = GameObject.Find("DebugPanel").GetComponent<DebugPanel>();
        fastToggle = GameObject.Find("FastToggle").GetComponent<Toggle>();
    }

    private void Start()   //Lets vars initialize before menu is set inactive
    {
        debugPanel.gameObject.SetActive(false);

        selectCoords = Vector2.one;
        currentAxisGroup = letterData.presets[0];
        currentGroup = currentAxisGroup.axisGroup[0];
        cheatSheet.UpdatePresetGroups(currentAxisGroup);
        closeMenu(0);
    }

    public void setMenuPreset(List<LetterGroup> presets, int presetNum)
    {
        currentAxisGroup = presets[presetNum];
        cheatSheet.UpdatePresetGroups(currentAxisGroup);
    }

    public void openMenu(int num)
    {
        currentGroup = currentAxisGroup.axisGroup[num];
        screenKeys.SetKeyLetters(currentGroup);

        typingMenu.SetActive(true);
    }

    public void closeMenu(int num)
    {
        if(currentGroup == currentAxisGroup.axisGroup[num])
        {
            typingMenu.SetActive(false);
        }

        selectCoords = Vector2.one;
    }

    public void navigateMenu(Vector2 move)
    {
        if(debugPanel.isActiveAndEnabled)
        {
            debugPanel.UpdateInputDir(move);
        }

        if(fastToggle.isOn)
        {
            FastNav(move);
        }
        else
        {
            StandardNav(move);
        }
    }

    void FastNav(Vector2 direction)
    {
        Vector2 qDir = QuantizeAxis(direction);
        if(qDir == Vector2.one)
        {
            if(qDir != selectCoords)
            {
                FastSelectLetter();
            }
        }

        selectCoords = QuantizeAxis(direction);
        screenKeys.highlightKey(selectCoords);
    }

    void StandardNav(Vector2 direction)
    {
        selectCoords = QuantizeAxis(direction);
        screenKeys.highlightKey(selectCoords);
    }

    public void SelectLetter()
    {
        if (typingMenu.activeInHierarchy)
        {
            int charToPrint = (int)((selectCoords.x * 3) + selectCoords.y); //Format for 1D array
            basicTextbox.addLetter(currentGroup[charToPrint]);
        }
        else //Allows spaces even when menu is closed
        {
            basicTextbox.addLetter(' ');
        }
    }

    void FastSelectLetter()
    {
        if (typingMenu.activeInHierarchy)
        {
            int charToPrint = (int)((selectCoords.x * 3) + selectCoords.y); //Format for 1D array
            basicTextbox.addLetter(currentGroup[charToPrint]);
        }
    }

    //Will give 8 directional movement
    //Change .35f if want the input areas on joystick to be different
    Vector2 QuantizeAxis(Vector2 input)
    {
        float inputMag = Vector2.SqrMagnitude(input);

        if(debugPanel.isActiveAndEnabled)
        {
            debugPanel.UpdateVectorMag(inputMag);
        }

        //Rounding Input
        if(inputMag <= 0.95f)
        {
            input = Vector2.zero;
        }
        else if (inputMag > 0.95f)
        {
            input.x = Mathf.RoundToInt(input.x);
            input.y = Mathf.RoundToInt(input.y);
        }

        if (debugPanel.isActiveAndEnabled)
        {
            debugPanel.UpdateRoundedInput(input);
        }

        //Adjust for 2D array (flip x and y, other adjustments)
        float temp = input.x;
        input.x = (input.y * -1) + 1;
        input.y = (temp + 1);

        if (debugPanel.isActiveAndEnabled)
        {
            debugPanel.UpdateQuantizedInput(input);
        }

        return input;
    }
}
