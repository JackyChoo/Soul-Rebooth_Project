using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour {

    public GameObject endTrigger;

    void OnTriggerEnter(Collider endTrigger)
    {
        SceneManager.LoadScene(0);
    }

    }
