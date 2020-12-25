namespace Calculator
{
    partial class Calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Fac = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Mid = new System.Windows.Forms.Button();
            this.Stand = new System.Windows.Forms.Button();
            this.Swap = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.doBtn = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.repeat = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.ListBox();
            this.ImportAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(95, 12);
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            this.Input.Size = new System.Drawing.Size(241, 44);
            this.Input.TabIndex = 0;
            this.Input.Text = "0";
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(261, 386);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 75);
            this.Add.TabIndex = 2;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(261, 305);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 75);
            this.Sub.TabIndex = 3;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.Location = new System.Drawing.Point(261, 224);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 75);
            this.Mul.TabIndex = 4;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sqrt.Location = new System.Drawing.Point(99, 143);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 75);
            this.Sqrt.TabIndex = 9;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nine.Location = new System.Drawing.Point(180, 224);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 75);
            this.Nine.TabIndex = 8;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eight.Location = new System.Drawing.Point(99, 224);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 75);
            this.Eight.TabIndex = 7;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seven.Location = new System.Drawing.Point(16, 224);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(75, 75);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Six.Location = new System.Drawing.Point(180, 305);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 75);
            this.Six.TabIndex = 12;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.Location = new System.Drawing.Point(99, 305);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 75);
            this.Five.TabIndex = 11;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.Location = new System.Drawing.Point(16, 305);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 75);
            this.Four.TabIndex = 10;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Three.Location = new System.Drawing.Point(180, 386);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 75);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Two.Location = new System.Drawing.Point(99, 386);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 75);
            this.Two.TabIndex = 14;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(16, 386);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 75);
            this.One.TabIndex = 13;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Res
            // 
            this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(261, 467);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(75, 75);
            this.Res.TabIndex = 16;
            this.Res.Text = "=";
            this.Res.UseVisualStyleBackColor = true;
            this.Res.Click += new System.EventHandler(this.Res_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero.Location = new System.Drawing.Point(99, 467);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 75);
            this.Zero.TabIndex = 17;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comma.Location = new System.Drawing.Point(180, 467);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(75, 75);
            this.Comma.TabIndex = 18;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Operation.Location = new System.Drawing.Point(16, 12);
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Size = new System.Drawing.Size(73, 44);
            this.Operation.TabIndex = 19;
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Import.Location = new System.Drawing.Point(342, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(370, 44);
            this.Import.TabIndex = 20;
            this.Import.Text = "Имортировать данные";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export.Location = new System.Drawing.Point(342, 62);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(370, 44);
            this.Export.TabIndex = 21;
            this.Export.Text = "Экспортировать данные";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Pow
            // 
            this.Pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pow.Location = new System.Drawing.Point(180, 143);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 75);
            this.Pow.TabIndex = 25;
            this.Pow.Text = "^";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.Pow_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.Location = new System.Drawing.Point(261, 143);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 75);
            this.Div.TabIndex = 26;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Fac
            // 
            this.Fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fac.Location = new System.Drawing.Point(16, 62);
            this.Fac.Name = "Fac";
            this.Fac.Size = new System.Drawing.Size(75, 75);
            this.Fac.TabIndex = 27;
            this.Fac.Text = "!";
            this.Fac.UseVisualStyleBackColor = true;
            this.Fac.Click += new System.EventHandler(this.Fac_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.Location = new System.Drawing.Point(99, 62);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 75);
            this.Log.TabIndex = 28;
            this.Log.Text = "log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Mid
            // 
            this.Mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mid.Location = new System.Drawing.Point(180, 62);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(75, 75);
            this.Mid.TabIndex = 29;
            this.Mid.Text = "M";
            this.Mid.UseVisualStyleBackColor = true;
            this.Mid.Click += new System.EventHandler(this.Mid_Click);
            // 
            // Stand
            // 
            this.Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stand.Location = new System.Drawing.Point(261, 62);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(75, 75);
            this.Stand.TabIndex = 30;
            this.Stand.Text = "S";
            this.Stand.UseVisualStyleBackColor = true;
            this.Stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // Swap
            // 
            this.Swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Swap.Location = new System.Drawing.Point(16, 467);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(75, 75);
            this.Swap.TabIndex = 31;
            this.Swap.Text = "+/-";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBar.Location = new System.Drawing.Point(16, 548);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.ReadOnly = true;
            this.StatusBar.Size = new System.Drawing.Size(696, 38);
            this.StatusBar.TabIndex = 32;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(16, 143);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 75);
            this.Clear.TabIndex = 33;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // doBtn
            // 
            this.doBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doBtn.Location = new System.Drawing.Point(491, 467);
            this.doBtn.Name = "doBtn";
            this.doBtn.Size = new System.Drawing.Size(75, 75);
            this.doBtn.TabIndex = 36;
            this.doBtn.Text = "=>";
            this.doBtn.UseVisualStyleBackColor = true;
            this.doBtn.Click += new System.EventHandler(this.DoBtn_Click);
            // 
            // undo
            // 
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undo.Location = new System.Drawing.Point(410, 467);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 75);
            this.undo.TabIndex = 35;
            this.undo.Text = "<=";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // repeat
            // 
            this.repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeat.Location = new System.Drawing.Point(572, 467);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(75, 75);
            this.repeat.TabIndex = 34;
            this.repeat.Text = "R";
            this.repeat.UseVisualStyleBackColor = true;
            this.repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.FormattingEnabled = true;
            this.Answer.HorizontalScrollbar = true;
            this.Answer.ItemHeight = 31;
            this.Answer.Location = new System.Drawing.Point(342, 162);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(370, 283);
            this.Answer.TabIndex = 0;
            // 
            // ImportAction
            // 
            this.ImportAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportAction.Location = new System.Drawing.Point(342, 112);
            this.ImportAction.Name = "ImportAction";
            this.ImportAction.Size = new System.Drawing.Size(370, 44);
            this.ImportAction.TabIndex = 37;
            this.ImportAction.Text = "Импортировать действия";
            this.ImportAction.UseVisualStyleBackColor = true;
            this.ImportAction.Click += new System.EventHandler(this.ImportAction_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 598);
            this.Controls.Add(this.ImportAction);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.doBtn);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Fac);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Input);
            this.Name = "Calc";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Res;
        public System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Comma;
        public System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Fac;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Mid;
        private System.Windows.Forms.Button Stand;
        private System.Windows.Forms.Button Swap;
        public System.Windows.Forms.TextBox StatusBar;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button doBtn;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button repeat;
        public System.Windows.Forms.ListBox Answer;
        private System.Windows.Forms.Button ImportAction;
    }
}

