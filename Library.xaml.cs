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
    /// Interaction logic for Library.xaml
    /// </summary>
    public partial class Library : Window
    {
        GoldenRhinoGameDistribution.GoldenRhinoDataContext context = new GoldenRhinoDataContext();
        public Library(int userid)
        {
            InitializeComponent();
            user = context.Login_regs.FirstOrDefault(u => u.ID == userid);
            addgamestogrid(GameGrid, context.Games.AsEnumerable(), user.ID);
            List<Purchace> purchaces = context.Purchaces.Where(purchase => purchase.UserID == userid).ToList();
            foreach(Purchace purchace in purchaces)
            {
                Label lbl = new Label();
                lbl.Content = purchace.Game.Title;
                lbl.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFC926");
                lbl.Height = 25;
                ownedGames.Children.Add(lbl);
            }
        }
        private Login_reg user;


        
        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int gameId = (int)button.GetValue(buttonGameIdProp);

            if (gameId == -1)
            {
                MessageBox.Show("An error ocurred please try again later");
                return;
            }

            if (context.Purchaces.Any(p => p.GameID == gameId && p.UserID == user.ID))
            {
                return;
            }

            context.Purchaces.InsertOnSubmit(new Purchace()
            {
                GameID = gameId,
                UserID = user.ID
            });

            context.SubmitChanges();
        }

        private void addgamestogrid(Grid grid, IEnumerable<Game> games, int userid)
        {
            grid.Children.Clear();
            foreach(Game game in games)
            {
                Grid gameGrid = new Grid();
                AddElemToGrid(gameGrid, CreateLabel($"Title: {game.Title}"));
                AddElemToGrid(gameGrid, CreateLabel($"Type: {game.TitleType}"));
                AddElemToGrid(gameGrid, CreateImage(game.image.ToArray()));
                AddElemToGrid(gameGrid, CreateLabel($"Cost: £{game.CostToUser}"));
                AddElemToGrid(gameGrid, CreateLabel($"Company: {game.Company}"));
                AddElemToGrid(gameGrid, CreateLabel($"Developers: {game.Developer}"));
                AddElemToGrid(gameGrid, CreateLabel($"Genre: {game.Genre}"));

                if (userid != -1)
                {
                    if (!game.Purchaces.Any(p => p.UserID == userid))
                    {
                        Button button = new Button();
                        button.Click += PurchaseButton_Click;
                        button.SetValue(buttonGameIdProp, game.ID);
                        button.Content = "Purchase";

                        AddElemToGrid(gameGrid, button);
                    }
                }

                AddElemToGrid(gameGrid, new Separator());

                AddElemToGrid(grid, gameGrid);

            }
        }
        #region uninportant



        public static DependencyProperty buttonGameIdProp = DependencyProperty.Register("gameId", typeof(int), typeof(Library), new PropertyMetadata(-1));
        public RowDefinition CreateRowDefinition()
        {
            RowDefinition rowDefinition = new RowDefinition();
            rowDefinition.Height = GridLength.Auto;
            return rowDefinition;
        }

        public T CreateElem<T>() where T : UIElement => Activator.CreateInstance<T>();

        public Label CreateLabel(string text)
        {
            Label l = CreateElem<Label>();
            l.Content = text;
            l.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFC926");
            return l;
        }

        public Image CreateImage(byte[] image)
        {
            Image img = CreateElem<Image>();
            BitmapImage bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.StreamSource = new MemoryStream(image);
            bitmap.EndInit();

            img.HorizontalAlignment = HorizontalAlignment.Left;
            img.MaxWidth = 200;
            img.MaxHeight = 200;

            img.Source = bitmap;
            return img;
        }

        public void AddElemToGrid<T>(Grid grid, T elem) where T : UIElement
        {
            int rowDefs = grid.RowDefinitions.Count;
            grid.RowDefinitions.Add(CreateRowDefinition());

            elem.SetValue(Grid.RowProperty, rowDefs);
            grid.Children.Add(elem);
        }
        #endregion
    }
}
