using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredPickUp : PickUp
{
    public override void Activate()
    {
        StartCoroutine(PoweredUp());
    }
    IEnumerator PoweredUp()
    {
        player.spriteRenderer.sprite = player.madSprite;
        player.isPowered = true;
        yield return new WaitForSeconds(5);
        player.spriteRenderer.sprite = player.aliveSprite;
        player.isPowered = false;
    }
}
