using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawn_Cube : MonoBehaviour
{

    private float time = 0;


    [Header("GameObjects")]
    [SerializeField] private GameObject Pellet;

    [Header("Variables")]
    [SerializeField] private float SpawnRate;

    [Header("Transforms")]
    [SerializeField] private Transform Spawn_Point;
   

    // Update is called once per frame
    void Update()
    {
        //Sets Time
        time += Time.deltaTime;

        //If the time is greater or equal to the spawn rate then spawn a box and then make the time 9
        if(time >= SpawnRate)
        {
            Spawn(Pellet);
            time = 0;
        }

    }

    private void Spawn(GameObject Pellet)
    {
        Instantiate(Pellet, Spawn_Point);
        
    }



}
