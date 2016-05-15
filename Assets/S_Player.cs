using UnityEngine;
using System.Collections;

public class S_Player : MonoBehaviour {
    public float PlayerSpeed = 5.0f;
    private Rigidbody Rig;
    private bool EnterLift;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 0, 0);
        Rig = GetComponent<Rigidbody>();
        EnterLift = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = new Quaternion(0, 0, 0, 0);


        if (EnterLift == false)
        {
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(hAxis, 0, vAxis) * PlayerSpeed * Time.deltaTime;

            Rig.MovePosition(transform.position + movement);
        }

        else if (EnterLift == true)
        {


            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime);
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider T_Lift)
    {
        EnterLift = true;
    }
}