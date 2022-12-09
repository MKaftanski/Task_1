using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharcterMovment : MonoBehaviour
{

    public bool MouseControl;
    Vector3 Move;
    int speed = 6;
    Vector3 mouseTemp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown)
        {

            MouseControl = false;

        }
        if (Input.mousePosition != mouseTemp)
        {

            MouseControl = true;

        }
        mouseTemp = Input.mousePosition;

            if (MouseControl)
            {

                MoveByMouse();

            }
            else
            {

                MoveByKeys();

            }

        transform.position = transform.position + Move;


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }



    }

    void MoveByKeys(){

        Move = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime * speed,
            Input.GetAxis("Vertical") * Time.deltaTime * speed,
            0
            );
    
    }

    void MoveByMouse()
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePosition.x > transform.position.x)
        {
            Move = new Vector3(1, 0, 0);
        }
        else
        {
            Move = new Vector3(-1, 0, 0);
        }

        if (mousePosition.y > transform.position.y)
        {
            Move = new Vector3(Move.x, 1, 0);
        }
        else
        {
            Move = new Vector3(Move.x, -1, 0);
        }

        Move = Move * Time.deltaTime * speed;


    }


}



   
