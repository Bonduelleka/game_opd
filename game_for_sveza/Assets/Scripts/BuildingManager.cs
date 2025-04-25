using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildingObjects;
    public Building[] buildings;


    private void Awake()
    {
        buildings = new Building[buildingObjects.Length];

        for (int i = 0; i < buildingObjects.Length; i++)
        {
            buildings[i] = buildingObjects[i].GetComponent<Building>();

            if (buildings[i] == null)
            {
                Debug.LogError($"На объекте {buildingObjects[i].name} нет компонента Building!");
            }
        }
        //Debug.Log(buildings[4].price);
    }



    public void ActivateBuilding(int index)
    {
        //if (index < 0 || index >= buildings.Length)
        //{
        //    Debug.LogWarning("Индекс вне диапазона: " + index);
        //    return;
        //}

        // Включаем нужное здание
        //buildings[index].SetActive(true);

        // (Опционально) отключаем все остальные здания, если нужно
        //for (int i = 0; i < buildings.Length; i++)
        //{
        //    if (i != index)
        //        buildings[i].SetActive(false);
        //}

        Debug.Log($"Активировано здание: {index}");
    }
}
