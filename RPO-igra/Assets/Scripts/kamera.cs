using UnityEngine;
using System.Collections;

public class kamera : MonoBehaviour {

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform igralec;
    public float y = -0.85f;

    void Start()
    {
        igralec = GameObject.Find("player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (igralec)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(igralec.position);
            Vector3 delta = igralec.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, y, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }

}

