using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildingObjects;
    public Building[] buildings;
    private int countOfActiveBuildings;

    private void Awake()
    {
        countOfActiveBuildings = FindObjectOfType<DataSaver>().countOfActiveBuildings;
        buildings = new Building[buildingObjects.Length];

        for (int i = 0; i < buildingObjects.Length; i++)
        {
            buildings[i] = buildingObjects[i].GetComponent<Building>();

            if (buildings[i] == null)
            {
                Debug.LogError($"На объекте {buildingObjects[i].name} нет компонента Building!");
            }
            else if (i < countOfActiveBuildings)
            {
                buildings[i].ChangeStatus();
            }
        }
        //Debug.Log(buildings[4].price);
    }

    public Building[] GetBuildings()
    {
        return buildings;
    }
}
