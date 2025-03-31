using System;
using System.Collections.Generic;

namespace QuizAppGUI.Models
{
    public class Intrebare
    {
        public string Text { get; set; }
        public List<string> Optiuni { get; set; }
        public OptiuniRaspuns RaspunsCorect { get; set; }

        public Intrebare(string text, List<string> optiuni, OptiuniRaspuns raspunsCorect)
        {
            Text = text;
            Optiuni = optiuni;
            RaspunsCorect = raspunsCorect;
        }

        public bool VerificaRaspuns(OptiuniRaspuns raspunsUtilizator)
        {
            return raspunsUtilizator == RaspunsCorect;
        }
    }
}
