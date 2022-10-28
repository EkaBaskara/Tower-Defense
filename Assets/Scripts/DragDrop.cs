using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    [HideInInspector]
    public Vector3 screenPoint;
    [HideInInspector]
    public Vector3 offset;
    [HideInInspector]
    public int cost;
    [HideInInspector]
    public bool follow = true;

    void Update()
    {
       if (follow)
        {
            Vector3 curScreenPonit = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPonit) + offset;
            transform.position = curPosition;
            if (Input.GetMouseButtonUp(0))
            {
                if (transform.position.x < 0 && transform.position.y > -2f)
                {
                    follow = false;
                    Data.coin -= cost;
                    foreach (Behaviour childComponent in GetComponentsInChildren<Behaviour>())
                        childComponent.enabled = true;
                }
                else
                {
                    Destroy(gameObject);
                    Debug.Log("Meletakan area yang tidak diizinkan");
                }
            }
        }  
    }
}
