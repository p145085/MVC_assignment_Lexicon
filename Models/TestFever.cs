namespace MVC_assignment_Lexicon.Models
{
    public class TestFever
    {
        public static string TestFeverMethod(double temp)
        {
            if (temp > 37)
            {
                return "You've got a fever.";
            } else if (temp <= 37 && temp >= 35)
            {
                return "You're fiiine.";
            } else if (temp <= 35 && temp > 0)
            {
                return "Hypothermia, find a blanket.";
            } else if (temp <= 0)
            {
                return "Bro, were you in cryo-stasis?";
            } else
            {
                return "I don't know WHAT the hell is going on.";
            }   
        }
    }
}