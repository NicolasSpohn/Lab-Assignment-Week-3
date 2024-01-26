using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2Lab3 : MonoBehaviour
{
    public double coverPrice;
    private double discountPercent = 0.4;
    public int bookAmount; 
    private double shippingCost; 

    // Start is called before the first frame update
    void Start()
    {
        //This will calculate the shipping cost and be sent through the two methods below
        shippingCost = (3 + (bookAmount - 1) * .75);

        //This will calculate and display the wholescale cost
        CalculateWholescaleCost(shippingCost); 

        // This will calculate the net profit of the boostore
        NetProfit(shippingCost);
    }

    // This method will calculate the wholescale cost a regular person would have to pay and display it in the coonsole
    void CalculateWholescaleCost(double shippingCost)
    {
        double wholescaleCost = bookAmount * coverPrice + shippingCost;
        Debug.Log("The wholescale cost is " + wholescaleCost); 
    }

    // This method will calculate the profit that the bookstore makes when reselling the books they got at a discounted price
    void NetProfit(double shippingCost)
    {
        // These two equations will figure out how much the bookstore spent and how much they got selling
        double bookStoreSpend = (coverPrice * discountPercent) * bookAmount + shippingCost;
        double bookStoreSale = coverPrice * bookAmount;

        // This equation will calculate the profit
        double profit = bookStoreSale - bookStoreSpend;


        // Display profit to console
        Debug.Log("The bookstore had a profit of " + profit);
    }
}
