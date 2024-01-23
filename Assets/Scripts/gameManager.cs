using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;


public enum CharacterType
{
    Penguin,
    Frog
}

[System.Serializable]
public class Charater
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;

}
public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public List<Charater> CharacterList = new List<Charater>();
    public Animator PlayerAnimator;
    public  Text PlayerName;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

    }

    public void SetCharacter(CharacterType characterType , string name)
    {
        var character = gameManager.instance.CharacterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
