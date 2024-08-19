using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]

public class Ww_MaterialSwitchGrass : MonoBehaviour
{

    public string SwitchGroup = "Footsteps";
    public string Switch = "Grass";
    public string ExitSwitch = "Gravel";
    public GameObject Character; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") {return; }
        AkSoundEngine.SetSwitch(SwitchGroup, Switch, Character);

    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player") {return; }
        AkSoundEngine.SetSwitch(SwitchGroup, ExitSwitch, Character);

    }
}
