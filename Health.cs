using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHp = 100;
    private int currentHP;

    public int MaxHp => maxHp;
    public int CurrentHP => currentHP;


    public UnityEvent<int> Healed;
    public UnityEvent<int> Damaged;
    public UnityEvent<int> Died;



    void Awake()
    {
        currentHP = maxHp;

    }

    public int HP
    {
        get => currentHP;
        private set
        {
            var isDamage = value < currentHP;
            currentHP = Mathf.Clamp(value, 0, maxHp);
            if (isDamage)
            {
                Damaged?.Invoke(currentHP);
            }
            else
            {
                Healed?.Invoke(currentHP);
            }
            if (HP<=0)
            {
                gameObject.SetActive(false);
                Died?.Invoke(currentHP);
            }
            
        }
    }

    

    public void Damage(int amount) => currentHP -= amount;
    

    public void Heal(int amount) => currentHP += amount;


    public void MaxHeal() => currentHP = maxHp;
    

    public void Kill() => currentHP = 0;
    

    public void Adjust(int amount) => currentHP = amount;
    

    public void AdjustMAX(int amount) => maxHp = amount;
    

}
