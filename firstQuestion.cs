using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstQuestion : MonoBehaviour
{
    public SpriteRenderer question;
    public GameObject questionObject;
    public SpriteRenderer self;

    void OnMouseUpAsButton()
    {
        if (self.enabled)
        {
            question.enabled = true;
            self.enabled = false;
            questionObject.transform.position = new Vector3(0, 0, -3);
            this.transform.position = new Vector3(0, 0, 1);
        }
    }
}
