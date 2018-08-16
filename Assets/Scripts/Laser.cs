using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour {
 
    private LineRenderer LZR;
    public Text Status;
    public Text TriggerSelected;

    //Use this for initialization

   void Start ()
    {

       LZR = GetComponent<LineRenderer>();

       LZR.material.color = Color.red;

    }

    // Update is called once per frame
    public void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            //raycast stuff goes here
            ShootRaycast();
        }
        

	}


    public void ShootRaycast()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.forward, Color.magenta, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                LZR.SetPosition(1, new Vector3(0, 0, hit.distance));
                Status.text = hit.collider.gameObject.name + " hit! Distance: " + hit.distance;
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    TriggerSelected.text = "Trigger clicked";
                    hit.collider.gameObject.GetComponent<CubeChanger>().Randomjob(hit.point);
                }
            }
            else
            {
                LZR.SetPosition(1, new Vector3(0, 0, 1000));
            }
        }

    }
}

// New Audio: Weightless By Marcaroni Union (Discuss liscensing and implement ingame)
