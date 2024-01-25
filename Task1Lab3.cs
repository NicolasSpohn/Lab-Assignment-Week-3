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
    private float difficultyMultiplier;

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
            difficultyMultiplier -= 0.1f;
        }
        else
        {
            difficultyMultiplier += 0.1f;
        }

        //If difficultymultiplier is above 1 because of maybe insane amounts inputted, then clamps challengeScore to 10
        if(difficultyMultiplier > 1)
        {
            difficultyMultiplier = 1;
        } 
        else if(difficultyMultiplier < 0.1f)
        {
            //If the difficultyMultiplier is below 0.1, makes it 0.1 to ensure the lowest challenge score stays at 1 since 10 * 0.1 = 1
            difficultyMultiplier = 0.1f;
        }

        Debug.Log("The difficulty multiplier is: " + difficultyMultiplier);

        // multiplies challengeScore (10) with difficultyMultiplier and yields a number between 1-10
        challengeScore = challengeScore * difficultyMultiplier;
        Debug.Log("For " + courseName + ". The challenge score is: " + challengeScore); 
    }

    void calculateDat(int numX, float xFactor)
    {
        //Divides number of X by number of weeks, it is implicitly converted to float, then multiplies by X's factor percentage. Adds to difficulty multiplier.
            holder = (numX / numOfWeeks) * xFactor;
            Debug.Log("Percentage is " + holder);
            difficultyMultiplier += holder;
    }
}