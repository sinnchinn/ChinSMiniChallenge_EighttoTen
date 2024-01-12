// Sinatha Chin

// 01/11/24

// Mini Challenges 8-10
    8. magic 8 ball: create an endpoint that outputs 8 unique answers
    9. guess it: create 3 endpoints with easy med and hard mode where user guesses numbers
    10. restaurant picker: create an endpoint where it outputs random restaurant

// Peer Reviewer: Joseph Poncini

// Peer Review Comments: Overall decent job. I wrote comments for each endpoint below:

    Magic 8 Ball - very good job on this one. Nice of you to include the question asked in the response. I appreciated seeing that

    GuessIt - Noticed on the Hard mode you only had the numbers go up to 50 instead of 100. Very easy fix for that
            - Also I make sure that for the Next() command you do something like Next(1,101) instead of Next(1,100), the first parameter is inclusive but the second isn't so you have to go one above that to have the last number as a possibility

    Restaraunt Picker - Asian category works perfectly! You still technically should have two more categories to choose, 
            probably would use an if or switch statement to handle that

    Overall pretty good job!
