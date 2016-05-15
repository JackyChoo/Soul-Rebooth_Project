using UnityEngine;
using System.Collections;

public class S_CameraBroom : MonoBehaviour {
    public GameObject TargetObject;
    public Vector3 Offset;
	// Use this for initialization
	void Start () {
        Offset = transform.position - TargetObject.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = TargetObject.transform.position + Offset;
    }
}
