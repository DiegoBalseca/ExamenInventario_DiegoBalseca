using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   static public InventoryManager Instance;
   void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

public ScriptableItem[] Item;
public ScriptableText[] itemName;
public ScriptableImage[] itemImage;

public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < item.Lenght; i ++)
        {
            if (item[i]= null)
            {
                Item [i] = item;
                itemsName[i].text ItemName item;
                itemsImage[i].Sprite ItemSprite item;

                itemsSlot[i].Slot ItemSlot item;
                items[i] = i

                return;
            }
        }
    }

}
