# 🏠 Villa Capstone Project — Unity 6.2 VR

**Author:** Muhannad Anwar & Hussaen Alaa
**Instructor:** Eng. Hatem Heshmat  
**Course:** Professional 3D & VR Designer — Module 1  
**Date:** October 2025  

---

## 🎯 Project Overview

This Unity project showcases a **VR environment and gameplay prototype** developed as part of the Capstone Project for the *Professional 3D & VR Designer* course.  

The experience takes place in a **villa backyard and basketball court**, allowing the player to explore, teleport, and interact with objects in a realistic outdoor setting. The project demonstrates foundational VR interaction systems built for **Meta Quest 2/3** using **Unity 6.2 LTS** and the **Meta XR All-in-One SDK (v65)**.

---

## 🧱 Features Implemented

✅ Player locomotion (continuous + snap turn)  
✅ Hand grabbing and object manipulation  
✅ Ray interactor with UI canvas  
✅ Basic lighting and skybox setup  
✅ Optimized performance for Quest 2/3  

---

## 🛠️ Tools & Packages Used

| Tool / Package | Version | Purpose |
|----------------|----------|----------|
| Unity | 6.2 LTS | Game engine |
| Meta XR All-in-One SDK | v65 | VR input, teleportation, grab system |
| XR Interaction Toolkit | 3.2.1 | Extended VR interactions |
| URP (Universal Render Pipeline) | Default | Rendering & lighting |
| Shader Graph | — | Custom materials |
| Visual Studio | 2022 | C# scripting |

---

## 📁 Project Structure

```
Assets/
├── Prefabs/
│   ├── PFB_Building_Full.prefab
│   ├── PlayerFPS.prefab
│   ├── Room.prefab
│
├── Scenes/
│   └── AmericanHome_Backyard.unity
│
├── Scripts/
│   ├── HoopTrigger.cs
│   ├── LightSwitchController.cs
│   └── ScoreManager.cs
│
└── Tools/
    ├── Door_2.05x0.9.prefab
    ├── Human_1.75m.prefab
    ├── Ruler_1m.prefab
    ├── XR Origin Hands (XR Rig).prefab
    └── TutorialInfo.meta
```
