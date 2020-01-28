using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> audioclips = new List<AudioClip>();
    public AudioSource audioplayer;
    public bool shouldPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        audioplayer = GetComponent<AudioSource>();
        StartCoroutine("PlayBackgroundAudio");
    }

    public IEnumerable PlayBackgroundAudio()
    {
        while (shouldPlay)
        {
            Debug.Log("Isplaying");
            int index = (int)Random.Range(0, audioclips.Count);
            audioplayer.clip = audioclips[index];
            audioplayer.Play();
            yield return audioplayer.clip.length;
        }
        
    }
}
