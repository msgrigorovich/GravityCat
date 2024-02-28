// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class HapticSwitchButton : MonoBehaviour
// {
//     public void Vibration()
//     {
//         Handheld.Vibrate();
//     }

//     if (vibration())
//     {
//         HapticSwitchButtonAnim = HapticButtonStates.HapticOn;
//     }
//     else
//     {
//         HapticSwitchButtonAnim = HapticButtonStates.HapticOff;
//     }

//     private Animator anim;

//     private void Awake ()
//     {
//         anim = GetComponent<Animator>();
//     }
//     private HapticButtonStates HapticSwitchButtonAnim
//     {
//         get {return (HapticButtonStates)anim.GetInteger("HapticSwitchButtonAnim");}
//         set {anim.SetInteger("HapticSwitchButtonAnim", (int)value);}
//     }
// }

// public enum HapticButtonStates
// {
//     HapticOff,
//     HapticOn;
// }
