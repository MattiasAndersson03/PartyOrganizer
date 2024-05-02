namespace PartyOrganizer
{
    partial class MainForm
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
            grpNewParty = new GroupBox();
            btnCreateParty = new Button();
            fee = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFee = new TextBox();
            txtAmount = new TextBox();
            txtMaxNum = new TextBox();
            grpAddGuests = new GroupBox();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lstGuestList = new ListBox();
            btnChange = new Button();
            btnDelete = new Button();
            lblTotalGuestsOutput = new TextBox();
            lblTotalCostOutput = new TextBox();
            lblTotalFeesOutput = new TextBox();
            lblTotalSurplusOutput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grpNewParty.SuspendLayout();
            grpAddGuests.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewParty
            // 
            grpNewParty.BackColor = SystemColors.ControlLight;
            grpNewParty.Controls.Add(btnCreateParty);
            grpNewParty.Controls.Add(fee);
            grpNewParty.Controls.Add(label2);
            grpNewParty.Controls.Add(label1);
            grpNewParty.Controls.Add(txtFee);
            grpNewParty.Controls.Add(txtAmount);
            grpNewParty.Controls.Add(txtMaxNum);
            grpNewParty.Location = new Point(22, 31);
            grpNewParty.Name = "grpNewParty";
            grpNewParty.Size = new Size(303, 198);
            grpNewParty.TabIndex = 0;
            grpNewParty.TabStop = false;
            grpNewParty.Text = "New Party";
            grpNewParty.Enter += groupBox1_Enter;
            // 
            // btnCreateParty
            // 
            btnCreateParty.Location = new Point(86, 156);
            btnCreateParty.Name = "btnCreateParty";
            btnCreateParty.Size = new Size(142, 36);
            btnCreateParty.TabIndex = 11;
            btnCreateParty.Text = "Create List";
            btnCreateParty.UseVisualStyleBackColor = true;
            btnCreateParty.Click += btnCreateParty_Click;
            // 
            // fee
            // 
            fee.AutoSize = true;
            fee.Location = new Point(0, 110);
            fee.Name = "fee";
            fee.Size = new Size(130, 25);
            fee.TabIndex = 10;
            fee.Text = "Fee per person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 70);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 9;
            label2.Text = "Cost per person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 36);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 8;
            label1.Text = "Max number of guest";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(189, 104);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(101, 31);
            txtFee.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(189, 67);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(101, 31);
            txtAmount.TabIndex = 6;
            // 
            // txtMaxNum
            // 
            txtMaxNum.Location = new Point(189, 30);
            txtMaxNum.Name = "txtMaxNum";
            txtMaxNum.Size = new Size(101, 31);
            txtMaxNum.TabIndex = 5;
            txtMaxNum.TextChanged += textBox1_TextChanged;
            // 
            // grpAddGuests
            // 
            grpAddGuests.BackColor = SystemColors.ControlLight;
            grpAddGuests.Controls.Add(btnAdd);
            grpAddGuests.Controls.Add(txtLastName);
            grpAddGuests.Controls.Add(txtFirstName);
            grpAddGuests.Controls.Add(label4);
            grpAddGuests.Controls.Add(label3);
            grpAddGuests.Location = new Point(22, 250);
            grpAddGuests.Name = "grpAddGuests";
            grpAddGuests.Size = new Size(303, 175);
            grpAddGuests.TabIndex = 1;
            grpAddGuests.TabStop = false;
            grpAddGuests.Text = "Inivte Guest";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(181, 31);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 31);
            txtFirstName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 85);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 43);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // lstGuestList
            // 
            lstGuestList.FormattingEnabled = true;
            lstGuestList.ItemHeight = 25;
            lstGuestList.Location = new Point(331, 34);
            lstGuestList.Name = "lstGuestList";
            lstGuestList.Size = new Size(221, 454);
            lstGuestList.TabIndex = 2;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(331, 496);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(105, 47);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(447, 496);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 47);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblTotalGuestsOutput
            // 
            lblTotalGuestsOutput.Location = new Point(201, 453);
            lblTotalGuestsOutput.Name = "lblTotalGuestsOutput";
            lblTotalGuestsOutput.Size = new Size(124, 31);
            lblTotalGuestsOutput.TabIndex = 5;
            lblTotalGuestsOutput.TextChanged += textBox2_TextChanged;
            // 
            // lblTotalCostOutput
            // 
            lblTotalCostOutput.Location = new Point(201, 490);
            lblTotalCostOutput.Name = "lblTotalCostOutput";
            lblTotalCostOutput.Size = new Size(124, 31);
            lblTotalCostOutput.TabIndex = 6;
            // 
            // lblTotalFeesOutput
            // 
            lblTotalFeesOutput.Location = new Point(201, 531);
            lblTotalFeesOutput.Name = "lblTotalFeesOutput";
            lblTotalFeesOutput.Size = new Size(124, 31);
            lblTotalFeesOutput.TabIndex = 7;
            // 
            // lblTotalSurplusOutput
            // 
            lblTotalSurplusOutput.Location = new Point(201, 568);
            lblTotalSurplusOutput.Name = "lblTotalSurplusOutput";
            lblTotalSurplusOutput.Size = new Size(124, 31);
            lblTotalSurplusOutput.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 459);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 9;
            label5.Text = "Number of guests";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 496);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 10;
            label6.Text = "Total Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 537);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 11;
            label7.Text = "Total fees";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 574);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 12;
            label8.Text = "Surplus/deficit";
            label8.Click += label8_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(579, 627);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblTotalSurplusOutput);
            Controls.Add(lblTotalFeesOutput);
            Controls.Add(lblTotalCostOutput);
            Controls.Add(lblTotalGuestsOutput);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lstGuestList);
            Controls.Add(grpAddGuests);
            Controls.Add(grpNewParty);
            Name = "MainForm";
            Text = "Party Organizer by Mattias Andersson";
            grpNewParty.ResumeLayout(false);
            grpNewParty.PerformLayout();
            grpAddGuests.ResumeLayout(false);
            grpAddGuests.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNewParty;
        private GroupBox grpAddGuests;
        private Label fee;
        private Label label2;
        private Label label1;
        private TextBox txtFee;
        private TextBox txtAmount;
        private TextBox txtMaxNum;
        private ListBox lstGuestList;
        private Button btnChange;
        private Button btnDelete;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private TextBox lblTotalGuestsOutput;
        private TextBox lblTotalCostOutput;
        private TextBox lblTotalFeesOutput;
        private TextBox lblTotalSurplusOutput;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCreateParty;
        private Button btnAdd;
    }
}
