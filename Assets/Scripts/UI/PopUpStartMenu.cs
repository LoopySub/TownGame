using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PopUpStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField inputField;
   
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;

   
    private CharacterType characterType;
    public void OnClickCharater()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterType = (CharacterType)index;
        var character = gameManager.instance.CharacterList.Find(item => item.CharacterType == characterType);

        characterSprite.sprite = character.CharacterSprite;
        

        selectCharacter.SetActive(false);
        information.SetActive(true);
    }

  public void OnClickJoint()
    {
        if(!(2 <inputField.text.Length  &&  inputField.text.Length <10))
        {
            return;
        }

        gameManager.instance.SetCharacter(characterType, inputField.text);

        Destroy(gameObject);
    }
}
