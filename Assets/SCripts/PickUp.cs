using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    public Collider2D colliderPickUp;
    public SpriteRenderer spriteRenderer;
    public GameManager gm;
    public PlayerController player;
    public void Start()
    {
        colliderPickUp = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    public virtual void Activate()
    {

    }
    IEnumerator DelayedDestroy()
    {
        colliderPickUp.enabled = false;
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Activate();
            StartCoroutine(DelayedDestroy());
        }
    }
}
