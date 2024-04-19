using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public TileBase tile;
    public bool isStackable = true;
    public ActionType actionType;
    public ItemType item;
    public new string name;


    public enum ItemType
    {
        BuildingBlock,
        Tool
    }

    public enum ActionType
    {
        Mining,
        Digging,
        Building
    }



}
