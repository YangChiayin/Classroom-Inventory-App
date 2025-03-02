namespace RoomInventoryApp
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
            listBoxRooms = new ListBox();
            btnUpdateRoom = new Button();
            btnExit = new Button();
            btnResetForNext = new Button();
            btnSaveRoom = new Button();
            btnShowRooms = new Button();
            lblMessages = new Label();
            txtBorrowerId = new TextBox();
            lblNumProjectors = new Label();
            txtCapacity = new TextBox();
            lblCapacity = new Label();
            txtRoomNumber = new TextBox();
            lblRoomNumber = new Label();
            txtRoomId = new TextBox();
            lblRoomId = new Label();
            hasSmartBoardCheckBox = new CheckBox();
            isAccessibleCheckBox = new CheckBox();
            groupBoxCampuses = new GroupBox();
            rdoBtnCambridge = new RadioButton();
            rdoBtnDoon = new RadioButton();
            radioButton1 = new RadioButton();
            groupBoxCapacity = new GroupBox();
            txtMinCapacity = new TextBox();
            lblMin = new Label();
            groupBoxCampuses.SuspendLayout();
            groupBoxCapacity.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxRooms
            // 
            listBoxRooms.FormattingEnabled = true;
            listBoxRooms.ItemHeight = 32;
            listBoxRooms.Location = new Point(22, 685);
            listBoxRooms.Margin = new Padding(6);
            listBoxRooms.Name = "listBoxRooms";
            listBoxRooms.Size = new Size(1081, 452);
            listBoxRooms.TabIndex = 0;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.Location = new Point(839, 201);
            btnUpdateRoom.Margin = new Padding(6);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(249, 49);
            btnUpdateRoom.TabIndex = 34;
            btnUpdateRoom.Text = "Update room";
            btnUpdateRoom.UseVisualStyleBackColor = true;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(839, 373);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(249, 49);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnResetForNext
            // 
            btnResetForNext.Location = new Point(839, 290);
            btnResetForNext.Margin = new Padding(6);
            btnResetForNext.Name = "btnResetForNext";
            btnResetForNext.Size = new Size(249, 47);
            btnResetForNext.TabIndex = 32;
            btnResetForNext.Text = "Reset for next";
            btnResetForNext.UseVisualStyleBackColor = true;
            btnResetForNext.Click += btnResetForNext_Click;
            // 
            // btnSaveRoom
            // 
            btnSaveRoom.Location = new Point(839, 117);
            btnSaveRoom.Margin = new Padding(6);
            btnSaveRoom.Name = "btnSaveRoom";
            btnSaveRoom.Size = new Size(249, 49);
            btnSaveRoom.TabIndex = 31;
            btnSaveRoom.Text = "Add new room";
            btnSaveRoom.UseVisualStyleBackColor = true;
            btnSaveRoom.Click += btnSaveRoom_Click;
            // 
            // btnShowRooms
            // 
            btnShowRooms.Location = new Point(24, 580);
            btnShowRooms.Margin = new Padding(6);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(178, 81);
            btnShowRooms.TabIndex = 29;
            btnShowRooms.Text = "Show rooms";
            btnShowRooms.UseVisualStyleBackColor = true;
            btnShowRooms.Click += btnShowRooms_Click;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessages.ForeColor = SystemColors.Desktop;
            lblMessages.Location = new Point(45, 461);
            lblMessages.Margin = new Padding(6, 0, 6, 0);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(250, 30);
            lblMessages.TabIndex = 28;
            lblMessages.Text = "Placeholder for entry err";
            // 
            // txtBorrowerId
            // 
            txtBorrowerId.Location = new Point(245, 292);
            txtBorrowerId.Margin = new Padding(6);
            txtBorrowerId.Name = "txtBorrowerId";
            txtBorrowerId.Size = new Size(368, 39);
            txtBorrowerId.TabIndex = 25;
            // 
            // lblNumProjectors
            // 
            lblNumProjectors.AutoSize = true;
            lblNumProjectors.Location = new Point(45, 309);
            lblNumProjectors.Margin = new Padding(6, 0, 6, 0);
            lblNumProjectors.Name = "lblNumProjectors";
            lblNumProjectors.Size = new Size(145, 32);
            lblNumProjectors.TabIndex = 24;
            lblNumProjectors.Text = "# Projectors:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(245, 203);
            txtCapacity.Margin = new Padding(6);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(368, 39);
            txtCapacity.TabIndex = 23;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(45, 220);
            lblCapacity.Margin = new Padding(6, 0, 6, 0);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(109, 32);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "Capacity:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(245, 128);
            txtRoomNumber.Margin = new Padding(6);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(368, 39);
            txtRoomNumber.TabIndex = 21;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(45, 134);
            lblRoomNumber.Margin = new Padding(6, 0, 6, 0);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(172, 32);
            lblRoomNumber.TabIndex = 20;
            lblRoomNumber.Text = "Room number:";
            // 
            // txtRoomId
            // 
            txtRoomId.Enabled = false;
            txtRoomId.Location = new Point(245, 45);
            txtRoomId.Margin = new Padding(6);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(368, 39);
            txtRoomId.TabIndex = 19;
            // 
            // lblRoomId
            // 
            lblRoomId.AutoSize = true;
            lblRoomId.Location = new Point(45, 51);
            lblRoomId.Margin = new Padding(6, 0, 6, 0);
            lblRoomId.Name = "lblRoomId";
            lblRoomId.Size = new Size(111, 32);
            lblRoomId.TabIndex = 18;
            lblRoomId.Text = "Room ID:";
            // 
            // hasSmartBoardCheckBox
            // 
            hasSmartBoardCheckBox.AutoSize = true;
            hasSmartBoardCheckBox.Location = new Point(416, 380);
            hasSmartBoardCheckBox.Margin = new Padding(6);
            hasSmartBoardCheckBox.Name = "hasSmartBoardCheckBox";
            hasSmartBoardCheckBox.Size = new Size(234, 36);
            hasSmartBoardCheckBox.TabIndex = 35;
            hasSmartBoardCheckBox.Text = "Has Smart Board?";
            hasSmartBoardCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAccessibleCheckBox
            // 
            isAccessibleCheckBox.AutoSize = true;
            isAccessibleCheckBox.Location = new Point(45, 380);
            isAccessibleCheckBox.Margin = new Padding(6);
            isAccessibleCheckBox.Name = "isAccessibleCheckBox";
            isAccessibleCheckBox.Size = new Size(186, 36);
            isAccessibleCheckBox.TabIndex = 36;
            isAccessibleCheckBox.Text = "Is accessible?";
            isAccessibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBoxCampuses
            // 
            groupBoxCampuses.Controls.Add(rdoBtnCambridge);
            groupBoxCampuses.Controls.Add(rdoBtnDoon);
            groupBoxCampuses.Controls.Add(radioButton1);
            groupBoxCampuses.Location = new Point(254, 580);
            groupBoxCampuses.Margin = new Padding(6);
            groupBoxCampuses.Name = "groupBoxCampuses";
            groupBoxCampuses.Padding = new Padding(6);
            groupBoxCampuses.Size = new Size(453, 92);
            groupBoxCampuses.TabIndex = 37;
            groupBoxCampuses.TabStop = false;
            groupBoxCampuses.Text = "By campus?";
            // 
            // rdoBtnCambridge
            // 
            rdoBtnCambridge.AutoSize = true;
            rdoBtnCambridge.Location = new Point(273, 36);
            rdoBtnCambridge.Margin = new Padding(6);
            rdoBtnCambridge.Name = "rdoBtnCambridge";
            rdoBtnCambridge.Size = new Size(162, 36);
            rdoBtnCambridge.TabIndex = 2;
            rdoBtnCambridge.TabStop = true;
            rdoBtnCambridge.Text = "Cambridge";
            rdoBtnCambridge.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDoon
            // 
            rdoBtnDoon.AutoSize = true;
            rdoBtnDoon.Location = new Point(162, 36);
            rdoBtnDoon.Margin = new Padding(6);
            rdoBtnDoon.Name = "rdoBtnDoon";
            rdoBtnDoon.Size = new Size(104, 36);
            rdoBtnDoon.TabIndex = 1;
            rdoBtnDoon.TabStop = true;
            rdoBtnDoon.Text = "Doon";
            rdoBtnDoon.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 36);
            radioButton1.Margin = new Padding(6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Waterloo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCapacity
            // 
            groupBoxCapacity.Controls.Add(txtMinCapacity);
            groupBoxCapacity.Controls.Add(lblMin);
            groupBoxCapacity.Location = new Point(773, 580);
            groupBoxCapacity.Margin = new Padding(6);
            groupBoxCapacity.Name = "groupBoxCapacity";
            groupBoxCapacity.Padding = new Padding(6);
            groupBoxCapacity.Size = new Size(323, 92);
            groupBoxCapacity.TabIndex = 38;
            groupBoxCapacity.TabStop = false;
            groupBoxCapacity.Text = "By capacity?";
            // 
            // txtMinCapacity
            // 
            txtMinCapacity.Location = new Point(173, 30);
            txtMinCapacity.Margin = new Padding(6);
            txtMinCapacity.Name = "txtMinCapacity";
            txtMinCapacity.Size = new Size(123, 39);
            txtMinCapacity.TabIndex = 1;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(19, 41);
            lblMin.Margin = new Padding(6, 0, 6, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(123, 32);
            lblMin.TabIndex = 0;
            lblMin.Text = "Minimum:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 1188);
            Controls.Add(groupBoxCapacity);
            Controls.Add(groupBoxCampuses);
            Controls.Add(isAccessibleCheckBox);
            Controls.Add(hasSmartBoardCheckBox);
            Controls.Add(btnUpdateRoom);
            Controls.Add(btnExit);
            Controls.Add(btnResetForNext);
            Controls.Add(btnSaveRoom);
            Controls.Add(btnShowRooms);
            Controls.Add(lblMessages);
            Controls.Add(txtBorrowerId);
            Controls.Add(lblNumProjectors);
            Controls.Add(txtCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblRoomNumber);
            Controls.Add(txtRoomId);
            Controls.Add(lblRoomId);
            Controls.Add(listBoxRooms);
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Conestoga Class Room Inventory - Chiayin Yang (8954164)";
            Load += MainForm_Load;
            groupBoxCampuses.ResumeLayout(false);
            groupBoxCampuses.PerformLayout();
            groupBoxCapacity.ResumeLayout(false);
            groupBoxCapacity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRooms;
        private Button btnUpdateRoom;
        private Button btnExit;
        private Button btnResetForNext;
        private Button btnSaveRoom;
        private Button btnShowRooms;
        private Label lblMessages;
        private TextBox txtBorrowerId;
        private Label lblNumProjectors;
        private TextBox txtCapacity;
        private Label lblCapacity;
        private TextBox txtRoomNumber;
        private Label lblRoomNumber;
        private TextBox txtRoomId;
        private Label lblRoomId;
        private CheckBox hasSmartBoardCheckBox;
        private CheckBox isAccessibleCheckBox;
        private GroupBox groupBoxCampuses;
        private RadioButton rdoBtnDoon;
        private RadioButton radioButton1;
        private RadioButton rdoBtnCambridge;
        private GroupBox groupBoxCapacity;
        private TextBox txtMinCapacity;
        private Label lblMin;
    }
}