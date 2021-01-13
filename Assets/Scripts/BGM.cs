using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] AudioClipArr;
    private AudioSource audioSource;
    int tabcounter = 0;
    float vol = 0.5f;
    float volrate = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Stop();
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
       
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            vol = vol + (volrate * Time.deltaTime);
            audioSource.volume = vol;
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            vol = vol - (volrate * Time.deltaTime);
            audioSource.volume = vol;
        }

    }
}
