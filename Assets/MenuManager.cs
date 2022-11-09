using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    GameObject typingMenu;
    ScreenKeys screenKeys;
    BasicTextbox basicTextbox;
    LetterData letterData;
    CheatSheet cheatSheet;
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
        fastToggle = GameObject.Find("FastToggle").GetComponent<Toggle>();
    }

    private void Start()   //Lets vars initialize before menu is set inactive
    {
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

        selectCoords = Vector2.zero;
    }

    public void navigateMenu(Vector2 move)
    {
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
        Vector2 quantizedDir = QuantizeAxis(direction);
        if(quantizedDir != selectCoords)
        {
            firstCondition = !firstCondition;
        }
        else if(firstCondition && quantizedDir == selectCoords)
        {
            FastSelectLetter();
            firstCondition = false;
        }

        print(firstCondition);
        /*
        if(direction == Vector2.zero)
        {
            direction = QuantizeAxis(direction);
            if(direction != selectCoords)
            {
                FastSelectLetter();
            }
        }
        */

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

    IEnumerator DelayInputRecieved()
    {
        yield return null;
    }
}
