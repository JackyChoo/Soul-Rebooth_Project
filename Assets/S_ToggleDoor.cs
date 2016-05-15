using UnityEngine;
using System.Collections;

public class S_ToggleDoor : MonoBehaviour {
    public Material OriMat;
    public Material ChangeMat;
    private S_ToggleSwitch GetInfo;
    private Renderer Ren;
    private Collider Col;

	// Use this for initialization
	void Start () {
        Ren = GetComponent<Renderer>();
        GetInfo = GetComponentInParent<S_ToggleSwitch>();
        Col = GetComponent<Collider>();
        Col.enabled = true;
	}

	// Update is called once per frame
	void Update () {
        if (GetInfo.CanOpen == true)
        {
            Ren.material = ChangeMat;
            Col.enabled = false;
        }
        else if(GetInfo.CanOpen == false)
        {
            Ren.material = OriMat;
            Col.enabled = true;
        }
	}
}
