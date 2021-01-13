using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject jumpText;
    public AudioClip[] AudioClipArr;
    int jumpcount = 0;
    private int jumpCounter;
    public Rigidbody playerrb;
    public int jumpspeed;
    
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpcount == 0)
        {
            jumpcount = 1;
            jumpCounter++;
            jumpText.GetComponent<Text>().text = "Jump: " + jumpCounter;
            playerrb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);

            //audioSource.Play()
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            jumpcount = 0;
        }
    }
}
