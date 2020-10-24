using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Bike m_PlayerBike;
    public Bike m_AndroidBike;
    public Bike m_BingBotBike;
    public Bike m_HatsumeBike;

    void Awake()
    {
        //human on jet
        IEngine jetEngine = new JetEngine();
        IDriver humanDriver = new HumanDriver();

        m_PlayerBike.SetEngine(jetEngine);
        m_PlayerBike.SetDriver(humanDriver);
        m_PlayerBike.StartEngine();

        //AI on turbo
        IEngine turboEngine = new TurboEngine();
        IDriver androidDriver = new AndroidDriver();

        m_AndroidBike.SetEngine(turboEngine);
        m_AndroidBike.SetDriver(androidDriver);
        m_AndroidBike.StartEngine();

        //bingBot on search
        IEngine searchEngine = new SearchEngine();
        IDriver bingBotDriver = new BingBotDriver();

        m_BingBotBike.SetEngine(searchEngine);
        m_BingBotBike.SetDriver(bingBotDriver);
        m_BingBotBike.StartEngine();

        //Hatsume on Tenya
        IEngine tenyaEngine = new TenyaEngine();
        IDriver hatsumeDriver = new HatsumeDriver();

        m_BingBotBike.SetEngine(tenyaEngine);
        m_BingBotBike.SetDriver(hatsumeDriver);
        m_BingBotBike.StartEngine();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_PlayerBike.TurnLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_PlayerBike.TurnRight();
        }
    }
}
