using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
    public float PlayerSpeed = 5;
    public GameObject movingPlatform;

    Rigidbody mybody;
    bool EnterLift;
    bool Up = false;
    bool Down = false;
    bool Left = false;
    bool Right = false;

    void Start () {
        mybody = GetComponent<Rigidbody>();
        EnterLift = false;
	}

    void Update()
    {
        if (EnterLift == false)
        {
            if (Up == true)
            {
                Vector3 movement = new Vector3(PlayerSpeed, 0, 0) * Time.deltaTime;

                mybody.MovePosition(transform.position + movement);
            }

            if (Down == true)
            {
                Vector3 movement = new Vector3(-PlayerSpeed, 0, 0) * Time.deltaTime;

                mybody.MovePosition(transform.position + movement);
            }

            if (Left == true)
            {
                Vector3 movement = new Vector3(0, 0, PlayerSpeed) * Time.deltaTime;

                mybody.MovePosition(transform.position + movement);
            }

            if (Right == true)
            {
                Vector3 movement = new Vector3(0, 0, -PlayerSpeed) * Time.deltaTime;

                mybody.MovePosition(transform.position + movement);
            }
        }
        else if (EnterLift == true)
        {
            if (Up == true)
            {
                transform.Translate(PlayerSpeed * Time.deltaTime, 0, 0);
            }
            if (Down == true)
            {
                transform.Translate(-PlayerSpeed * Time.deltaTime, 0, 0);
            }
            if (Left == true)
            {
                transform.Translate(0, 0, PlayerSpeed * Time.deltaTime);
            }
            if (Right == true)
            {
                transform.Translate(0, 0, -PlayerSpeed * Time.deltaTime);
            }
        }
    }

    public void Up_Down()
    {
        Up = true;
    }

    public void Up_Up()
    {
        Up = false;
    }

    public void Down_Down()
    {
        Down = true;
    }

    public void Down_Up()
    {
        Down = false;
    }

    public void Left_Down()
    {
        Left = true;
    }

    public void Left_Up()
    {
        Left = false;
    }

    public void Right_Down()
    {
        Right = true;
    }

    public void Right_Up()
    {
        Right = false;
    }

    void OnTriggerEnter(Collider movingPlatform)
    {
        EnterLift = true;
    }
}
