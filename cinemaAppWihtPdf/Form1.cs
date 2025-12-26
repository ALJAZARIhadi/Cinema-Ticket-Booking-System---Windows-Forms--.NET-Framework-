using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaAppWihtPdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            Button[] buttons = new Button[14];
            SelectedSeatesLbl.Text = "";
            string Letter = "ABCDEFGHJKLMNO";

            for (int i = buttons.Length - 1; i >= 0; i--)
            {
                for (int j = buttons.Length-1; j >= 0; j--)
                {

                    buttons[j] = new Button();
                    buttons[j].Name = Letter[i] + (j+1).ToString();
                    buttons[j].Location = new Point(580 + (20 * j), 5 + (20 * i));
                    buttons[j].Width = 20;
                    buttons[j].Height = 20;
                    buttons[j].Click += button1_Click; // Event handler for button click
                    //buttons[j].Text = $"{i}{j}";
                    //You can put here the site number or name
                    Controls.Add((Button)buttons[j]);
                }
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Seats FROM Tickets";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seats = reader["Seats"].ToString();
                            var matches = Regex.Matches(seats, @"[A-Z]\d+");//Birinci harf ve sonraki rakamlar

                            foreach (Match match in matches)
                            {
                                string seat = match.Value.Trim();
                                MarkSeatAsReserved(seat);
                            }
                        }
                    }
                }
            }
        }
        private void MarkSeatAsReserved(string seatName)
        {
            
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name == seatName)
                {
                    control.BackColor = Color.Green;
                    control.Enabled = false; // لا يمكن الحجز مرة ثانية
                }
            }
        }


        int SeatPrice = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;// sender	The control (object) that triggered the event
                                            //as Button   Convert it to a Button type safely
                                            //Button button = sender as Button; Create a variable button that refers to the clicked seat

            if (button.BackColor != Color.Red)
            {
                button.BackColor = Color.Red;
                SelectedSeatesLbl.Text += button.Name;
                SeatPrice += 200;
            }
            else
            {
                button.BackColor = Color.White;
                SelectedSeatesLbl.Text = SelectedSeatesLbl.Text.Replace(button.Name, "");
                SeatPrice -= 200;
            }
            PriceLbl.Text = SeatPrice.ToString();

            Calculate();
        }
         
        byte ColaPieces = 0;
        byte PopPieces = 0;
        byte ChocoPieces = 0;

        private void Increase1_Click(object sender, EventArgs e)
        {

            ColaPieces += 1;
            ColaPiece.Text = ColaPieces.ToString();
        }
        private void Increase2_Click(object sender, EventArgs e)
        {
            PopPieces += 1;
            PopPiece.Text = PopPieces.ToString();
        }

        private void Increase3_Click(object sender, EventArgs e)
        {
            ChocoPieces += 1;
            ChocoPiece.Text = ChocoPieces.ToString();
        }

        private void Decrease1_Click(object sender, EventArgs e)
        {
            ColaPieces -= 1;
            ColaPiece.Text = ColaPieces.ToString();
        }

        private void Decrease2_Click(object sender, EventArgs e)
        {
            PopPieces -= 1;
            PopPiece.Text = PopPieces.ToString();
        }

        private void Decrease3_Click(object sender, EventArgs e)
        {
            ChocoPieces -= 1;
            ChocoPiece.Text = ChocoPieces.ToString();
        }
        void Calculate()
        {
            int TotalPrice = 0;
            TotalPrice += ColaPieces  * 50;
            TotalPrice += PopPieces   * 75;
            TotalPrice += ChocoPieces * 25;
            TotalPriceLbl.Text = (TotalPrice + SeatPrice).ToString();
            
        }

        private void ColaPiece_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void PopPiece_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ChocoPiece_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        // DataBase connection section
        string connectionString = "Server=X-RAY\\SQLEXPRESS01;Database=CinemaDB;Trusted_Connection=True;";

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter your name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(SelectedSeatesLbl.Text))
            {
                MessageBox.Show("Please select at least one seat.", "No Seats Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🟩 (Optional) You can also add a simple email format check:
            if (!Regex.IsMatch(textBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))//To make a connecton with database
            {
                conn.Open();
                string query = "INSERT INTO Tickets (UserName, Email, Phone, Seats, Price, Cola, Popcorn, Chocolate, TotalPrice) " +
                               "VALUES (@UserName, @Email, @Phone, @Seats, @Price, @Cola, @Popcorn, @Chocolate, @TotalPrice)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@Seats", SelectedSeatesLbl.Text);
                    cmd.Parameters.AddWithValue("@Price", PriceLbl.Text);
                    cmd.Parameters.AddWithValue("@Cola", ColaPiece.Text);
                    cmd.Parameters.AddWithValue("@Popcorn", PopPiece.Text);
                    cmd.Parameters.AddWithValue("@Chocolate", ChocoPiece.Text);
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalPriceLbl.Text);

                    cmd.ExecuteNonQuery();
                    // بعد حفظ البيانات في قاعدة البيانات، غيّر لون المقاعد المختارة مباشرة
                    string seats = SelectedSeatesLbl.Text; // نفس المتغير اللي فيه المقاعد مثل "A1A2A3"
                    var matches = Regex.Matches(seats, @"[A-Z]\d+");

                    foreach (Match match in matches)
                    {
                        string seatName = match.Value;
                        MarkSeatAsReserved(seatName); // استدعِ دالة تغيّر لون المقعد للأخضر
                                                       //Call an function that change the color of button to green
                    }

                }
            }
            MessageBox.Show("The ticket has been successfully saved in the database!");




            try // we use try and catch to avoide erors
            {
                // Collect data from form controls
                string seats = SelectedSeatesLbl.Text;
                string price = PriceLbl.Text;
                string total = TotalPriceLbl.Text;
                string cola = ColaPiece.Text;
                string popcorn = PopPiece.Text;
                string chocolate = ChocoPiece.Text;
                string customerName = textBoxName.Text.Trim();

                // Generate unique file name for each ticket (saved on Desktop)
                string fileName = $"Ticket_{customerName}_{Guid.NewGuid().ToString().Substring(0, 8)}.pdf";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                // Create and configure the PDF document
                using (Document pdfDoc = new Document(PageSize.A5, 25, 25, 30, 30))
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Define fonts
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);

                    // Add title
                    Paragraph title = new Paragraph("🎬 Cinema Ticket\n\n", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    // Add ticket details
                    pdfDoc.Add(new Paragraph($"👤 Customer Name: {customerName}", normalFont));
                    pdfDoc.Add(new Paragraph($"💺 Selected Seats: {seats}", normalFont));
                    pdfDoc.Add(new Paragraph($"💵 Base Price: {price} TL", normalFont));
                    pdfDoc.Add(new Paragraph($"🥤 Cola: {cola}", normalFont));
                    pdfDoc.Add(new Paragraph($"🍿 Popcorn: {popcorn}", normalFont));
                    pdfDoc.Add(new Paragraph($"🍫 Chocolate: {chocolate}", normalFont));
                    pdfDoc.Add(new Paragraph($"\n💰 Total Price: {total} TL", normalFont));
                    pdfDoc.Add(new Paragraph($"📅 Date: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont));

                    // 🟩 Add footer
                    pdfDoc.Add(new Paragraph("\n------------------------------------\n", normalFont));
                    Paragraph footer = new Paragraph("Thank you for your purchase!\nEnjoy your movie 🎥", normalFont);
                    footer.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(footer);

                    pdfDoc.Close();
                }

                // 🟩 Notify user and open the created PDF
                MessageBox.Show("Ticket successfully created on your Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(filePath);

                // 🟩 Optional: Update UI (mark seats as reserved)
                var matches = Regex.Matches(seats, @"[A-Z]\d+");
                foreach (Match match in matches)
                {
                    string seatName = match.Value.Trim();
                    MarkSeatAsReserved(seatName); // Make selected seats green and disabled
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            SelectedSeatesLbl.Text = "";
            PriceLbl.Text = "";
            ColaPiece.Text = "";
            PopPiece.Text = "";
            ChocoPiece.Text = "";
            TotalPriceLbl.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectedSeatesLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
