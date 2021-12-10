using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject,ISerializationCallbackReceiver
{
    public Item currentItem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;
    [HideInInspector]
    public float RuntimeValue;
    public void OnBeforeSerialize(){}
    public void OnAfterDeserialize(){
        RuntimeValue = numberOfKeys;
    }

    public void AddItem(Item itemToAdd){
        if(itemToAdd.isKey){
            RuntimeValue++;
        }else{
            if(!items.Contains(itemToAdd)){
                items.Add(itemToAdd);
            }
        }
    }
}
