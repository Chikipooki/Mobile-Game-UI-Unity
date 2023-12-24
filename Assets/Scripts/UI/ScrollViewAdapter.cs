using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewAdapter : MonoBehaviour
{
    [Header("Creating elements")]
    [SerializeField] public GameObject ItemPrefab;
    [SerializeField] private Transform ItemHolder;
    [SerializeField] private int numOfListItem;

    [Header("Layers")]
    [SerializeField] private LayerMask gameItemsLayer;

    public void ClearGameObjects()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            if (obj.layer == gameItemsLayer)
            {
                Destroy(obj);
            }
        }
    }

    public void AddItems()
    {
        ClearGameObjects();

        for (int i = 0; i < numOfListItem; i++)
        {
            GameObject newClone = Instantiate(ItemPrefab, ItemHolder);
            newClone.name = "GameItem " + (i + 1);
        }
    }

    public void RemoveItem(GameObject item)
    {
        Destroy(item);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Mathf.Infinity;
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, mousePosition - Camera.main.ScreenToWorldPoint(mousePosition),
                Mathf.Infinity, gameItemsLayer);

            if (hit.collider != null)
            {
                RemoveItem(hit.collider.gameObject);
            }
        }
    }
}