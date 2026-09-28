using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFromDropdown : MonoBehaviour
{

    public List<GameObjectList> groupToToggle = new List<GameObjectList>(); // Array of GameObjects to toggle

    [Serializable]
    public class GameObjectList
    {
        public List<GameObject> gameObjects; // List of GameObjects for each dropdown option
    }


    public void ToggleObjects(int index)
    {
        // Loop through each array of GameObjects
        for (int i = 0; i < groupToToggle.Count; i++)
        {
            // If the current index matches the selected index, enable the objects
            if (i == index)
            {
                foreach (GameObject obj in groupToToggle[i].gameObjects)
                {
                    obj.SetActive(true);
                }
            }
            else // Otherwise, disable the objects
            {
                foreach (GameObject obj in groupToToggle[i].gameObjects)
                {
                    obj.SetActive(false);
                }
            }
        }
    }

}
