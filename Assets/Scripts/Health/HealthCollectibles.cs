using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectibles : MonoBehaviour
{
    [SerializeField] private float healthValue;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            this.gameObject.SetActive(false);


        }
    }
}
