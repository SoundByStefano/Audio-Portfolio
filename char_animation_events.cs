using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_animation_events : MonoBehaviour
{
    public string leftfootrun = "fs_char_leftfoot_run"; 
    public string rightfootrun = "fs_char_rightfoot_run";

    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj((gameObject));
        
    }
    
    void fs_char_leftfoot_run()
    {
        AkSoundEngine.PostEvent(leftfootrun, gameObject);
    
    }

     void fs_char_rightfoot_run()
    {
        AkSoundEngine.PostEvent(rightfootrun, gameObject);
    
    }        









}
