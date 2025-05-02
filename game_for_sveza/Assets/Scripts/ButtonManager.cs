using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject buildingManager;
    [SerializeField] private GameObject buildingButtonPrefab;
    [SerializeField] private Transform contentParent;


    private GameObject[] buildings;

    void Start()
    {
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }


        buildings = buildingManager.GetComponent<BuildingManager>().buildingObjects;
        foreach (GameObject obj in buildings)
        {
            GameObject newButton = Instantiate(buildingButtonPrefab, contentParent);
            BuildingButton buildingButton = newButton.AddComponent<BuildingButton>();

            Building building = obj.GetComponent<Building>();
            //if (building.IsActive())
            //{
            //    newButton.SetActive(true);
            //}
            //else
            //{
            //    newButton.SetActive(false);
            //}

            //buildingButton.SetData(building, newButton);
        }
    }

    void OnStageButtonClicked(int index)
    {
        Debug.Log(index);
        //buildingManager.ActivateBuilding(index);
    }
}
