using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeScript : MonoBehaviour
{
    PlayerControls controls;    //Create a 'PlayerControls' var

    Vector2 rotate;
    Vector2 move;

    private void Awake()
    {
        controls = new PlayerControls();    //Everytime want to do something with input, can just type 'controls' now

        controls.Gameplay.Grow.performed += ctx => Grow();
        //ctx is for a 'Lambda Expression', 

        //Getting input from left stick, movement
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        //Getting input from right stick, rotation
        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.Rotate.canceled += ctx => rotate = Vector2.zero;
    }

    void Grow()
    {
        //transform.localScale *= 1.1f;
        print("Grow");
    }

    private void Update()
    {
        //For moving obj
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);

        //For rotating obj
        Vector2 r = new Vector2(rotate.y, -rotate.x) * 100 * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable(); //Activates all of our actions in our action map
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

}
