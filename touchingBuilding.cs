using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchingBuilding : MonoBehaviour
{
    public SpriteRenderer question;
    public GameObject questionObject;

    void OnMouseUpAsButton()  
    {
        question.enabled = true;
        questionObject.transform.position = new Vector3(0,0,-3);
    }
}
