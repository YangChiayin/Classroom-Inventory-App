using Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RoomInventoryApp
{
    public partial class MainForm : Form
    {
        private IClassroomManager classroomManager;

        public MainForm()
        {
            InitializeComponent();
            classroomManager = new ClassroomManager();
            ResetForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // lblMessages.Text = "";
            var classrooms = classroomManager.GetAllClassrooms(); // Get all rooms
            int roomCount = classrooms.Count; // Count the number of rooms
            lblMessages.Text = $"{roomCount} rooms were loaded successfully";
            lblMessages.ForeColor = System.Drawing.Color.Blue;
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAndSaveRoom();
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message;
                lblMessages.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxRooms.SelectedIndex != -1)
                {
                    ValidateAndUpdateRoom();
                    // Refresh the displayed rooms
                    ShowFilteredRooms();
                }
                else
                {
                    MessageBox.Show("Please select an item to update", "No Item Selected ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message;
                lblMessages.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void btnResetForNext_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFilteredRooms();
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message;
                lblMessages.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void ValidateAndSaveRoom()
        {
            var classroom = GetClassroomFromForm();
            ValidateClassroom(classroom);
            classroomManager.AddClassroom(classroom);
            ResetForm();
            lblMessages.Text = "Classroom added successfully!";
            lblMessages.ForeColor = System.Drawing.Color.Blue;
        }
        private void ValidateAndUpdateRoom()
        {
            var classroom = GetClassroomFromForm();
            ValidateClassroom(classroom);

            // Get the selected classroom from the list box
            string selectedClassroomString = listBoxRooms.SelectedItem.ToString();

            // Get the existing classroom from the classroom manager
            var existingClassrooms = classroomManager.GetAllClassrooms();
            var existingClassroom = existingClassrooms.FirstOrDefault(c => c.ToString() == selectedClassroomString);

            if (existingClassroom == null)
            {
                lblMessages.Text = "Classroom not found.";
                lblMessages.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Update the ClassroomId of the new classroom
            classroom.ClassroomId = existingClassroom.ClassroomId;

            classroomManager.UpdateClassroom(classroom);

            lblMessages.Text = "Classroom updated successfully!";
            lblMessages.ForeColor = System.Drawing.Color.Blue;

            ResetForm();
        }
        private void ShowFilteredRooms()
        {
            var classrooms = classroomManager.GetAllClassrooms();

            if (radioButton1.Checked)
                classrooms = classrooms.Where(c => c.Campus == "Waterloo").ToList();
            else if (rdoBtnDoon.Checked)
                classrooms = classrooms.Where(c => c.Campus == "Doon").ToList();
            else if (rdoBtnCambridge.Checked)
                classrooms = classrooms.Where(c => c.Campus == "Cambridge").ToList();

            if (int.TryParse(txtMinCapacity.Text, out int minCapacity) && minCapacity > 0)
            {
                classrooms = classrooms.Where(c => c.Capacity >= minCapacity).ToList();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtMinCapacity.Text))
                {
                    lblMessages.Text = "Please enter a valid positive number for minimum capacity.";
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }

            listBoxRooms.Items.Clear();
            foreach (var classroom in classrooms)
            {
                listBoxRooms.Items.Add(classroom.ToString());
            }
        }

        private Classroom GetClassroomFromForm()
        {
            return new Classroom
            {
                ClassroomId = int.Parse(txtRoomId.Text),
                RoomNumber = txtRoomNumber.Text.ToUpper(),
                Capacity = int.Parse(txtCapacity.Text),

                // defaults to 0. Otherwise, it parses the input as an integer. (need to parse the input to an integer because the txtBorrowerId.Text property returns a string, and the NumberOfProjectors property is expected to be an integer. )
                NumberOfProjectors = string.IsNullOrWhiteSpace(txtBorrowerId.Text) ? 0 : int.Parse(txtBorrowerId.Text),

                IncludesSmartBoard = hasSmartBoardCheckBox.Checked,
                IsAccessible = isAccessibleCheckBox.Checked
            };
        }

        private void ValidateClassroom(Classroom classroom)
        {
            var errors = new List<string>();

            if (classroom.ClassroomId <= 0)
                errors.Add("Classroom ID must be a positive integer.");

            if (string.IsNullOrWhiteSpace(classroom.RoomNumber) || !IsValidRoomNumber(classroom.RoomNumber))
                errors.Add("Room number is required and must be in a valid format (e.g., WMB-4G15).");

            if (classroom.Capacity <= 0)
                errors.Add("Capacity must be a positive integer.");

            if (classroom.NumberOfProjectors < 0)
                errors.Add("Number of projectors must be a non-negative integer.");

            if (errors.Count > 0)
                throw new Exception(string.Join("\n", errors));
        }

        private bool IsValidRoomNumber(string roomNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(roomNumber, @"^[WDC]\w{2}-\d[A-Z]\d{2}$");
        }

        private void ResetForm()
        {
            txtRoomId.Text = classroomManager.GetNextClassroomId().ToString();
            txtRoomNumber.Clear();
            txtCapacity.Clear();
            txtBorrowerId.Clear();
            hasSmartBoardCheckBox.Checked = false;
            isAccessibleCheckBox.Checked = false;
            lblMessages.Text = string.Empty;
        }
    }
}