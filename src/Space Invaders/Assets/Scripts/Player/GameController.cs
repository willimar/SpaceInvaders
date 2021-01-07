using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    #region Key validations
    bool KeyPress()
    {
        return Input.touchCount > 0 ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.Space);
    }

    bool KeyLeft()
    {
        return false;
    }

    bool KeyRight()
    {
        return false;
    }

    bool KeyUp()
    {
        return false;
    }

    bool KeyDown()
    {
        return false;
    }

    bool KeyFire()
    {
        return false;
    }
    #endregion

    #region Moviments
    void MoveLeft()
    {

    }

    void MoveRight()
    {

    }

    void MoveUp()
    {

    }

    void MoveDown()
    {

    }

    void Fire()
    {

    }

    #endregion

    // Update is called once per frame
    void Update()
    {
        if (KeyPress())
        {
            if (KeyLeft())
            {
                MoveLeft();
            }

            if (KeyRight())
            {
                MoveRight();
            }

            if (KeyDown())
            {
                MoveDown();
            }

            if (KeyUp())
            {
                MoveUp();
            }

            if (KeyFire())
            {
                Fire();
            }
        }
    }
}
