namespace DVGB07_Labb2_Lottoprogram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Start = new Button();
            txb_SlotOne = new TextBox();
            txb_SlotTwo = new TextBox();
            txb_SlotThree = new TextBox();
            txb_SlotFour = new TextBox();
            txb_SlotFive = new TextBox();
            txb_SlotSix = new TextBox();
            txb_SlotSeven = new TextBox();
            txb_Rolls = new TextBox();
            txb_ResultFiveCorrect = new TextBox();
            txb_ResultSixCorrect = new TextBox();
            txb_ResultSevenCorrect = new TextBox();
            lbl_YourRow = new Label();
            lbl_AmountOfRolls = new Label();
            lbl_ResultFiveCorrect = new Label();
            lbl_ResultSixCorrect = new Label();
            lbl_ResultSevenCorrect = new Label();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Start.Location = new Point(409, 49);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(105, 23);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Starta Lotto";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // txb_SlotOne
            // 
            txb_SlotOne.Location = new Point(98, 6);
            txb_SlotOne.Name = "txb_SlotOne";
            txb_SlotOne.Size = new Size(100, 23);
            txb_SlotOne.TabIndex = 1;
            // 
            // txb_SlotTwo
            // 
            txb_SlotTwo.Location = new Point(204, 6);
            txb_SlotTwo.Name = "txb_SlotTwo";
            txb_SlotTwo.Size = new Size(100, 23);
            txb_SlotTwo.TabIndex = 2;
            // 
            // txb_SlotThree
            // 
            txb_SlotThree.Location = new Point(310, 6);
            txb_SlotThree.Name = "txb_SlotThree";
            txb_SlotThree.Size = new Size(100, 23);
            txb_SlotThree.TabIndex = 3;
            // 
            // txb_SlotFour
            // 
            txb_SlotFour.Location = new Point(416, 6);
            txb_SlotFour.Name = "txb_SlotFour";
            txb_SlotFour.Size = new Size(100, 23);
            txb_SlotFour.TabIndex = 4;
            // 
            // txb_SlotFive
            // 
            txb_SlotFive.Location = new Point(522, 6);
            txb_SlotFive.Name = "txb_SlotFive";
            txb_SlotFive.Size = new Size(100, 23);
            txb_SlotFive.TabIndex = 5;
            // 
            // txb_SlotSix
            // 
            txb_SlotSix.Location = new Point(628, 6);
            txb_SlotSix.Name = "txb_SlotSix";
            txb_SlotSix.Size = new Size(100, 23);
            txb_SlotSix.TabIndex = 6;
            // 
            // txb_SlotSeven
            // 
            txb_SlotSeven.Location = new Point(734, 6);
            txb_SlotSeven.Name = "txb_SlotSeven";
            txb_SlotSeven.Size = new Size(100, 23);
            txb_SlotSeven.TabIndex = 7;
            // 
            // txb_Rolls
            // 
            txb_Rolls.Location = new Point(233, 49);
            txb_Rolls.Name = "txb_Rolls";
            txb_Rolls.Size = new Size(170, 23);
            txb_Rolls.TabIndex = 8;
            // 
            // txb_ResultFiveCorrect
            // 
            txb_ResultFiveCorrect.Location = new Point(173, 127);
            txb_ResultFiveCorrect.Name = "txb_ResultFiveCorrect";
            txb_ResultFiveCorrect.Size = new Size(100, 23);
            txb_ResultFiveCorrect.TabIndex = 9;
            // 
            // txb_ResultSixCorrect
            // 
            txb_ResultSixCorrect.Location = new Point(329, 127);
            txb_ResultSixCorrect.Name = "txb_ResultSixCorrect";
            txb_ResultSixCorrect.Size = new Size(100, 23);
            txb_ResultSixCorrect.TabIndex = 10;
            // 
            // txb_ResultSevenCorrect
            // 
            txb_ResultSevenCorrect.Location = new Point(485, 127);
            txb_ResultSevenCorrect.Name = "txb_ResultSevenCorrect";
            txb_ResultSevenCorrect.Size = new Size(100, 23);
            txb_ResultSevenCorrect.TabIndex = 11;
            // 
            // lbl_YourRow
            // 
            lbl_YourRow.AutoSize = true;
            lbl_YourRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_YourRow.Location = new Point(12, 9);
            lbl_YourRow.Name = "lbl_YourRow";
            lbl_YourRow.Size = new Size(80, 15);
            lbl_YourRow.TabIndex = 12;
            lbl_YourRow.Text = "Din Lottorad:";
            // 
            // lbl_AmountOfRolls
            // 
            lbl_AmountOfRolls.AutoSize = true;
            lbl_AmountOfRolls.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AmountOfRolls.Location = new Point(123, 52);
            lbl_AmountOfRolls.Name = "lbl_AmountOfRolls";
            lbl_AmountOfRolls.Size = new Size(104, 15);
            lbl_AmountOfRolls.TabIndex = 13;
            lbl_AmountOfRolls.Text = "Antal Dragningar:";
            // 
            // lbl_ResultFiveCorrect
            // 
            lbl_ResultFiveCorrect.AutoSize = true;
            lbl_ResultFiveCorrect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ResultFiveCorrect.Location = new Point(123, 130);
            lbl_ResultFiveCorrect.Name = "lbl_ResultFiveCorrect";
            lbl_ResultFiveCorrect.Size = new Size(44, 15);
            lbl_ResultFiveCorrect.TabIndex = 14;
            lbl_ResultFiveCorrect.Text = "5 Rätt:";
            // 
            // lbl_ResultSixCorrect
            // 
            lbl_ResultSixCorrect.AutoSize = true;
            lbl_ResultSixCorrect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ResultSixCorrect.Location = new Point(279, 130);
            lbl_ResultSixCorrect.Name = "lbl_ResultSixCorrect";
            lbl_ResultSixCorrect.Size = new Size(44, 15);
            lbl_ResultSixCorrect.TabIndex = 15;
            lbl_ResultSixCorrect.Text = "6 Rätt:";
            // 
            // lbl_ResultSevenCorrect
            // 
            lbl_ResultSevenCorrect.AutoSize = true;
            lbl_ResultSevenCorrect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ResultSevenCorrect.Location = new Point(435, 130);
            lbl_ResultSevenCorrect.Name = "lbl_ResultSevenCorrect";
            lbl_ResultSevenCorrect.Size = new Size(44, 15);
            lbl_ResultSevenCorrect.TabIndex = 16;
            lbl_ResultSevenCorrect.Text = "7 Rätt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 180);
            Controls.Add(lbl_ResultSevenCorrect);
            Controls.Add(lbl_ResultSixCorrect);
            Controls.Add(lbl_ResultFiveCorrect);
            Controls.Add(lbl_AmountOfRolls);
            Controls.Add(lbl_YourRow);
            Controls.Add(txb_ResultSevenCorrect);
            Controls.Add(txb_ResultSixCorrect);
            Controls.Add(txb_ResultFiveCorrect);
            Controls.Add(txb_Rolls);
            Controls.Add(txb_SlotSeven);
            Controls.Add(txb_SlotSix);
            Controls.Add(txb_SlotFive);
            Controls.Add(txb_SlotFour);
            Controls.Add(txb_SlotThree);
            Controls.Add(txb_SlotTwo);
            Controls.Add(txb_SlotOne);
            Controls.Add(btn_Start);
            Name = "Form1";
            Text = "Lotto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Start;
        private TextBox txb_SlotOne;
        private TextBox txb_SlotTwo;
        private TextBox txb_SlotThree;
        private TextBox txb_SlotFour;
        private TextBox txb_SlotFive;
        private TextBox txb_SlotSix;
        private TextBox txb_SlotSeven;
        private TextBox txb_Rolls;
        private TextBox txb_ResultFiveCorrect;
        private TextBox txb_ResultSixCorrect;
        private TextBox txb_ResultSevenCorrect;
        private Label lbl_YourRow;
        private Label lbl_AmountOfRolls;
        private Label lbl_ResultFiveCorrect;
        private Label lbl_ResultSixCorrect;
        private Label lbl_ResultSevenCorrect;
    }
}
