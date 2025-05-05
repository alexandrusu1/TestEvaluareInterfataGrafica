using QuizAppGUI.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuizAppGUI.Services
{
    public class Chestionar
    {
        public List<Intrebare> Intrebari { get; private set; }
        public int Scor { get; private set; }
        public DateTime StartTime { get; private set; }
        public const int TimpLimita = 600; // 10 minute
        public TipQuiz Tip { get; private set; }

        public Chestionar(TipQuiz tip)
        {
            Tip = tip;
            Intrebari = IncarcaIntrebari(Path.Combine("FisiereQuiz", $"{tip.ToString().ToLower()}.txt"));
        }

        private List<Intrebare> IncarcaIntrebari(string fisier)
        {
            var intrebari = new List<Intrebare>();
            var linii = File.ReadAllLines(fisier);

            for (int i = 0; i < linii.Length;)
            {
                string text = linii[i];
                string imagine;
                List<string> optiuni;
                OptiuniRaspuns raspunsCorect;

          
                if (linii[i + 1].Trim().EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    linii[i + 1].Trim().EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                {
                    imagine = linii[i + 1];
                    optiuni = new List<string> { linii[i + 2], linii[i + 3], linii[i + 4], linii[i + 5] };
                    raspunsCorect = (OptiuniRaspuns)Enum.Parse(typeof(OptiuniRaspuns), linii[i + 6]);
                    i += 7;
                }
                else
                {
                    imagine = ""; 
                    optiuni = new List<string> { linii[i + 1], linii[i + 2], linii[i + 3], linii[i + 4] };
                    raspunsCorect = (OptiuniRaspuns)Enum.Parse(typeof(OptiuniRaspuns), linii[i + 5]);
                    i += 6;
                }

                intrebari.Add(new Intrebare(text, optiuni, raspunsCorect, imagine));
            }

            return intrebari;
        }



        public void IncrementareScor()
        {
            Scor++;
        }

        public void SalvareRezultat(int scorFinal)
        {
            string rezultat = $"{DateTime.Now}, Quiz: {Tip}, Scor: {scorFinal}/{Intrebari.Count}\n";
            File.AppendAllText(Path.Combine("FisiereQuiz", "rezultate.txt"), rezultat);
        }
    }
}
