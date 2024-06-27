using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class TrainingGrounds : MonoBehaviour
{
    public GameObject nameText;
    public GameObject upgradePanel;

    public GameObject upgradeAnim;
    public GameObject kartUpgradeAnim;

    private void Start()
    {
        nameText.SetActive(false);
        upgradePanel.SetActive(false);

        upgradeAnim.SetActive(false);
        kartUpgradeAnim.SetActive(false);
    }

    private void OnMouseEnter()
    {
        nameText.SetActive(!nameText.activeSelf);
    }

    private void OnMouseExit()
    {
        nameText.SetActive(false);
    }

    public void OnClickTask()
    {
        Debug.Log("123");
        if(upgradePanel.activeSelf)
        { upgradePanel.SetActive(false); }
        else
        { upgradePanel.SetActive(true); }
    }

    public void StartCo()
    {
        Debug.Log("123");
        StartCoroutine(nameof(Upgrade));
    }

    public IEnumerator Upgrade()
    {
        upgradeAnim.SetActive(true);

        yield return new WaitForSeconds(5f);

        upgradeAnim.SetActive(false);
        upgradePanel.SetActive(false);
        kartUpgradeAnim.SetActive(!kartUpgradeAnim.activeSelf);

    }

}
