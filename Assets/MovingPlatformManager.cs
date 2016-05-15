using UnityEngine;
using System.Collections;

public class MovingPlatformManager : MonoBehaviour {

    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;

	// Use this for initialization
	void Start () {
        ChangeTarget();
	}
	
	// Update is called once per frame
	void Update () {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}

    void ChangeTarget()
    {
        if (currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        else if (currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 1";
            newPosition = position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }

        Invoke("ChangeTarget", resetTime);
    }
}
