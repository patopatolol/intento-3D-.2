using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musica : MonoBehaviour
{
    [SerializeField]private AudioMixer auidoMixer;
    public void musica2 (float sliderMusica)
    {
        auidoMixer.SetFloat("audio",Mathf.Log10(sliderMusica) * 20);
    }

}
