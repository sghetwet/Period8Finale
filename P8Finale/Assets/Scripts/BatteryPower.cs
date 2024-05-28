using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class BatteryPower : MonoBehaviour
{
    public int maxPower = 3;
    public int currentPower;


    void Start()
    {
        currentPower = maxPower;
    }

    void TakeDamage(int amount)
    {
        currentPower -= amount;

        if (currentPower < 0)
        {
            //dead, play anim, show game over
        }

    }
    void Heal(int amount)
    {
        currentPower += amount;

        if (currentPower > maxPower)
        {
            //dead, play anim, show game over
        }
    }
}
