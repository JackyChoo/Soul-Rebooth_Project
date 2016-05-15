using UnityEngine;
using System.Collections;

public class S_ToggleSwitch : MonoBehaviour {
    public Material OriginalMat;
    public Material ChangeTo;
    public GameObject[] ReactWith;
    public bool CanOpen;
    private AudioSource AS;
    private Renderer Ren;

    // Use this for initialization
    void Start()
    {
        Ren = GetComponent<Renderer>();
        AS = GetComponent<AudioSource>();
        CanOpen = false;
    }

    void OnTriggerEnter(Collider ReactWith)
    {
        if (CanOpen == false)
        {
            AS.Play();
        }
        else if (CanOpen == true)
        {
            AS.Stop();
        }
    }

    void OnTriggerStay(Collider ReactWith)
    {
        Ren.material = ChangeTo;
        CanOpen = true;
    }

    void OnTriggerExit(Collider ReactWith)
    {
        Ren.material = OriginalMat;
        CanOpen = false;
    }
}
