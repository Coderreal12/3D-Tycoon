using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUp : MonoBehaviour
{

    private bool pick = false;
    RaycastHit hit;
    Ray ray;

    [Header("Transforms")]
    [SerializeField] private Transform Raycast_Start;
    [SerializeField] private Transform Holding;

    [Header("Variables")]

    [SerializeField] private float MaxDis;

    [SerializeField] private float transfomr;

    //Tempories
    private Transform TempTransform;
    private Rigidbody TempRigidbody;
    private Collider TempCollider;
    private Add_Continuous_Force TempAdd;

    // Update is called once per frame
    void Update()
    {

        if (pick == true)
        {
            Pickup();
            Move();
           
        }
        

        if (pick == true && Input.GetKeyDown(KeyCode.R))
        {
            LetGo();

            pick = false;
           

        }



        SendRay();

        if (Physics.Raycast(ray, out hit, MaxDis, LayerMask.GetMask("AblePickup")) && pick == false && Input.GetKeyDown(KeyCode.E))
        {
            SetVariables();

            pick = true;
            if (hit.collider.CompareTag("Tag"))
            {

            }


        }

    }

    private void Move()
    {
        //Moves object while inside your hands;
        if (Input.GetKeyDown(KeyCode.T))
        {
            Holding.transform.Translate(transfomr, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Holding.transform.Translate(transfomr * -1, 0, 0);
        }

    }

   



    private void Pickup()
    {
        //Pick Up objects;
        
        TempTransform.transform.position = Holding.transform.position;
        TempRigidbody.isKinematic = true;
        TempCollider.enabled = false;
        
        
    }

    private void LetGo()
    {
        //Lets go of objects
        TempRigidbody.isKinematic = false;
        TempTransform.transform.position = TempTransform.transform.position;
        TempCollider.enabled = true;

    }

    private void SendRay()
    {
        ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
 Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * MaxDis, Color.red);
    }

    private void SetVariables()
    {
TempTransform = hit.collider.GetComponent<Transform>();
        TempRigidbody = hit.collider.GetComponent<Rigidbody>();
        TempCollider = hit.collider.GetComponent<Collider>();

       
    }


}
