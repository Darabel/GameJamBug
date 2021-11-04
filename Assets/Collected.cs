using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
   [SerializeField] Color32 hasFoodColor = new Color32 (255, 255, 255, 255);
   [SerializeField] Color32 noFoodColor = new Color32 (255, 255, 255, 255);
   bool hasFood;
   float destroyDelay = 0.5f;

   SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Food" && !hasFood)
    {
    Debug.Log("Food Collected");
    hasFood = true;
    Destroy(other.gameObject, destroyDelay);
    spriteRenderer.color = hasFoodColor;
    }
    if (other.tag == "Home" && hasFood)
    {
    Debug.Log("Food Delivered");
    hasFood = false;
    spriteRenderer.color = noFoodColor;
    }    
}

}
