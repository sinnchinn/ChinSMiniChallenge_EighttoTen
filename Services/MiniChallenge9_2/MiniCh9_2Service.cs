namespace ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_2;

public class MiniCh9_2Service : IMiniCh9_2Service
{
    public string medGuess = "";
    public string MediumMode(string medGuess)
    {
        bool isTrue = int.TryParse(medGuess, out int realMedGuess);
        int medRandom = new Random().Next(0, 50);


        if (isTrue == true)
        {
            if (realMedGuess == medRandom)
            {
                return $"you guessed correctly! the answer was {medRandom}";
            }
            else
            {
                return $"sorry,you entered {realMedGuess}. the correct answer was {medRandom}";
            }
        }
        else
        {
            return "those are not numbers!";
        }
    }
}
