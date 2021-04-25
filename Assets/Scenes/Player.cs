using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;	

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
		if(collision.gameObject.tag=="Enemy")
		{
			TakeDamage(20);
		}

		if(collision.gameObject.tag=="Enemy" && currentHealth == 0)
		{
			SceneManager.LoadScene("DeathScreen"); 
		}

		if(collision.gameObject.tag=="Data")
		{
			SceneManager.LoadScene("Win Screen"); 
		}

    }


	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth); 
	}
}