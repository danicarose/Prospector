using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Prospector : MonoBehaviour {

	static public Prospector 	S;

	public Deck					deck;
	public TextAsset			deckXML;

	public Layout layout;
	public TextAsset layoutXML;

	void Awake(){
		S = this;
	}

	void Start() {
		deck = GetComponent<Deck> ();
		deck.InitDeck (deckXML.text);

		Deck.Shuffle (ref deck.cards);
		//The ref keyword passes a reference to deck.cards, which allows
		// deck.cards to be modified by Deck.Shuffle()

		layout = GetComponent<Layout> ();
		layout.ReadLayout (layoutXML.text);
	}

}
