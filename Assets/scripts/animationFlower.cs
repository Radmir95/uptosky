using UnityEngine;
using System.Collections;

public class animationFlower : MonoBehaviour {

    public Sprite flowerSleep; // Drag your first sprite here
    public Sprite flower1; // Drag your second sprite here


    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = flowerSleep; // set the sprite to sprite1
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // If the space bar is pushed down
        {
            ChangeTheDarnSprite(); // call method to change sprite
        }
    }

    void ChangeTheDarnSprite()
    {
        if (spriteRenderer.sprite == flowerSleep) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = flower1;
        }
        else
        {
            spriteRenderer.sprite = flowerSleep; // otherwise change it back to sprite1
        }
    }
}
