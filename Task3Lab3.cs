using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//imported System to use math functions
using System;

public class Task3Lab3 : MonoBehaviour
{
    //Code by Dan Trinh
    public double numCash;

    private int hundredBill;
    private int fiftyBill;
    private int twentyBill;
    private int tenBill;
    private int fiveBill;
    private int oneDollarBill;

    // Start is called before the first frame update
    void Start()
    {
        //This will round the change up or down to ensure there are no decimals
        numCash = Math.Round(numCash);
        Debug.Log("Cash rounded to: " + numCash);

        /*This basically divides the number of cash by their bills and then subtracting the cash amount
        by the number of bills for future calculations with the other bills. Double numCash is explicitly converted to int for calculations to work */
        hundredBill = ((int)numCash / 100);
        Debug.Log("Hundreds: " + hundredBill);
        //It is multiplied by its value to get the total in the respective bill to subtract numCash by.
        numCash = numCash - (hundredBill * 100);

        fiftyBill = ((int)numCash / 50);
        Debug.Log("Fifties: " + fiftyBill);
        numCash = numCash - (fiftyBill * 50);

        twentyBill = ((int)numCash / 20);
        Debug.Log("Twenties: " + twentyBill);
        numCash = numCash - (twentyBill * 20);

        tenBill = ((int)numCash / 10);
        Debug.Log("Tens: " + tenBill);
        numCash = numCash - (tenBill * 10);

        fiveBill = ((int)numCash / 5);
        Debug.Log("Fives: " + fiveBill);
        numCash = numCash - (fiveBill * 5);

        oneDollarBill = ((int)numCash);
        Debug.Log("Ones: " + oneDollarBill);
        numCash = numCash - oneDollarBill;

        Debug.LogFormat("You will be paid in: {0} hundred bill(s), {1} fifty bill(s), {2} twenty bill(s), {3} ten bill(s), {4} five bill(s), and {5} one dollar bill(s)", hundredBill, 
            fiftyBill, twentyBill, tenBill, fiveBill, oneDollarBill);
    }
}
