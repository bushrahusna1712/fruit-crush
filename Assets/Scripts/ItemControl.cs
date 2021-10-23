using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    [SerializeField] float speed = 4;
    [SerializeField] bool isDynamite = false;
    [SerializeField] int itemPoints = 50;

    GameControl myGameControl;
    Rigidbody2D myRigidbody;
    AudioSource myAudioSource;
    [SerializeField] AudioClip myClip;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myGameControl = GameObject.Find("Game Manager").GetComponent<GameControl>();
        myAudioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        Spawn();
    }

    void Spawn()
    {
        transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        myRigidbody.velocity = Random.insideUnitCircle.normalized * speed;
    }

    private void OnMouseDown()
    {
        if(isDynamite)
        {
            //game over
            myGameControl.GameOver();
        }
        else
        {
            //add points
            myGameControl.AddPoints(itemPoints);
            myAudioSource.PlayOneShot(myClip);
            Spawn();
        }
    }
}
