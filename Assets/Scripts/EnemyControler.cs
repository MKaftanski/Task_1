using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{


    Transform Player;
    Vector3 Move;
    int speed = 5;
    public Collider2D selfColider;
    public EnemyControler selfEnemyControler;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        Move = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

        setVector();

        Move = Move * Time.deltaTime* speed;
        transform.position = transform.position + Move;


    }


    void setVector() {

       if (transform.position.x > Player.position.x)
        {
            Move = new Vector3(1, 0, 0);
        }
        else
        {
            Move = new Vector3(-1, 0, 0);
        }

        if (transform.position.y > Player.position.y)
        {
            Move = new Vector3(Move.x, 1, 0);
        }
        else
        {
            Move = new Vector3(Move.x, -1, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
            if (collision.gameObject.tag == "Player")
            {
            Destroy(selfColider);
            Destroy(selfEnemyControler);
            }
        }


}
