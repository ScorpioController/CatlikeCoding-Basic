using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform armHours;
    [SerializeField] private Transform armMinutes;
    [SerializeField] private Transform armSeconds;

    private const float degressPerHour = 30f;
    private const float degressPerMinute = 6f;
    private const float degressPerSecond = 1f;

    private void Awake()
    {
        var now = DateTime.Now;
        armHours.localRotation = Quaternion.Euler(0f, now.Hour * degressPerHour, 0f);
        armMinutes.localRotation = Quaternion.Euler(0f, now.Minute * degressPerMinute, 0f);
        armSeconds.localRotation = Quaternion.Euler(0f, now.Second * degressPerSecond, 0f);
    }

    private void Update()
    {
        var now = DateTime.Now;
        armHours.localRotation = Quaternion.Euler(0f, now.Hour * degressPerHour, 0f);
        armMinutes.localRotation = Quaternion.Euler(0f, now.Minute * degressPerMinute, 0f);
        armSeconds.localRotation = Quaternion.Euler(0f, now.Second * degressPerSecond, 0f);
    }
}
