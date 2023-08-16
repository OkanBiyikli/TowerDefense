using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Tower towerPrefabs;
    //public Tower upgratedTowerPrefab;
    public bool isPlaceble;
   
   //public bool IsPlaceble{  get {return isPlaceble;}}//isplaceble boolunu diğer scriptlerde çağırmak için bu fonksiyonu yazdık
   //ama zaten yukarıda public olarak yazdığımız için waypoint scriptinin componentini çağırıp public boolu çağırabiliriz
   
    void OnMouseDown() 
    {
        if(isPlaceble)
        {
        bool isPlaced = towerPrefabs.CreateTower(towerPrefabs, transform.position);
        isPlaceble = !isPlaceble;

        }
    }

    /*void UpgratedBalista()
    {
        if(Input.GetMouseButton(1))
        {
            if(isPlaceble)
            {
                bool isPlaced = upgratedTowerPrefab.CreateTower(upgratedTowerPrefab, transform.position);
                isPlaceble = !isPlaceble;
            }
        }
    }

    void Update()
    {
        UpgratedBalista();
    }*/

    
}
