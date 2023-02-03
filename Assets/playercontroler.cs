using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public float speed = 10;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //wychylenie sterowania w osi pionowej
        float vertical = Input.GetAxis("Vertical");

        //wychylenie sterowania w osi poziomej
        float horizontal = Input.GetAxis("Horizontal");

        //pokaz w konsoli
        Debug.Log("Wychylenie w pionie: " + vertical.ToString() + ", w poziomie: " + horizontal);


        Vector3 movment = new Vector3(vertical, 0, horizontal);

        if (movment.magnitude > 0)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
        transform.position += movment * Time.deltaTime * speed;
    }
}
