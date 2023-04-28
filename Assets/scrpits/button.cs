using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class button : MonoBehaviour
{
    SpriteRenderer sprite;
    public GameObject bulletPrefab;
  


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    

    
    private void OnMouseEnter()
    {
        Debug.Log("Enter");
        sprite.color = new Vector4(0.7660378f, 0.5307939f, 0.5307939f, 0.9176471f);
    }

    private void OnMouseDown()
    {
        Debug.Log("UpAsButton");
        Instantiate(bulletPrefab, transform.position, transform.rotation);

        transform.Rotate(new Vector3(0, 0, 90));
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        transform.Rotate(new Vector3(0, 0, 90));
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        transform.Rotate(new Vector3(0, 0, 90));
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
    private void OnMouseExit()
    {
        Debug.Log("Up");
        sprite.color = new Vector4(1, 1, 1, 1);
    }


    
   
    void Update()
    {
       
    }


   
   
    



}









