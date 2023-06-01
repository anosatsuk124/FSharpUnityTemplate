namespace FSharpUnityTemplate

open UnityEngine

type SimpleScript() =
   inherit MonoBehaviour()
   member this.Update() = Debug.Log("Nya! from F#")
