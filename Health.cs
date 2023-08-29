using System Collections;
using Collections Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
   [SerializeField] private float MaxHealth;
   private float currentHealth;


   private void Awake()
   {
      currentHealth = MaxHealth;
   }
  public void TakeDamage(float _damage)
  {
    currentHealth = Mathf.Clamp(currentHealth - _damage,0, MaxHealth)
    if(currentHealth > 0)
    {
       Invoke("Heal",3);
    }
    else
    {
      Application.Quit();
    }
    public void Heal(float _damage)
    {
      currentHealth= Mathf.Clamp(currentHealth + _damage,0, MaxHealth)
      if(currentHealth>MaxHealth)
      currentHealth=MaxHealth;
      
    }
  }


}