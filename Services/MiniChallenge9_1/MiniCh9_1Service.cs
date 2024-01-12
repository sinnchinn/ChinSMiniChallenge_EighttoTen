namespace ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_1;

public class MiniCh9_1Service : IMiniCh9_1Service
{

    public string easyGuess = "";
    public string EasyMode(string easyGuess)
    {
        bool isTrue = int.TryParse(easyGuess, out int realEasyGuess);
        int easyRandom = new Random().Next(0, 10);


        if (isTrue == true)
        {
            if (realEasyGuess == easyRandom)
            {
                return $"you guessed correctly! the answer was {easyRandom}";
            }
            else
            {
                return $"sorry,you entered {realEasyGuess}. the correct answer was {easyRandom}";
            }
        }
        else
        {
            return "those are not numbers!";
        }

    }
}
