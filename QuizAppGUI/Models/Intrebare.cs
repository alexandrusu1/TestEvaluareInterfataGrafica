using System;
using System.Collections.Generic;

namespace QuizAppGUI.Models
{
    public class Intrebare
    {
        public string Text { get; set; }
        public List<string> Optiuni { get; set; }
        public OptiuniRaspuns RaspunsCorect { get; set; }
        public string Imagine { get; set; }  

        public Intrebare(string text, List<string> optiuni, OptiuniRaspuns raspunsCorect, string imagine)
        {
            Text = text;
            Optiuni = optiuni;
            RaspunsCorect = raspunsCorect;
            Imagine = imagine;
        }

        public bool VerificaRaspuns(OptiuniRaspuns raspunsUtilizator)
        {
            return raspunsUtilizator == RaspunsCorect;
        }
    }
}
