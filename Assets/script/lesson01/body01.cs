using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body01 : MonoBehaviour
{

    public GameObject body1;
    public GameObject body2;
    public GameObject body3;
    public GameObject body4;

    public GameObject switch_body;
    public GameObject switch_body1;
    public GameObject switch_body2;
    public GameObject switch_body3;
    public GameObject switch_body4;
    public GameObject SE;

    // Start is called before the first frame update
    void Start()
    {

        body1.SetActive(true);
        body2.SetActive(false);
        body3.SetActive(false);
        body4.SetActive(false);

    }

    void Update()
    {

        if (switch_body && Input.GetKeyDown(KeyCode.Alpha1))
        {
            body1.SetActive(true);
            body2.SetActive(false);
            body3.SetActive(false);
            body4.SetActive(false);
            switch_body1.SetActive(true);
            switch_body2.SetActive(false);
            switch_body3.SetActive(false);
            switch_body4.SetActive(false);
            Invoke("Call", 1.0f);
            SE.SetActive(true);
            Invoke("SE_change", 0.5f);
        }

        if (switch_body && Input.GetKeyDown(KeyCode.Alpha2))
        {
            {
                body1.SetActive(false);
                body2.SetActive(true);
                body3.SetActive(false);
                body4.SetActive(false);
                switch_body1.SetActive(false);
                switch_body2.SetActive(true);
                switch_body3.SetActive(false);
                switch_body4.SetActive(false);
                Invoke("Call2", 1.0f);
                SE.SetActive(true);
                Invoke("SE_change", 0.5f);
            }
        }

        if (switch_body && Input.GetKeyDown(KeyCode.Alpha3))
        {
            body1.SetActive(false);
            body2.SetActive(false);
            body3.SetActive(true);
            body4.SetActive(false);
            switch_body1.SetActive(false);
            switch_body2.SetActive(false);
            switch_body3.SetActive(true);
            switch_body4.SetActive(false);
            Invoke("Call3", 1.0f);
            SE.SetActive(true);
            Invoke("SE_change", 0.5f);
        }

        if (switch_body && Input.GetKeyDown(KeyCode.Alpha4))
        {
            {
                body1.SetActive(false);
                body2.SetActive(false);
                body3.SetActive(false);
                body4.SetActive(true);
                switch_body1.SetActive(false);
                switch_body2.SetActive(false);
                switch_body3.SetActive(false);
                switch_body4.SetActive(true);
                Invoke("Call4", 1.0f);
                SE.SetActive(true);
                Invoke("SE_change", 0.5f);
            }
        }

        


        // void Call()

        // {
        //switch_body2.SetActive(true);
        //  }

        //  void Call2()

        //  {
        //switch_body3.SetActive(true);
        //  }

        //  void Call3()

        //   {
        //switch_body4.SetActive(true);
        //   }


        //   void Call4()

        //   {
        //switch_body1.SetActive(true);
        //   }




    }

    void SE_change()

    {
        SE.SetActive(false);

    }
}


            //     public void bodymove1()
            // {
            //     body1.SetActive(false);
            //     body2.SetActive(true);
            //     body3.SetActive(false);
            //     body4.SetActive(false);
            // }


            // public void bodymove2()
            // {
            //     body1.SetActive(false);
            //     body2.SetActive(false);
            //     body3.SetActive(true);
            //     body4.SetActive(false);
            // }

            //  public void bodymove3()
            //  {
            //      body1.SetActive(false);
            //      body2.SetActive(false);
            //       body3.SetActive(false); 
            //      body4.SetActive(true);
            //  }

            //  public void bodymove4()
            //  {
            //      body1.SetActive(true);
            //      body2.SetActive(false);
            //      body3.SetActive(false);
            //      body4.SetActive(false);
            //  }
       