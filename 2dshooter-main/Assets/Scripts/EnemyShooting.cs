using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    public float shotingRange = 8;
    public float timeBetweenShots = 1;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        //Debug.Log(distance); //para saber a qu� distancia est�

        if (distance < shotingRange)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenShots) 
            {
                timer = 0;
                //aqu� es donde ocurre el disparo 
                Shoot();

            }
        }
    }

    public void Shoot()
    {
        //instanciar objeto, en posici�n y en �ngulo.
        Instantiate(bullet, bulletPos.position, Quaternion.identity); 
    }
}
