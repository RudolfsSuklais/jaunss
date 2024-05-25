using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{

    public Sprite[] spriteArray;
    public Sprite[] spriteArray2;
    public Sprite[] spriteArray3;
    public Sprite[] shirt;
    public Sprite[] socks;
    public Sprite[] boots;
    public Sprite[] character;
    public GameObject imageHolder;
    public GameObject imageHolderBadge;
    public GameObject imageHolderBadge2;
    public GameObject imageHolderBadge3;
    public GameObject imageHolderBadge4;
    public GameObject imageHolderShirt;
    public GameObject imageHolderSocks;
    public GameObject imageHolderBoots;
    public GameObject shorts;
    public GameObject Shirt;
    public GameObject Socks;
    public GameObject Boots;
    public GameObject Slider;
    public GameObject Slider2;
    public GameObject MainCharacter;
    public float width;
    public float height;
    public string selectedCharacter;




    private int currentIndex = 0;
    private int currentIndexShirt = 0;
    private int currentIndexSocks = 0;
    private int currentIndexBoots = 0;

    public void changeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[index];
            currentIndex = index;
        }
    }
    public void changeImage2(int index)
    {
        if (index >= 0 && index < spriteArray2.Length)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray2[index];
            currentIndex = index;
        }
    }
    public void changeWidth()
    {
        height = Slider2.GetComponent<Slider>().value;
        width = Slider.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * width, height);
        MainCharacter.transform.localScale = new Vector2(1F * width, height);
        imageHolderShirt.transform.localScale = new Vector2(1F * width, height);
        imageHolderSocks.transform.localScale = new Vector2(1F * width, height);
        imageHolderBoots.transform.localScale = new Vector2(1F * width, height);


    }
    public void changeHeight()
    {
        width = Slider.GetComponent<Slider>().value;
        height = Slider2.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(width, 1F * height);
        MainCharacter.transform.localScale = new Vector2(width, 1F * height);
        imageHolderShirt.transform.localScale = new Vector2(width, 1F * height);
        imageHolderSocks.transform.localScale = new Vector2(width, 1F * height);
        imageHolderBoots.transform.localScale = new Vector2(width, 1F * height);
    }
    public void showShorts(bool value)
    {
        shorts.SetActive(value);
    }
    public void changeImageRight()
    {
        currentIndex = (currentIndex + 1) % spriteArray.Length;
        imageHolder.GetComponent<Image>().sprite = spriteArray[currentIndex];
        imageHolderBadge.GetComponent<Image>().sprite = spriteArray2[currentIndex];
    }
    public void changeImageLeft()
    {
        currentIndex = (currentIndex - 1 + spriteArray.Length) % spriteArray.Length;
        imageHolder.GetComponent<Image>().sprite = spriteArray[currentIndex];
        imageHolderBadge.GetComponent<Image>().sprite = spriteArray2[currentIndex];
    }

    //Shirt changer
    public void changeImage3(int index)
    {
        if (index >= 0 && index < shirt.Length)
        {
            imageHolderShirt.GetComponent<Image>().sprite = shirt[index];
            currentIndexShirt = index;
        }
    }
    public void changeImageRightShirt()
    {
        currentIndexShirt = (currentIndexShirt + 1) % shirt.Length;
        imageHolderShirt.GetComponent<Image>().sprite = shirt[currentIndexShirt];
        imageHolderBadge2.GetComponent<Image>().sprite = spriteArray2[currentIndexShirt];
    }
    public void changeImageLeftShirt()
    {
        currentIndexShirt = (currentIndexShirt - 1 + shirt.Length) % shirt.Length;
        imageHolderShirt.GetComponent<Image>().sprite = shirt[currentIndexShirt];
        imageHolderBadge2.GetComponent<Image>().sprite = spriteArray2[currentIndexShirt];
    }

    public void showShirt(bool value)
    {
        Shirt.SetActive(value);
    }

    //Socks changer

    public void changeImage4(int index)
    {
        if (index >= 0 && index < shirt.Length)
        {
            imageHolderSocks.GetComponent<Image>().sprite = socks[index];
            currentIndexSocks = index;
        }
    }
    public void changeImageRightSocks()
    {
        currentIndexSocks = (currentIndexSocks + 1) % socks.Length;
        imageHolderSocks.GetComponent<Image>().sprite = socks[currentIndexSocks];
        imageHolderBadge3.GetComponent<Image>().sprite = spriteArray2[currentIndexSocks];
    }
    public void changeImageLeftSocks()
    {
        currentIndexSocks = (currentIndexSocks - 1 + socks.Length) % socks.Length;
        imageHolderSocks.GetComponent<Image>().sprite = socks[currentIndexSocks];
        imageHolderBadge3.GetComponent<Image>().sprite = spriteArray2[currentIndexSocks];
    }

    public void showSocks(bool value)
    {
        Socks.SetActive(value);
    }

    //Boots changer

    public void changeImage5(int index)
    {
        if (index >= 0 && index < boots.Length)
        {
            imageHolderBoots.GetComponent<Image>().sprite = boots[index];
            currentIndexBoots = index;
        }
    }
    public void changeImageRightBoots()
    {
        currentIndexBoots = (currentIndexBoots + 1) % boots.Length;
        imageHolderBoots.GetComponent<Image>().sprite = boots[currentIndexBoots];
        imageHolderBadge4.GetComponent<Image>().sprite = spriteArray3[currentIndexBoots];
    }
    public void changeImageLeftBoots()
    {
        currentIndexBoots = (currentIndexBoots - 1 + boots.Length) % boots.Length;
        imageHolderBoots.GetComponent<Image>().sprite = boots[currentIndexBoots];
        imageHolderBadge4.GetComponent<Image>().sprite = spriteArray3[currentIndexBoots];
    }

    public void showBoots(bool value)
    {
        Boots.SetActive(value);
    }




    public void changeCharacter(int index)
    {
        if (index == 0)
        {
            MainCharacter.GetComponent<Image>().sprite = character[0];
            selectedCharacter = "balts";


        }
        else
        {
            MainCharacter.GetComponent<Image>().sprite = character[1];
            selectedCharacter = "melns";
        }

    }
}
