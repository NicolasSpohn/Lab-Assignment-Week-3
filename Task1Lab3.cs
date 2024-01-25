using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1Lab3 : MonoBehaviour
{
    //Code by Dan Trinh
    // TIP: 5 modules in 10 weeks = 50% * 0.15

    private float challengeScore = 10f;

    //factor percentages
    private float moduleFactor = 0.15f;
    private float readingFactor = 0.30f;
    private float quizFactor = 0.15f;
    private float assignmentFactor = 0.30f;

    //I need it to "remember" a value during calculations
    private float holder;

    //The default is set at 16
    //It is set to float to result in a "percentage" after calculations in start()
    public float numOfWeeks = 16;
    
    //Add all the percentage calculations into a final difficulty percentage, then use this to multiply the challengeScoreBeforeConversion to get challenge score
    private float difficultymultiplier;

    //number of x that can be inputted by user, these are the total of X in the entirety of the semester, there is no hard limit
    public int numModules;
    public int numReadingMaterials;
    public int numQuizzes;
    public int numAssignments;
    public bool instructorTaughtBefore;

    //The user can name the course
    public string courseName;

    // Start is called before the first frame update
    void Start()
    {
        //Does calculations for the difficulty multiplier
        calculateDat(numModules, moduleFactor);
        calculateDat(numReadingMaterials, readingFactor);
        calculateDat(numQuizzes, quizFactor);
        calculateDat(numAssignments, assignmentFactor);

        if(instructorTaughtBefore == true)
        {
            //The difficulty will be lower since the instructor has taught before
            difficultymultiplier -= 0.1f;
        }
        else
        {
            difficultymultiplier += 0.1f;
        }

        //If difficultymultiplier is above 1 because of maybe insane amounts inputted, then clamps challengeScore to 10
        if(difficultymultiplier > 1)
        {
            difficultymultiplier = 1;
        } 

        Debug.Log("The difficulty multiplier is: " + difficultymultiplier);

        challengeScore = challengeScore * difficultymultiplier;
        Debug.Log("For " + courseName + ". The challenge score is: " + challengeScore); 
    }

    void calculateDat(int numX, float xFactor)
    {
            holder = (numX / numOfWeeks) * xFactor;
            Debug.Log("Percentage is " + holder);
            difficultymultiplier += holder;
    }
}