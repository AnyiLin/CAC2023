using UnityEngine;

public class expandCloseObjects : MonoBehaviour
{
    public GameObject detectObject;
    public float distance;
    public float scale;
    private Vector3 detectObjectScale;

    private float xVelocityRef = 0.0f;
    private float yVelocityRef = 0.0f;

    private void Start()
    {
        detectObjectScale = detectObject.transform.localScale;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Mathf.Sqrt(Mathf.Pow(detectObject.transform.position.x - this.transform.position.x, 2) + Mathf.Pow(detectObject.transform.position.y - this.transform.position.y, 2)) < distance)
        {
            detectObject.transform.localScale = new Vector3(Mathf.SmoothDamp(detectObject.transform.localScale.x, detectObjectScale.x*scale, ref xVelocityRef, 0.5f), Mathf.SmoothDamp(detectObject.transform.localScale.y, detectObjectScale.y * scale, ref yVelocityRef, 0.5f));
        } else
        {
            detectObject.transform.localScale = new Vector3(Mathf.SmoothDamp(detectObject.transform.localScale.x, detectObjectScale.x, ref xVelocityRef, 0.5f), Mathf.SmoothDamp(detectObject.transform.localScale.y, detectObjectScale.y, ref yVelocityRef, 0.5f));
        }
    }
}
