using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondQuestion : MonoBehaviour
{
    public SpriteRenderer self;

    void OnMouseUpAsButton()
    {
        if (self.enabled)
        {
            self.enabled = false;
            this.transform.position = new Vector3(0, 0, 1);
        }
    }
}
