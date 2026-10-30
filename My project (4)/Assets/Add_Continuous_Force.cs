using UnityEngine;
using UnityEngine.Rendering;

public class Add_Continuous_Force : MonoBehaviour
{
    [SerializeField] private Rigidbody Conveyor;

    [SerializeField] private float speed;
    // Update is called once per frame
    private Vector3 StartPos;

    [SerializeField] private bool record;

    [SerializeField] private bool on;

    private void Start()
    {

    }
    void Update()
    {




        if (on  == true)
        {
            Conveyor.AddRelativeForce(new Vector3(0, 0, 1 * speed), ForceMode.VelocityChange);
            Conveyor.linearVelocity = new Vector3(0, 0, 0);
        }
        //Adds Force realtive to the position :D


    }

    public void TurnOn()
    {
        on = true;
    }
    public void Turnoff()
    {
        on = false;
    }

}
