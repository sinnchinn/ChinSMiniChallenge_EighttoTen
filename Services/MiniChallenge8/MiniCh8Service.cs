namespace ChinSMiniChallenge_EighttoTen.Services.MiniChallenge8;

public class MiniCh8Service : IMiniCh8Service
{

    public string Magic8Ball(string userQuestion)
    {
        string[] magic8Answers = new string[]{
            "yes", "no", "maybe", "unfortunately", "definitely", "keep dreaming", "meh", "heck yea"
        }; 
        int choices = new Random().Next(0,8);


        return $"your question was: {userQuestion} our answer to that is: {magic8Answers[choices]}";
    }
}
