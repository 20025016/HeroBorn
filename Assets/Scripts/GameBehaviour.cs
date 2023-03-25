using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private int _itemsCollected = 0;
    private int _playerHealth = 10;

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }

    public int PlayerHealth
    {
        get { return _playerHealth; }
        set
        {
            _playerHealth = value;
            Debug.LogFormat("Lives: {0}", _playerHealth);
        }
    }
}
