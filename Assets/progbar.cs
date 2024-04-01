using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class progbar : MonoBehaviour
{

    [SerializeField]  private GameObject playerGO;
    [SerializeField]  private GameObject finishGO;
    public Image progressBar;
    private float maxDistance;
    void Start()
    {

        progressBar = GetComponent<Image>();
        maxDistance = finishGO.transform.position.x;
    }

    void Update()
    {

        if (progressBar.fillAmount < 1)
        {

            progressBar.fillAmount = playerGO.transform.position.x / maxDistance;
        }
    }

}