using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive) {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        logic.endGame();
        isAlive = false;
    }
    
}
