using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource Mer;
    public AudioSource Ter;
    public AudioSource Mar;
    public AudioSource Jup;
    public AudioSource Nep;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void P1()
    {
        Mer.Play();
        Ter.Pause();
        Mar.Pause();
        Jup.Pause();
        Nep.Pause();

    }
    public void P2()
    {
        Mer.Pause();
        Ter.Play();
        Mar.Pause();
        Jup.Pause();
        Nep.Pause();

    }
    public void P3()
    {
        Mer.Pause();
        Ter.Pause();
        Mar.Play();
        Jup.Pause();
        Nep.Pause();

    }
    public void P4()
    {
        Mer.Pause();
        Ter.Pause();
        Mar.Pause();
        Jup.Play();
        Nep.Pause();

    }
    public void P5()
    {
        Mer.Pause();
        Ter.Pause();
        Mar.Pause();
        Jup.Pause();
        Nep.Play();

    }
}
