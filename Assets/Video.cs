using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public AudioSource audioSource;
    private void Awake()
    {
        VideoPlayer.Play();
        audioSource.Play();
    }

}
