using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class nodeHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private GameObject turret;
    public GameObject turretPrefab;

    public Vector3 positionOffset;


    public void OnBeginDrag(PointerEventData eventData) //Mobile
    {
        if(turret != null)
        {
            Debug.Log("cant");
            return;
        }

        //build
        if(moneymanager.money >= moneymanager.turretPrice)
        {
            turret = (GameObject)Instantiate(turretPrefab, transform.position + positionOffset, transform.rotation);
            moneymanager.money = moneymanager.money - moneymanager.turretPrice;
        }
        else
        {
            //not enough money
        }
    }

    public void OnMouseDown() //PC
    {
        if (turret != null)
        {
            Debug.Log("cant");
            return;
        }

        //build
        if (moneymanager.money >= moneymanager.turretPrice)
        {
            turret = (GameObject)Instantiate(turretPrefab, transform.position + positionOffset, transform.rotation);
            moneymanager.money = moneymanager.money - moneymanager.turretPrice;
        }
        else
        {
            //not enough money
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
