namespace ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_3;

public class MiniCh9_3Service : IMiniCh9_3Service
{
    public string hardGuess = "";
    public string HardMode(string hardGuess)
    {
        bool isTrue = int.TryParse(hardGuess, out int realHardGuess);
        int hardRandom = new Random().Next(0, 101);


        if (isTrue == true)
        {
            if (realHardGuess == hardRandom)
            {
                return $"you guessed correctly! the answer was {hardRandom}";
            }
            else
            {
                return $"sorry,you entered {realHardGuess}. the correct answer was {hardRandom}";
            }
        }
        else
        {
            return "those are not numbers!";
        }
    }
}
