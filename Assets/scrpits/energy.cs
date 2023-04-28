using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class energy : MonoBehaviour
{
    [SerializeField] private float add;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "mushroom")
        {
            Debug.Log("PZ");
            collision.GetComponent<Health>().AddHealth(add);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
