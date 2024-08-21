using System;

//Kevin Berling DVGB07 Labb 2 Lottoprogram 2024-02-16

namespace DVGB07_Labb2_Lottoprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random random = new Random();
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Validera dragningar
            if (!int.TryParse(txb_Rolls.Text, out int rolls) || rolls <= 0)
            {
                ShowErrorMessage("Ange ett giltigt antal dragningar.");
                return;
            }

            // Validera lottorad
            var userNumbers = GetUserNumbers();
            if (userNumbers == null) return;

            // Starta lottosimuleringen
            var results = SimulateLottery(userNumbers, rolls);
            txb_ResultFiveCorrect.Text = results[5].ToString();
            txb_ResultSixCorrect.Text = results[6].ToString();
            txb_ResultSevenCorrect.Text = results[7].ToString();
        }

        private HashSet<int> GetUserNumbers()
        {
            HashSet<int> userNumbers = new HashSet<int>();
            TextBox[] textBoxes = { txb_SlotOne, txb_SlotTwo, txb_SlotThree, txb_SlotFour, txb_SlotFive, txb_SlotSix, txb_SlotSeven };
            
            foreach (var textBox in textBoxes)
            {
                if (!int.TryParse(textBox.Text, out var number) || number < 1 || number > 35)
                {
                    ShowErrorMessage("Varje nummer måste vara unikt och mellan 1 och 35.");
                    return null;
                }

                if (!userNumbers.Add(number))
                {
                    ShowErrorMessage("Dubbletter är inte tillåtna i lottoraden.");
                    return null;
                }
            }
            return userNumbers;
        }

        private Dictionary<int, int> SimulateLottery(HashSet<int> userNumbers, int rolls)
        {
            Dictionary<int, int> results = new Dictionary<int, int> { { 5, 0 }, { 6, 0 }, { 7, 0 } };

            for (int i = 0; i < rolls; i++)
            {
                var lotteryNumbers = GenerateLotteryNumbers();
                int correctNumbers = userNumbers.Intersect(lotteryNumbers).Count();

                if (correctNumbers >= 5)
                {
                    results[correctNumbers]++;
                }
            }

            return results;
        }

        private HashSet<int> GenerateLotteryNumbers()
        {
            HashSet<int> lotteryNumbers = new HashSet<int>();
            while (lotteryNumbers.Count < 7)
            {
                lotteryNumbers.Add(random.Next(1, 36));
            }
            return lotteryNumbers;
        }
    }
}
