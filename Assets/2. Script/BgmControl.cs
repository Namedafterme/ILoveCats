using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmControl : MonoBehaviour
{

    private AudioSource playlist;
    [SerializeField] private AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        playlist = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        int music = Random.Range(0, 10);
        playlist.clip = clip[music];
        playlist.Play();
    }


}
