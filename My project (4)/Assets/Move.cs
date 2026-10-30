using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Variables
    [Header ("Variables")]
    private float x;
    private float y;

    [SerializeField] private float speed;

    [SerializeField] private float holdspeed;

    [SerializeField] private float maxdis;

    [SerializeField] private bool isgrouned;

    [SerializeField] private string[] grounds;

    [SerializeField] private float Jump_Height;

    float jump;
[Header("RayCasts")]
    [SerializeField] Transform[] Raycasts;

    [Header("Bools")]
    [SerializeField] private bool[] bools;

    


    


    [Header("RigidBodies")]
    [SerializeField] private Rigidbody player;

    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        holdspeed = speed;
        player.linearDamping = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Input From player
        input();
        send();
        move();
       



    }

   


    private void   input()
    {
 x = Input.GetAxisRaw("Horizontal");
         y = Input.GetAxisRaw("Vertical");
        
    }


    private void send()
    {
        //PLAN get an array of transforms, and make an array of bools, make a for loop to check if ONE bool is true!

     



        //Each bool has its own raycast.
        for (int i = 0; i < bools.Length ; i++)
        {
            bools[i] = Physics.Raycast(Raycasts[i].position, Vector3.down, maxdis, LayerMask.GetMask(grounds));
        }
        //If ONE of these are true then isgrounded = true
        for (int i = 0; i < bools.Length; i++)
            {
            if (bools[i] == true)
            {
                isgrouned = true;
                break;
            }
            else
            {
                isgrouned = false;
            }
        }



    }

        


    private void move()
    {      // Player velocity = New Vector Y jump height, and Speed.


if(isgrouned == false)
        {
            speed *= .1f;
            jump = 0;
            player.linearDamping = 0;
        }
        if (isgrouned == true)
        {
player.linearDamping = 5;
            speed = holdspeed;
        }

         if (Input.GetKeyDown(KeyCode.Space) && isgrouned == true)
        {
            jump = Jump_Height;
            

        }
         
        


            player.AddRelativeForce(new Vector3(-1 * speed * y, jump, 1 * speed * x), ForceMode.Force);
    }

}
