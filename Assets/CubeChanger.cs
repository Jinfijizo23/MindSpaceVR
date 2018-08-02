using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeChanger : MonoBehaviour {

    private Renderer R;
    public Text FunctionStatus;
    private float Statusnumber;
    public GameObject ObjectToSpawn;
    public AudioSource Boop;
    public float Rotatespeed = 10f;

	// Use this for initialization
	void Start ()
    {
        R = GetComponent<Renderer>();
    }

    public void Randomjob(Vector3 location)
    {
        var rndnum = Random.Range(0, 3);
        Statusnumber = rndnum;
        FunctionStatus.text = "Function: "+ Statusnumber;
        if(rndnum == 0)
        {
            Function1(location);
        }
        if(rndnum == 1)
        {
            Function2();
        }
        if(rndnum == 2)
        {
            Function3();
        }
    }

     void Function1(Vector3 spawnPoint)
    {
        R.material.color = Color.red;
        Instantiate(ObjectToSpawn, spawnPoint, Quaternion.identity);
    }

    void Function2()
    {
        R.material.color = Color.green;
        Boop.Play();
    }
    void Function3()
    {
        R.material.color = Color.blue;
        transform.Rotate(0, Rotatespeed * Time.deltaTime, 0);

    }
}
