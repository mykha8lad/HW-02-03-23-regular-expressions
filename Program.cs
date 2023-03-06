using System.Text.RegularExpressions;

namespace HW_02_03_23_regular_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mailRegexp = @"(?:[A-Za-z_0-9]{1,20})\@(?:[a-z_0-9]{1,20})\.(?:[a-z]{2,20})(?:\.[a-z]{2,20})?";
            string dateRegexp = @"(?:29(?:[.\-\/])02(?:[.\-\/])(?:\d{2}(?:[02468][048]|[13579][26])))\b|\b(?:31(?:[.\-\/])(?:0[13578]|1[02])|(?:29|30)(?:[.\-\/])(?:0[3-9]|1[0-2])|(?:0?[1-9]|1\d|2[0-8])(?:[.\-\/])(?:0[1-9]|1[0-2]))(?:[.\-\/])(?:\d{4})";
            string timeRegexp = @"(?:[0-1][0-9]|2[0-3])(?:(?:\:)(?:[0-5][0-9])){2}";

            string line = "Login: miha_jx88@student.itstep.org" +
                "Mail: mykhailichenkovlad@gmail.com" +
                "Date registration: 24-03-2021T12:26:42" +
                "End date: 30.03.2024";

        }
    }
}