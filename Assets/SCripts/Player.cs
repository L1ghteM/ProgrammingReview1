using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public GameManager gm;
    public Sprite deadSprite; // The new sprite to assign
    private Collider2D playerCollider;
    public Sprite aliveSprite;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            speed = 0;
            ChangeSprite();
            gm.playerLives--;
            playerCollider.enabled = false;
            StartCoroutine(Respawn());
        }
    }
    private void ChangeSprite()
    {
        if (deadSprite != null)
        {
            spriteRenderer.sprite = deadSprite;
        }
    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3);
        transform.Translate(Random.Range(-14, 14), Random.Range(-5, 5), 0);
        speed = 5;
        playerCollider.enabled = true;
        spriteRenderer.sprite = aliveSprite;
    }
}
