using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importe, lai varetu darboties ar pointer interfeisu
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,
			 IDragHandler, IEndDragHandler{

	public Canvas kanva;
	private RectTransform transformacijaslogs;

	// Use this for initialization
	void Start () {
		transformacijaslogs = GetComponent<RectTransform>();
	}
	
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log("Izdarits kreisais klikskis uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log("Uzsakta objekta vilksana!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log("Notiek objekta vilksana!");
		transformacijaslogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log("Beigta objekta vilksana!");
	}
}
