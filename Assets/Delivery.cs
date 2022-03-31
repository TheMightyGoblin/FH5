using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   bool ppu;
    [SerializeField]Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField]Color32 noPackageColor = new Color32(1,1,1,1);
    SpriteRenderer spriteRenderer;
    [SerializeField]float dtime = 1f;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !ppu)
        {
            Debug.Log("Package picked up");
            ppu = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,dtime);
        }
        if(other.tag =="Customer" && ppu)
        {
            Debug.Log("Package delivered");
            ppu = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
