using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//  Download Nuget packet Name FireSharp.Serialization.JsonNet.Core
// nuget reference for FireSharp.Serialization.JsonNet.Core
using FireSharp.Config; // Config the C# Connection to Firebase
using FireSharp.Interfaces;//
using FireSharp.Response; // To and From Response from C# to Firebase
/// 
/// </summary>


namespace Demo_
{
    public partial class Form1 : Form
    {
        //   Database Connection Path and Authenticaiton.
        IFirebaseConfig config = new FirebaseConfig
        {   
            // AuthSecret from Database secrets 
            AuthSecret = "Seceret",
            // Database Endpoint
            BasePath = "Firebase Databse Endpoint"
        };
        // Database Client
        IFirebaseClient client;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client!=null)
            {
                MessageBox.Show("Hello Firebase");
            }
         }
        // Always use async function perform CRUD operation for Firebase Database
        private async void Insert_Button_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = Id_Text.Text,
                Name = Name_Text.Text,
                Address = Address_Text.Text,
                Age = Age_Text.Text
            };
            // Insert Data Under Parent Node "Information" with UniqueID name= ID_Text
            SetResponse response = await client.SetTaskAsync("Information/" + Id_Text.Text, data);

            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data for ID" + result.Id + "Inserted");

        }

        private async void Read_button_Click(object sender, EventArgs e)
        { 
            // Read Data from Firebase data base
            FirebaseResponse response = await client.GetTaskAsync("Information/"+Id_Text.Text);

            // Create object 
            Data obj = response.ResultAs<Data>();

            Id_Text.Text = obj.Id;
            Name_Text.Text = obj.Name;
            Address_Text.Text = obj.Address;
            Age_Text.Text = obj.Age;

            MessageBox.Show("Data Read Complete");

        }

        private async void Update_button_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = Id_Text.Text,
                Name = Name_Text.Text,
                Address = Address_Text.Text,
                Age = Age_Text.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + Id_Text.Text,data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Update Cloud Data");

        }

        private async void Delete_button_Click(object sender, EventArgs e)

        {
          
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + Id_Text.Text);

            MessageBox.Show("Delete ID" + Id_Text.Text);

        }

        private async void Deleteparent_button_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");

            MessageBox.Show("Delete Information");
        }
    }
}
    

