using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagement : MonoBehaviour {

    public CubeChanger cubeScript;
    public Image background;
    public Text activityCount;
    public Text timeCount;
    private float Transition = 0.0f;
    public float timelapse = 0.0f;
    public float timeLimit = 300.0f;

	// Use this for initialization
	void Start ()
    {
        Transition += Time.deltaTime;
        background.color = Color.Lerp(new Color(0, 0, 0, 255), Color.black, Transition);
        timelapse += Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        activityCount.text = ("Activities done: " + cubeScript.activitycount + "/ 30");
        timeCount.text = ("Time" + timelapse);

        //when we've reached the max activity or when time limit is reached.
		if((cubeScript.activitycount >= cubeScript.maxactcount) || timelapse == timeLimit)
        {
            Debug.Log("Experience is ending");
            background.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, Transition);
        }
    }
}
