using UnityEngine;

public class Check_On_Ground : MonoBehaviour
{
    [Header("Transforms")]
    [SerializeField] private Transform raycast;

    [Header("RigidBodies")]
    [SerializeField] private Rigidbody Pellet;

    [SerializeField] private Rigidbody conveyor;

    [Header("Vectors")]
    private Vector3 directions;

    [Header("Variables")]
    [SerializeField] private float MaxDis;

    [SerializeField] private float speed;

    RaycastHit hit;

  

    void Update()
    {
        
        Conveyor();



    }

























    private void Conveyor()
    {





       /* Physics.Raycast(raycast.position, Vector3.down, out hit, MaxDis);

Debug.Log(Pellet.linearVelocity);
          if ( hit.collider != null )
       {


           if(hit.collider.CompareTag("Tag"))
           {

               conveyor = hit.collider.GetComponent<Rigidbody>();
                //Setting Pellets Velo to only the pellets x and z velo;
                Pellet.linearVelocity = new Vector3(conveyor.linearVelocity.x, Pellet.linearVelocity.y, conveyor.linearVelocity.z);     
                
           }


       }
   */

       
          

    }
}
