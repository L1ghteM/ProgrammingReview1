using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePickUp : PickUp
{
    public override void Activate()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            enemy.GetComponent<Enemy>().speed = 0;
            enemy.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        Freeze();
        foreach (GameObject enemy in enemies)
        {
            enemy.GetComponent<Enemy>().speed = 3;
            enemy.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
    IEnumerator Freeze()
    {
        yield return new WaitForSeconds(3);
    }
}
