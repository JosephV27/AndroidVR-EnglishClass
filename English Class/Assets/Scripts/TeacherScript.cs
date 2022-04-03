using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherScript : MonoBehaviour
{

    Animator anim;
    AudioSource audSource;
    bool videoEnded = false;
    //bool generated = false;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animator>();
        audSource = GetComponent<AudioSource>();
        
        anim.Play("idle");

        yield return new WaitForSeconds(80f);
        videoEnded = true;

        anim.SetInteger("Talking_no", 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (videoEnded && !generated)
        {
            anim.SetInteger("Talking_no", Random.Range(0,1));
            generated = true;
        }*/
    }

    /*void animation_event()
    {
        generated = false;
    }*/
}
