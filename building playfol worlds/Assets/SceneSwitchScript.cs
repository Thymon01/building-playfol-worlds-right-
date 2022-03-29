using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitchScript : MonoBehaviour
{
   
    public GameObject sceneSwitch;
    public GameObject tikkiegroepred;
    public GameObject normalTikkieGroep;

    private void OnTriggerEnter2D(Collider2D other)
    {
        sceneSwitch.SetActive(true);
        tikkiegroepred.SetActive(true);
        normalTikkieGroep.SetActive(false);


    }
}
