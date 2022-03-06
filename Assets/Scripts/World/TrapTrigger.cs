using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] float damage = 10;

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Trap collision");
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Trap Damage");
            collision.gameObject.GetComponentInParent<Health>().TakeDamage(damage);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trap collision");
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Trap Damage");
            other.gameObject.GetComponentInParent<Health>().TakeDamage(damage);
        }
    }
}
