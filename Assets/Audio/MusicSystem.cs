using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSystem : MonoBehaviour
{
    public AudioSource klangSound;
    public AudioSource bamSound;
    public AudioSource hajsSound;
    public AudioSource pukpukSound;
    public AudioSource susSound;
    public AudioSource swooshSound;


    public void PlaySwoosh()
    {
       
        swooshSound.Play();

    }
    public void PlayBam()
    {

        bamSound.Play();

    }
    public void PlayKlang()
    {

        klangSound.Play();

    }
    public void PlaySus()
    {

        susSound.Play();

    }
    public void PlayHajs()
    {

        hajsSound.Play();

    }
    public void PlayPukPuk()
    {

        pukpukSound.Play();

    }
}
