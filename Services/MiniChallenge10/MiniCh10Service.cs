namespace ChinSMiniChallenge_EighttoTen.Services.MiniChallenge10;

public class MiniCh10Service : IMiniCh10Service
{
    public string inputAsian = "";
    public string WhichAsianRestaurant(string inputAsian)
    {
        string[] spots = new string[]{
            "M Sushi Bistro", "Oz Korean BBQ", "Journey to the Dumpling", "Toyo's Sushi", "The Pho", "Mitapheap Cambodian Restaurant", "Green Papaya", "Papa Urb's", "Panda Express", "Thai Me Up"
        };
        int random = new Random().Next(0, 10);

        if(inputAsian.ToLower() == "asian")
        {
            return $"you should go to {spots[random]}!";
        } else {
            return "please input asian";
        }
    }
}
