using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Animations;

public class Camera_Rotate_Around : MonoBehaviour
{

    private float MouseX = 0;
    private float MouseY = 0;
    private bool Lock = false;
    [SerializeField] private Transform Rotate_Around;
    [SerializeField] private Transform player;


    [Header("Ofsetts")]
    [SerializeField] private float x_Offset;
    [SerializeField] private float y_offset;
    [SerializeField] private float z_offset;

    [Header("Senstivity")]
    [SerializeField] private float senstivity;
   

    void Start()
    {
       
    }

    private void Update()
    {
        StayWith();
LockMouse();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        
    }

   

    private void StayWith()
    {
        //Compounds Mouse X Axis with mouses position.
         MouseX += Input.GetAxis("Mouse X");
         MouseY += Input.GetAxis("Mouse Y");



        //Roatates around the charcter with the MouseX and MouseY Varaibles.
        Rotate_Around.rotation = Quaternion.Euler( new Vector3(0,  MouseX * senstivity,  MouseY * senstivity * -1));
        player.rotation = Quaternion.Euler(player.eulerAngles.x, Rotate_Around.eulerAngles.y, player.eulerAngles.z);

    }

    private void LockMouse()
    {
        
        //Locks mouse
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lock = !Lock;
        }

        if(Lock)
            {
Cursor.lockState = CursorLockMode.Locked;
            }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

        

    }



}
