using UnityEngine;
using UnityEngine.EventSystems;

public class rayCamera : MonoBehaviour {

    public float rayLenght;
    public LayerMask layerMask;

    private int turns = 1;

    private void Update()
    {
        GameplayTurns();
    }

    private void GameplayTurns()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght, layerMask))
            {
                if (turns == 1)
                {
                    if (hit.collider.name == "BlueCamp(Clone)")
                    {
                        Debug.Log("Selected");
                        turns++;
                    }
                }
                if (turns == 2)
                {
                    if (hit.collider.name == "GreenCamp(Clone)")
                    {
                        Debug.Log("Selected");
                        turns++;
                    }
                }
                if (turns == 3)
                {
                    if (hit.collider.name == "GreenCamp(Clone)")
                    {
                        Debug.Log("Selected");
                        turns = 1;
                    }
                }
            }
        }
    }
}

