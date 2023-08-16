using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int towerCost = 50;
    //[SerializeField] int upgratedTowerCost = 100;
    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();
        if(bank == null)
        {
            return false;
        }

        if(bank.CurrentBalance >= towerCost)
        {
            Instantiate(tower, position, Quaternion.identity);
            bank.Withdraw(towerCost);
            return true;
        }

        /*if(Input.GetMouseButton(1) && bank.CurrentBalance < upgratedTowerCost)
        {
            Instantiate(tower, position, Quaternion.identity);
            bank.Withdraw(upgratedTowerCost);
            return true;
        }*/

        return false;
        
    }
}
