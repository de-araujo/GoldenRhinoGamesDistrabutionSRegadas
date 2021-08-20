using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GoldenRhinoGameDistribution
{
    /// <summary>
    /// Interaction logic for AddGame.xaml
    /// </summary>
    public partial class AddGame : Window
    {
        private OpenFileDialog imagePicker = new OpenFileDialog();
        public AddGame()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            GoldenRhinoGameDistribution.GoldenRhinoDataContext context = new GoldenRhinoDataContext();
            Game newGame = new Game() {
                Company = tbCompany.Text,
                Genre = tbGenre.Text,
                Quantity = int.Parse(tbQuantity.Text),
                CostToCompany = decimal.Parse(tbCompanyCost.Text),
                image = new System.Data.Linq.Binary(ReadToEnd(imagePicker.OpenFile())),
                CostToUser = decimal.Parse(tbPrice.Text),
                ReleaseDate = tbRelease.SelectedDate ?? DateTime.UtcNow,
                Title = tbTitle.Text,
                Developer = tbDevelopers.Text,
                DeliveryType = tbDeliveryType.Text,
                TitleType = tbTitleType.Text};
            context.Games.InsertOnSubmit(newGame);
            context.SubmitChanges();
            this.Close();
        }

        private void ImagePickerButton_Click(object sender, RoutedEventArgs e)
        {
            if (imagePicker.ShowDialog(this) == true)
            {
                ImagePickerButton.Content = imagePicker.FileName;
            }
        }
        public byte[] ReadToEnd(Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
    }
}
