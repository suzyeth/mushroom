using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth =3;
    public float currentHealth { get; private set; }

    private UIMangger mangger;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, 12);

    }

    public void AddHealth(float _add)
    {
        currentHealth = Mathf.Clamp(currentHealth + _add, 0, 12);
        
    }

    


    void Update()
    {
        if (currentHealth == 0)
        {
            mangger.GameOver();
        }
        else if (currentHealth == 12)
        {
            mangger.Win();
        }


    }








}

