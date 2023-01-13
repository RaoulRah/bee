using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
   
   [SerializeField]private InputActionReference _MenuAction;
   [SerializeField]private GameObject _menu;

    void Start()
    {
        _MenuAction.action.Enable();
        _MenuAction.action.performed += ActionMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ActionMenu(InputAction.CallbackContext obj){

        if(!_menu.activeSelf){
            _menu.SetActive(true);
        }else{
            _menu.SetActive(false);
        }
    }

}
