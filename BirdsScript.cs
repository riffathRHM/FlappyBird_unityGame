using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsScript : MonoBehaviour
{
    // Bird Script to Rigidbody to change the velocity
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
     public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "BOb Birdington";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true )
      {
          myRigidbody.velocity = Vector2.up * 10; 
      }
      
    }
      private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
