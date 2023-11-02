using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeAnimation : MonoBehaviour
{
    public Sprite MikeFrame1;
    public Sprite MikeFrame2;
    public Sprite MikeFrame3;
    public SpriteRenderer spriteRenderer;
    private float frameCounter;
    private float frameOn;

    // Update is called once per frame
    void Update()
    {/*
        switch (frameOn) {
            case 0:
                spriteRenderer.sprite = MikeFrame1;
                frameCounter++;
                break;
            case 1:
                spriteRenderer.sprite = MikeFrame2;
                frameCounter++;
                break;
            case 2:
                spriteRenderer.sprite = MikeFrame1;
                frameCounter++;
                break;
            case 3:
                spriteRenderer.sprite = MikeFrame3;
                frameCounter++;
                break;
        }
        if (frameCounter > 10)
        {
            frameCounter = 0;
            frameOn++;
            if (frameOn > 3) frameOn = 0;
        }
        */
    }
}
