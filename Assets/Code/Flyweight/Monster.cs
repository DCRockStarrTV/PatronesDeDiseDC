using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Monster : MonoBehaviour
{
    public Attributes dataScriptableObject;

    //private Image _spriteImage;
    private Text _nameText;
    private Text _descriptionText;

    private void Awake()
    {
        //_spriteImage = transform.Find("Sprite").GetComponent<Image>();
        _nameText = transform.Find("NameText").parent.GetComponent<Text>();
        _descriptionText = transform.Find("DescriptionText").GetComponent <Text>();

        //_spriteImage.sprite = dataScriptableObject.sprite;
        _nameText.text = dataScriptableObject.name;
        _descriptionText.text = dataScriptableObject.description;
    }
}
